using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class Student {
        public int id;
        public string Firstname;
        public string Lastname;
        public int SAT;
        public double GPA;
        public Major Major;

        public Student(int ID, string firstname, string lastname, int sat, double gpa, Major major) {
            id = ID;
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            Major = major;
        }

        public void Print() {
            Console.WriteLine($"{id}. {Firstname} {Lastname}, {SAT}, {GPA}, {Major.Description}");
        }


    }
}
