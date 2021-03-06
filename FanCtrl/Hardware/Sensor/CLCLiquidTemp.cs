﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanCtrl
{
    public class CLCLiquidTemp : BaseSensor
    {
        private CLC mCLC = null;

        public CLCLiquidTemp(CLC clc, uint num) : base(SENSOR_TYPE.TEMPERATURE)
        {
            mCLC = clc;
            Name = "EVGA CLC Liquid";
            if (num > 1)
            {
                Name = Name + " #" + num;
            }
        }

        public override string getString()
        {
            if(OptionManager.getInstance().IsFahrenheit == true)
                return Util.getFahrenheit(Value) + " °F";
            else
                return Value + " °C";
        }
        public override void update()
        {
            Value = mCLC.getLiquidTemp();
        }
    }
}
