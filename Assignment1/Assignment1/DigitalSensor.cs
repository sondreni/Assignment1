using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DigitalSensor
    {
        private int _Value; //Using 1 and 0 as true false instead of boolean
        private string _TagID;
        public DigitalSensor(string TagID, int Value)
        {
            _TagID = TagID;
            _Value = Value;
        }
        public DigitalSensor(string TagID)
        {
            _TagID = TagID;
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
        public int Value
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
    }
}
