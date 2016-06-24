    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.AnimalHierarchy
{
    class Kitten:Cat,ISound
    {
        public Kitten(int age, string name)
            : base(age, name,TypeGender.Female)
        {
          
        }
        public override void ProduceSound()
        {
            Console.WriteLine("I am a Kitten! Mauuuu!!");
        }
        public override string ToString()
        {
            return String.Format("I am a Kitten! Age:{0},Name:{1},Gender:{2}.", this.Age, this.Name, this.Gender);
        }
    }
}
