 namespace OOP_Principles_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Teacher:Person,IComments
    {
        private List<Discipline> discipline;
        public Teacher(string name):base(name)
        {
          this.discipline=new List<Discipline>();
        }
        public List<Discipline> Discipline
        {
            get
            {
                return new List<Discipline>(this.discipline);
            }
            private set
            {
                this.discipline = value;
            }
        }
        public void AddDiscipline(Discipline discipline)
        {
            this.Discipline.Add(discipline);
        }
        public void RemoveDiscipline(Discipline discipline)
        {
            this.Discipline.Remove(discipline);
        }
        public string Comment
        {
            get;

            set;
        }
    }
}
