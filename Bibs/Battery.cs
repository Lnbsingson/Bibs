using System;
using System.Collections.Generic;
using System.Text;

namespace Bibs
{
    class Battery
    {
        public string Model;
        public int HoursIdle;
        public int HoursTalk;

        public Battery()
        {
            this.Model = null;
            this.HoursIdle = 0;
            this.HoursTalk = 0;

        }
        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = 0;
            this.HoursTalk = 0;

        }
        public Battery(string model, int hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = 0;

        }
        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }

        public string getModel
        {
            get { return Model; }
            set { this.Model = value; }
        }
        public int getHoursIdle
        {
            get { return HoursIdle; }
            set { this.HoursIdle = value; }
        }
        public int getHoursTalk
        {
            get { return HoursTalk; }
            set { this.HoursTalk = value; }
        }

    }
}
