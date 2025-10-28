using System;
using System.Collections.Generic;
using System.Text;

using HRMUtil;

namespace HRMUtil
{
    public class LeaveDate
    {
        private DateTime _StartTime;
        private DateTime _EndTime;
        private double _Days;


        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        public DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        public double Days
        {
            get { return _Days; }
            set { _Days = value; }
        }

        public LeaveDate(DateTime startTime, DateTime endTime, double days)
        {
            _StartTime = startTime;
            _EndTime = endTime;
            _Days = days;
        }

       
    }
}
