namespace Problem2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Human
    {
        public string firstName;
        public string secondName;
        public Human(string firstName,string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName 
        {
            get 
            {
                return this.firstName;
            }

           private set
            {
                this.firstName = value;
            }
        }
        public string SecondName
        {
            get
            {
                return this.secondName;
            }

            private set
            {
                this.secondName = value;
            }
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.SecondName;
        }
    }
}
