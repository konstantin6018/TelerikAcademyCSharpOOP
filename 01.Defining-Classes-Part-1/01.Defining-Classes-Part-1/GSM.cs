namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSM
    {
        private static readonly GSM iPhone4S = new GSM("Iphone4S", "Apple", 5, "Pesho", new Battery("B4", 5, 24, BatteryType.NiMH), new Display(10, 500));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer)
        {
            CallHistory = new List<Calls>();
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;

        }
        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price,owner)
        {
            this.Display = display;
            this.Battery = battery;
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
        public string Manufacturer
        {

            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("There is not an input for Manufacturer");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentNullException("There is not an input for Price");
                }
            }
        }
        public string Owner
        {

            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("There is not an input for Owner");
                }
                else
                {
                    this.owner = value;
                }
            }
        }
        public Battery Battery
        {

            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {

            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Calls> CallHistory { get; private set; }

        public void AddCall(Calls call)
        {                       
            CallHistory.Add(call);
        }

        public void DeleteCall(Calls call)
        {
            CallHistory.Remove(call);
        }

        public void DeleteCall(int callIndex)
        {
            CallHistory.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal GetTotalCallPrice(decimal pricePerMinute)
        {
            decimal allCallsInSecs = (decimal)(this.CallHistory.Select(x => x.Duration).Sum());
            return pricePerMinute * (allCallsInSecs / 60.0m);
        }
        public override string ToString()
        {
            return string.Format("The model of the phone is: {0} \nThe manufacturer of the phone is: {1} \nThe price is: ${2} \nThe owner of the phone is: {3} \nThe battery type is: {4} \nThe display size is: {5}",
                   this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery.BatteryType, this.Display.Size);
        }
    }
}

