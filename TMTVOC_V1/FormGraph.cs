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
using ZedGraph;

namespace TMTVOC_V1
{
    public partial class FormGraph : Form
    {
        const string serializationFile = "enDatafile.bin";
        List<enoseData> endata = new List<enoseData>();
        private PointPairList pplvoc = new PointPairList();
        GraphPane myPane = new GraphPane();
        LineItem myCurve1;


        public FormGraph()
        {
            InitializeComponent();
            myPane = zedGraphControl1.GraphPane;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        void UpdateGraph()
        {
            loadData();
            fillPPL();

        }

        private void fillPPL()
        {
            for (int i = 0; i < endata.Count; i++)
            {
                XDate xdt = new XDate(endata[i].dateTime);
                pplvoc.Add(new PointPair(xdt, endata[i].VOC));
            }

            myCurve1 = myPane.AddCurve(null, pplvoc, Color.Blue, SymbolType.Circle);
            
            //myCurve1 = myPane.AddCurve(null, bp3.pplVOC, Color.Blue, SymbolType.Circle);
            myCurve1.Line.Width = 2.0F;
            myCurve1.Line.Color = Color.BlueViolet;

            myCurve1.Symbol.Fill.Type = FillType.Solid;
            myCurve1.Symbol.Size = 4.0F;
            myCurve1.Symbol.Border.Color = Color.Blue;
            myCurve1.Symbol.Fill = new Fill(Color.Blue);

            myPane.XAxis.Type = AxisType.Date;
            zedGraphControl1.IsEnableHZoom = true;
            zedGraphControl1.IsEnableVZoom = false;
            zedGraphControl1.IsEnableVPan = false;
            zedGraphControl1.GraphPane.XAxis.Scale.Format = "HH:mm:ss \n dd/MM";
            //myPane.XAxis.Scale.MinAuto = true;
            //myPane.XAxis.Scale.MaxAuto = true;
            zedGraphControl1.AxisChange();


            zedGraphControl1.Invalidate();










        }

        private void loadData()
        {
            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                endata = (List<enoseData>)bformatter.Deserialize(stream);
            }

        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            UpdateGraph();
        }
    }
}
