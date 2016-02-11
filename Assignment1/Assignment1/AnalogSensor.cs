using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class AnalogSensor
    {
        static Random rnd = new Random();
        private double _Value;
        private string _TagID;
        private string _EngUnit;
        //Setting the resolution and the range of the sensor
        private int _Resolution = Convert.ToInt32(Math.Pow(2, 20));
        private int _Lower = -1;
        private int _Upper = 1;


        public AnalogSensor(string TagID, double Value, string EngUnit )
        {
            _TagID = TagID;
            _Value = Value;
            _EngUnit = EngUnit;
        }
        public AnalogSensor(string TagID, string EngUnit)
        {
            _TagID = TagID;
            _EngUnit = EngUnit;
        }

        public AnalogSensor(string TagID)
        {
            _TagID = TagID;
        }
        public AnalogSensor()
        {

        }

        public String TagID
        {
            get
            {
                return _TagID;
            }
            set
            {
                _TagID = value;
            }
        }
        public double Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public string EngUnit
        {
            get
            {
                return _EngUnit;
            }
            set
            {
                _EngUnit = value;
            }
        }
        public void NewValue()
        {
            _Value = ((Convert.ToDouble(rnd.Next(0, _Resolution)) / _Resolution) * (_Upper-_Lower) +_Lower);
        }
    }
}
