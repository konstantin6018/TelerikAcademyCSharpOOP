namespace OOP_Principles_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Discipline:IComments
    {
        private string name;
        private int numberOFLectures;
        private int numberOfExercises;
        public Discipline(string name, int numberOFLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOFLectures = numberOFLectures;
        }
        public string Name 
        
        {
            get 
            {
                return this.name;
            }

            private set
            {
               Verify.CheckIfNullOrEmpty(this.name,"Discipline must have name!");
                this.name = value;
            }
        }

        public int  NumberOFLectures 
        {
            get 
            {
                return this.numberOFLectures;
            }
            set
            {
                Verify.CheckIfNumberNegative(this.numberOFLectures,"The number of lectures must be positive!");
                this.numberOFLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                Verify.CheckIfNumberNegative(this.numberOfExercises, "The number of exercises must be positive!");
                this.numberOfExercises = value;
            }
        }
        public string Comment
        {
            get;

            set;
        }
    }
}
