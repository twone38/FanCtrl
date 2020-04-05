﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreHardwareMonitor.Hardware;

namespace FanControl
{
    public class BaseControl
    {
        // Value
        public int Value { get; set; }

        public BaseControl()
        {
            Value = 0;
        }

        public virtual string getName()
        {
            return "";
        }

        public virtual void update()
        {

        }

        public virtual int getMinSpeed()
        {
            return 0;
        }

        public virtual int getMaxSpeed()
        {
            return 100;
        }

        public virtual int setSpeed(int value)
        {
            return 0;
        }
    }
}