using System;
using System.Collections.Generic;
using System.Text;

using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class PositionsBLL
    {

        private PositionsTableAdapter _positionAdapter = null;
        protected PositionsTableAdapter Adapter
        {
            get
            {
                if (_positionAdapter == null)
                    _positionAdapter = new PositionsTableAdapter();

                return _positionAdapter;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.PositionsDataTable GetALlPositions()
        {
            HRM.PositionsDataTable obj = new HRM.PositionsDataTable();

            return Adapter.GetAllPositions();
        }

    }
}
