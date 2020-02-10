using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class Instructor {
        public int ID;
        public string Firstname;
        public string Lastname;
        public int YearsExperience;
        public bool isTenured;

        public Instructor(int id, string firstname, string lastname, int Experience, bool Tenure){
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            YearsExperience = Experience;
            isTenured = Tenure;
            }

        public void Print() {
            Console.WriteLine($"{ID}. {Firstname}, {Lastname}, {YearsExperience}, {isTenured}");
        }




    }
}
