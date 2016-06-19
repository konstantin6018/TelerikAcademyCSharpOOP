namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        private double size;
        private int numberOfColors;
        public Display(double size, int numberOfColors)
        {
            this.NumberOfColors = numberOfColors;
            this.Size = size;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value > 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("The size of the screen should be bigger then zero");
                }
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException("The number of screen colors should be bigger then zero");
                }
            }
        }
    }
}
