using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class MajorClassRel {
        public int ID;
        public Major Major;
        public Class Class;

        public MajorClassRel(int id, Major major, Class classid) {
            ID = id;
            Major = major;
            Class = classid;
        }

        public void Print() {
            Console.WriteLine($"{ID}. {Major.Description}, {Class.Subject}");
        }
    }
}
