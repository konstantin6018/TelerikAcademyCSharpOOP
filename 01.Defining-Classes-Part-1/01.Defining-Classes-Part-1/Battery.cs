namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Battery
    {
        private string model;
        private double hoursIdel;
        private double hoursTalk;
        private BatteryType batterytype;
        public Battery(string model, double hoursIdel, double hoursTalk, BatteryType battery)
        {
            this.Model = model;
            this.HoursIdel = hoursIdel;
            this.HoursTalk = hoursTalk;
            this.BatteryType = battery;
        }
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("There is not an input for Model");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public double HoursIdel
        {
            get
            {
                return this.hoursIdel;
            }

            set
            {
                if (value > 0)
                {
                    this.hoursIdel = value;
                }
                else
                {
                    throw new ArgumentNullException("Hours of iddle of the Battery cannot be less or equal to zero!");
                }
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentNullException("Hours of talk of the Battery cannot be less or equal to zero!");
                }
            }

        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batterytype;
            }
            set
            {
                this.batterytype = value;
            }
        }
    }
}
