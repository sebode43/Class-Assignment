using System;

namespace ClassAssignment {
    class Program {
        static void Main(string[] args) {


            var majors = new Major[] {
                new Major(100, "General Business", 800),
                new Major(200, "Industrial Design", 1000),
                new Major(300, "Computer Engineering", 1400),
                new Major(400, "Math", 1100),
                new Major(500, "Education", 950)
            };

            //majors[0] = Business;
            //majors[1] = IDesign;
            //majors[2] = CEngineering;
            //majors[3] = Math;

            for (var idx = 0; idx < majors.Length; idx++) {
                var major = majors[idx];
                major.Print();
            }

            var students = new Student[] {
                new Student(1, "Kelly", "Hudsons", 1200, 3.75, majors[0]),
                new Student(2, "John", "Clarkson", 900, 3.4, majors[2]),
                new Student(3, "Gwen", "Sheldon", 1400, 3.95, majors[3]),
                new Student(4, "Blake", "Stephan", 1000, 3.6, majors[1]),
            };
        

        foreach(var student in students ) {
                student.Print();
            }



            var Carol = new Instructor(1, "Carol", "Junker", 7, true);

            var English = new Class(1, "English", 101, Carol);

            var GradeA = new ClassGrade("A", 4.00);

            var mcRel = new MajorClassRel(1, majors[1], English);

            var scRel = new StudentClassRel(1, students[1], English, "A");

            Carol.Print();
            English.Print();
            GradeA.Print();
            mcRel.Print();
            scRel.Print();
            }
        }
    }
