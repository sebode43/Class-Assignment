using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment {
    class Major {//class ===================================================

        public int ID;
        public string Description;
        public int MinSat;

        public Major(int id, string description, int minsat) { //constructor
            ID = id;
            Description = description;
            MinSat = minsat;
            }
        
        public void Print() {
            Console.WriteLine($"{ID}. {Description}, {MinSat}");
        }
    }//clas =================================================================
}//namespace
