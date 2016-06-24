using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.AnimalHierarchy
{
    class Tomcat : Cat,ISound
    {
        public Tomcat(int age, string name)
            : base(age, name, TypeGender.Male)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("I am a Tomcat! Mauuuu!!");
        }
        public override string ToString()
        {
            return String.Format("I am a Tomcat! Age:{0},Name:{1},Gender:{2}.", this.Age, this.Name, this.Gender);
        }
    }
}