﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class AnalogSensor
    {
        private double _Value;
        private string _TagID;
        private string _EngUnit;
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

    }
}
