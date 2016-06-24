using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(int age, string name,TypeGender gender)
            : base(age, name, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Miaw!!");
        }
        public override string ToString()
        {
            return String.Format("I am a Cat! Age:{0},Name:{1},Gender:{2}.", this.Age, this.Name, this.Gender);
        }
    }
}
