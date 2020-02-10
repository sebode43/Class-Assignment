using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class ClassGrade {
        public string Grade;
        public double GPA;

        public ClassGrade(string grade, double gpa){
            Grade = grade;
            GPA = gpa;
        }

        public void Print() {
            Console.WriteLine($"{Grade}, {GPA}");
        }
    }
}
