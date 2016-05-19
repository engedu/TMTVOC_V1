using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace TMTVOC_V1
{
    public partial class Form1 : RibbonForm
    {

        const int lineLenght = 70;
        const string tempFile = "enTempfile.txt";
        const string serializationFile = "enDatafile.bin";

        int currentView = 0;
        string EnStation = "001";

        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            ribbonHost3.Text = monthCalendar1.SelectionStart.ToShortDateString();
            ribbonHost3.HostCompleted();
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            ribbonHost1.Text = monthCalendar2.SelectionStart.ToShortDateString();
            ribbonHost1.HostCompleted();

        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                LoadData();
                while (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            if (currentView == 0)
                currentView = 2;
            switch (currentView)
            {
                case 1:
                    rbTableView_Click(null, null);
                    break;
                case 2:
                    rbGraphView_Click(null, null);
                    break;

            }

        }

        private HtmlAgilityPack.HtmlDocument htmldoc;
        private HtmlAgilityPack.HtmlWeb webget;

        List<enoseData> endata = new List<enoseData>();

        private void LoadData()
        {
            string begindate = monthCalendar1.SelectionStart.Year.ToString("D4") +
                monthCalendar1.SelectionStart.Month.ToString("D2") +
                monthCalendar1.SelectionStart.Day.ToString("D2");
            string enddate = monthCalendar2.SelectionStart.Year.ToString("D4") +
                monthCalendar2.SelectionStart.Month.ToString("D2") +
                (monthCalendar2.SelectionStart.Day + 1).ToString("D2");


            string url = "http://www.vocmontoyo.com/rdata.ashx?i=" + EnStation + "&fr=" + begindate + "0000&to=" + enddate + "0000";
            string[] formats = { "dd/MM/yyyy HH.mm", "dd/M/yyyy HH.mm", "dd/M/yyyy H.mm" };
            CultureInfo provider = CultureInfo.InvariantCulture;
            htmldoc = new HtmlAgilityPack.HtmlDocument();
            webget = new HtmlAgilityPack.HtmlWeb();
            try
            {
                htmldoc = webget.Load(url);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            string[] htmldocLine = htmldoc.DocumentNode.InnerText.Split(new string[] { "Time :" }, StringSplitOptions.None);
            StringBuilder sb = new StringBuilder();
            foreach (string s in htmldocLine)
            {
                if (s.Length > lineLenght)
                    sb.Append(s).AppendLine();
            }
            System.IO.File.WriteAllText(tempFile, sb.ToString());
            splitTempFile();

            List<enoseData> Sortedendata = endata.OrderBy(o => o.dateTime).ToList();

            //            dataGridView1.DataSource = endata;
            // save List of data
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, Sortedendata);
            }
        }

        private void splitTempFile()
        {
            DateTime oldTime = new DateTime();
            DateTime newTime = new DateTime();
            XDate xdt;
            double voc = 0.0d, co = 0.0d, co2 = 0.0d;
            int temp = 0, humid = 0;

            endata.Clear();
            oldTime = newTime = DateTime.Now;
            foreach (string line in System.IO.File.ReadLines(tempFile))
            {
                string[] s1 = line.Split(new string[] { " น.", ":", " ,", "," }, StringSplitOptions.None);

                newTime = DateTime.ParseExact(s1[0], "dd/MM/yyyy HH.mm", CultureInfo.InvariantCulture);
                TimeSpan diff = newTime.Subtract(oldTime);
                //http://stackoverflow.com/questions/9017498/calculating-how-many-minutes-there-are-between-two-times
                if (diff.Minutes > 1)
                {
                    Console.WriteLine(diff.Minutes.ToString());
                    newTime.AddMilliseconds(10);
                    xdt = new XDate(newTime);
                    voc = double.NaN;
                    co = double.NaN;
                    co2 = double.NaN;
                    temp = 0;
                    humid = 0;
                }
                else
                {
                    xdt = new XDate(newTime);
                    temp = Convert.ToInt32(s1[2]);
                    humid = Convert.ToInt32(s1[4]);
                    voc = Convert.ToDouble(s1[6]);
                    co = Convert.ToDouble(s1[8]);
                    co2 = Convert.ToDouble(s1[10]);
                }
                oldTime = newTime;
                endata.Add(new enoseData { VOC = voc, CO = co, CO2 = co2, humid = humid, temp = temp, dateTime = newTime });
            }
        }

        private void rbGraphView_Click(object sender, EventArgs e)
        {
            currentView = 2;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormGraph))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new FormGraph();
            form.MdiParent = this;
            form.Show();
        }

        private void rbTableView_Click(object sender, EventArgs e)
        {
            currentView = 1;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormTable))
                {
                    f.Activate();
                    return;
                }
            }
            Form form = new FormTable();
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonComboBoxDateBegin.TextBoxText = monthCalendar1.TodayDate.ToShortDateString();
            ribbonComboBoxDateEnd.TextBoxText = monthCalendar2.TodayDate.ToShortDateString();
            toolStripStatusLabel1.Text = "Station: " + EN001.Text;
        }

        private void EN001_Click(object sender, EventArgs e)
        {
            EnStation = "001";
            toolStripStatusLabel1.Text = "Station: " + EN001.Text;
        }

        private void EN002_Click(object sender, EventArgs e)
        {
            EnStation = "002";
            toolStripStatusLabel1.Text = "Station: " + EN002.Text;
        }

        private void EN003_Click(object sender, EventArgs e)
        {
            EnStation = "003";
            toolStripStatusLabel1.Text = "Station: " + EN003.Text;

        }

        private void EN004_Click(object sender, EventArgs e)
        {
            EnStation = "004";
            toolStripStatusLabel1.Text = "Station: " + EN004.Text;

        }

        private void EN005_Click(object sender, EventArgs e)
        {
            EnStation = "005";
            toolStripStatusLabel1.Text = "Station: " + EN005.Text;
        }

        private void EN006_Click(object sender, EventArgs e)
        {
            EnStation = "006";
            toolStripStatusLabel1.Text = "Station: " + EN006.Text;
        }

        private void EN007_Click(object sender, EventArgs e)
        {
            EnStation = "007";
            toolStripStatusLabel1.Text = "Station: " + EN007.Text;
        }

        private void EN008_Click(object sender, EventArgs e)
        {
            EnStation = "008";
            toolStripStatusLabel1.Text = "Station: " + EN008.Text;
        }

        private void EN009_Click(object sender, EventArgs e)
        {
            EnStation = "009";
            toolStripStatusLabel1.Text = "Station: " + EN009.Text;

        }

        private void EN010_Click(object sender, EventArgs e)
        {
            EnStation = "008";
            toolStripStatusLabel1.Text = "Station: " + EN008.Text;

        }

        private void EN011_Click(object sender, EventArgs e)
        {
            EnStation = "008";
            toolStripStatusLabel1.Text = "Station: " + EN008.Text;

        }

        private void EN012_Click(object sender, EventArgs e)
        {
            EnStation = "008";
            toolStripStatusLabel1.Text = "Station: " + EN008.Text;

        }

        private void ribbonTab1_ActiveChanged(object sender, EventArgs e)
        {

        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(DateTime.Now);
            monthCalendar2.SetDate(DateTime.Now);
            ribbonComboBoxDateBegin.TextBoxText = monthCalendar1.TodayDate.ToShortDateString();
            ribbonComboBoxDateEnd.TextBoxText = monthCalendar2.TodayDate.ToShortDateString();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            rbTableView_Click(null, null);
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormTable))
                {
                    //f.Activate();
                    //MessageBox.Show("Found table form");
                    FormTable ft = f as FormTable;
                    ft.SaveTable();
                    return;
                }
            }
        }
    }
}
