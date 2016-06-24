namespace Problem2.StudentsAndWorkers
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
            List<Student> students = new List<Student>();
            students.Add(new Student("Todor", "Petrov", 5));
            students.Add(new Student("Dragan", "Cankov", 2));
            students.Add(new Student("Peter", "Petrov", 3));
            students.Add(new Student("Shisho", "Bakshisho", 6));
            students.Add(new Student("Georgi", "Chilev", 4));
            students.Add(new Student("Kaloqn", "Kirov", 3));
            students.Add(new Student("Ivan", "Zahariv", 6));
            students.Add(new Student("Petranka", "Ivanova", 3));
            students.Add(new Student("Horhe", "Bokai", 2));
            students.Add(new Student("Paulo", "Koelio", 2));

            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var sortedStudents = from student in students
                                 orderby student.StudentGrades, student.FirstName
                                 select student;
            Console.WriteLine("Students ordered by Grade: \n");

            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Georgi", "Nygolov", 1200, 9));
            workers.Add(new Worker("Dragan", "Hristov", 2231, 13));
            workers.Add(new Worker("Asq", "Petrova", 3455, 18));
            workers.Add(new Worker("Mincho", "Minchev", 123, 6));
            workers.Add(new Worker("Kurti", "Kurtev", 237, 3));
            workers.Add(new Worker("Grigor", "Dimitrov", 450, 3));
            workers.Add(new Worker("Danail", "Andreev", 260, 7));
            workers.Add(new Worker("Ivan", "Kostov", 125, 2));
            workers.Add(new Worker("Zarko", "Zahariev", 2300, 5));
            workers.Add(new Worker("Jelqzko", "Petrov", 123, 1));

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Workers ordered by MoneyPerHour: \n");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + " - Money per hour:{0:F2} ",worker.MoneyPerHour());
            }

            //Merge the lists and sort them by first name and last name.
            Console.WriteLine();
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortedHumans =
                from h in humans
                orderby h.FirstName ascending
                , h.SecondName ascending
                select h;
            Console.WriteLine("Sorted humans: \n");
            foreach (var h in sortedHumans)
            {
                Console.WriteLine(h);
            }
        }
    }
}