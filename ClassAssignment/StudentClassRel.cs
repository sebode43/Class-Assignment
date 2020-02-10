using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class StudentClassRel {
        public int ID;
        public Student Student;
        public Class Class;
        public string ClassGradeValue;

        public StudentClassRel(int id, Student studentid, Class classid, string classgradevalue) {
            ID = id;
            Student = studentid;
            Class = classid;
            ClassGradeValue = classgradevalue;
        }

        public void Print() {
            Console.WriteLine($"{ID}. {Student.Firstname} {Student.Lastname}, {Class.Subject}, {ClassGradeValue}");
        }

    }
}
