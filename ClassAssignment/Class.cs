using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class Class {
        public int ID;
        public string Subject;
        public int Section;
        public Instructor Instructor;

        public Class(int id, string subject, int section, Instructor instructor) {
            ID = id;
            Subject = subject;
            Section = section;
            Instructor = instructor;
        }
        public void Print() {
            Console.WriteLine($"{ID}. {Subject}, {Section}, {Instructor.Firstname} {Instructor.Lastname}");
        }


    }
}
