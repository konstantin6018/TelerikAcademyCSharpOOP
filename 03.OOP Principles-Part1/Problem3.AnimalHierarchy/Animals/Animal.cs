namespace Problem3.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    abstract class Animal:ISound
    {
        private int age;
        private string name;
        public Animal(int age, string name,TypeGender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }
        public int Age 
        {
            get 
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Animal age can not be smaller than 1!");
                }
                this.age = value;
            }
        }

        public string Name 
        {
            get 
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new Exception("Animal does not have name!");
                }
                this.name = value;
            }
        }
        public TypeGender Gender { get; private set; }

        public virtual void ProduceSound()
        {
         Console.WriteLine("I am making sound!");
        }
        public override string ToString()
        {
            return String.Format("I am an animal! Age:{0},Name:{1},Gender:{2}.",this.Age ,this.Name,this.Gender);
        }
    }
}
