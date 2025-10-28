using System;
using System.Collections.Generic;
using System.Text;

namespace HRMUtil
{
    public class Unit
    {
        private int _UnitId;
        private string _UnitName;

        public Unit(int unitId, string unitName)
        {
            _UnitId = unitId;
            _UnitName = unitName;
        }

        public int UnitId
        {
            get { return _UnitId; }
            set { _UnitId = value; }
        }

        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }


    }
}
