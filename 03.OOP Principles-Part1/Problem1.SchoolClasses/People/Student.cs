namespace OOP_Principles_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student:Person,IComments
    {
        private int studentNumber;
        public Student(string name,int studentNumber):base(name)
        {
            this.StudentNumber = studentNumber;
        }
        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            private set 
            {
                Verify.CheckIfNumberNegative(this.studentNumber,"ID number of the student cant be negative!");
                this.studentNumber = value;
            }
        }

        public string Comment
        {
            get;

            set;
        }
    }
}
