using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace TMTVOC_V1
{
    [Serializable]
    class enoseData
    {
        //private XDate _xdt;
        private int _temp;
        private int _humid;
        private double _co;
        private double _co2;
        private double _voc;

        private DateTime _dt;
        [DisplayName("Date-Time")]
        public DateTime dateTime
        {
            get { return _dt; }
            set { _dt = value; }
        }

        [DisplayName("Temperature")]
        public int temp
        {
            get { return _temp; }
            set { _temp = value; }
        }

        [DisplayName("Humidity")]
        public int humid
        {
            get { return _humid; }
            set { _humid = value; }
        }

        [DisplayName("Carbon Monoxide")]
        public double CO
        {
            get { return _co; }
            set { _co = value; }
        }

        [DisplayName("Carbon Dioxide")]
        public double CO2
        {
            get { return _co2; }
            set { _co2 = value; }
        }

        [DisplayName("VOC.")]
        public double VOC
        {
            get { return _voc; }
            set { _voc = value; }
        }

       //[Browsable(false)]
       // public XDate xdt
       // {
       //     get { return _xdt; }
       //     set { _xdt = value; }
       // }

    }
}
