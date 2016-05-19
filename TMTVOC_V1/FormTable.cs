using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMTVOC_V1
{
    public partial class FormTable : Form
    {
        const string serializationFile = "enDatafile.bin";
        public FormTable()
        {
            InitializeComponent();
        }
        List<enoseData> endata = new List<enoseData>();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        public void loadTable()
        {
            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                  endata = (List<enoseData>)bformatter.Deserialize(stream);
            }
            dataGridView1.DataSource = endata;
            dataGridView1.Columns["DateTime"].DisplayIndex = 0;
            dataGridView1.Columns["temp"].DisplayIndex = 1;
            dataGridView1.Columns["humid"].DisplayIndex = 2;
            dataGridView1.Columns["voc"].DisplayIndex = 3;
            dataGridView1.Columns["co"].DisplayIndex = 4;
            dataGridView1.Columns["co2"].DisplayIndex = 5;

        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        public void SaveTable()
        {
            saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.AddExtension = true;
             
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writeCSV(dataGridView1, saveFileDialog1.FileName);
                MessageBox.Show("Converted successfully to *.csv format");
            }

        }
        public void writeCSV(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile);

                //write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(gridIn.Columns[i].HeaderText);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        if (dr.Cells[i].Value == null)
                            value = "";
                        else
                            value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }
        }


    }
}
