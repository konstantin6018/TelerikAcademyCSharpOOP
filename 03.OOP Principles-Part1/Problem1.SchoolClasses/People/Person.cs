namespace OOP_Principles_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Person
    {
        private string name;
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name 
        { 
            get 
            {
                return this.name;
            }
           private set
            {
                Verify.CheckIfNullOrEmpty(this.name,"The person must have name!");
                this.name = value;
            }
        }
    }
}
