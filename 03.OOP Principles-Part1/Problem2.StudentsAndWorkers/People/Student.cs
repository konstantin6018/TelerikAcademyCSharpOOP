namespace Problem2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student : Human
    {
        private int studentGades;
        public Student(string firstName, string secondName, int studentGades):base(firstName, secondName)
        {
            this.StudentGrades = studentGades;
        }
        public int StudentGrades
        {
            get
            {
                return this.studentGades;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new Exception("The student garde cant be negative ,lower than 2 and higher than 6");
                }
                else
                {
                    this.studentGades = value;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("{0} {1} Grade:{2}", this.FirstName, this.SecondName, this.StudentGrades);
        }
    }
}
