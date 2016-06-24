namespace Problem3.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++Cats+++++");
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat(3, "Pesho", TypeGender.Male));
            cats.Add(new Cat(4, "Gergana", TypeGender.Female));
            cats.Add(new Cat(5, "Pesho", TypeGender.Male));
            cats.Add(new Cat(3, "Petq", TypeGender.Female));
            cats.Add(new Cat(7, "Pesho", TypeGender.Male));

            foreach (Cat cat in cats)
            {
                Console.WriteLine(cat);
            }
            var avarageCatAge = cats.Sum(x => x.Age) / (double)cats.Count;
            Console.WriteLine("Avarage cat age: " + avarageCatAge);
            
            Console.WriteLine();
            Console.WriteLine("+++++Kittens+++++");
            List<Kitten> kittens = new List<Kitten>();
            kittens.Add(new Kitten(2, "Petra"));
            kittens.Add(new Kitten(4, "Petra"));
            
            foreach (Kitten kitten in kittens)
            {
                Console.WriteLine(kitten);
            }

            var avarageKittenAge = kittens.Sum(x => x.Age) / (double)kittens.Count;
            Console.WriteLine("Avarage kitten age: " + avarageKittenAge);

            Console.WriteLine();
            Console.WriteLine("+++++Dogs+++++");
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog(17, "Pesho", TypeGender.Male));
            dogs.Add(new Dog(4, "Gergana", TypeGender.Female));
            dogs.Add(new Dog(12, "Pesho", TypeGender.Male));
            dogs.Add(new Dog(3, "Petq", TypeGender.Female));
            dogs.Add(new Dog(10, "Pesho", TypeGender.Male));
           
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog);
            }

            var avarageDogAge = dogs.Sum(x => x.Age) / (double)dogs.Count;
            Console.WriteLine("Avarage dog age: " + avarageDogAge);
        }
    }
}
