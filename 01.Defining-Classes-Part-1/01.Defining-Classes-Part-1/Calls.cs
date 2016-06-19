namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Calls
    {
        private string date;
        private string time;
        private string phoneNumber;
        private int duration;


        public Calls(string date, string time, string phoneNumber, int duration)
        {

            this.Duration =  duration;
            this.Date = date;
            this.Time = time;
            this.PhoneNumber = phoneNumber;
        }

        public string Date
        {
            get
            {
                return this.date;
            }

            set
            {
                if (value != string.Empty && value != null)
                {
                    this.date = value;
                }
                else
                {
                    throw new ArgumentNullException("There is not input for date");
                }
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.time = value;
                }
                else
                {
                    throw new ArgumentNullException("There is not input for Time");
                }
            }

        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new ArgumentNullException("There is not input for dialedPhoneNumber");
                }
            }
        }
        public int Duration 
        {
            get 
            {
                return this.duration;
            }

            set 
            {
                if (value > 0)
                {
                    this.duration = value;
                }
                else
                {
                    throw new ArgumentNullException("The input is null");
                }
            } 
        }
        public override string ToString()
        {
            //List<string> info = new List<string>();

            //info.Add("Call Date - " + this.Date);
            //info.Add("Call Time - " + this.Time);
            //info.Add("Number Called - " + this.PhoneNumber);
            //info.Add("Call Duration - " + this.Duration);

            //return String.Join(Environment.NewLine, info);

          return String.Format("Call date: {0} \nCall time: {1} \nPhone number: ${2} \nDuration: {3} \n",
                   this.Date, this.Time, this.PhoneNumber, this.Duration);
        }
    }
}
