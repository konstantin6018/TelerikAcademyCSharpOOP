namespace OOP_Principles_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Class : IComments
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string uniqueTextIdentifier;
        public Class()
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
        }
        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }

            set
            {
                this.uniqueTextIdentifier = value;
            }
        }
        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
            set
            {
                this.students = value;
            }
        }
        public void AddStudent(Student students)
        {
            this.Students.Add(students);
        }
        public void RemoveStudent(Student students)
        {
            this.Students.Remove(students);
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }

            set 
            {
                this.teachers = value;
            }
        }
        public void AddTeacher(Teacher teachers)
        {
            this.Teachers.Add(teachers);
        }
        public void RemoveStudent(Teacher teachers)
        {
            this.Teachers.Remove(teachers);
        }

        public string Comment
        {
            get;

            set;
        }
    }
}
