namespace Problem3.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Dog:Animal,ISound
    {
       public Dog(int age, string name,TypeGender gender)
            : base(age, name, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Bauuu!!");
        }
        public override string ToString()
        {
            return String.Format("I am a dog! Age:{0},Name:{1},Gender:{2}.", this.Age, this.Name, this.Gender);
        }
    }
}
