using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var TIY = new School();
            var Houston = new Campus("Houston");
            var dotNET = new Classroom(".NET");
            
            var bryan = new Student("Bryan");
            var shadi = new Student("Shadi");
            var chris = new Student("Chris");
            // dotNET.students empty
            dotNET.students.Add(bryan);
            dotNET.students.Add(shadi);
            dotNET.students.Add(chris);
            // dotNET.students.Count == 3
            Houston.classrooms.Add(dotNET);
            TIY.campuses.Add(Houston);
        }
    }

    public class School {
        public List<Campus> campuses = new List<Campus>();
    }

    public class Campus {
        public List<Classroom> classrooms = new List<Classroom>();
        public string name;
        public Campus(string name){
            this.name = name;
        }
    }

    public class Classroom {
        public string name;
        public List<Student> students = new List<Student>();
        public Classroom(string name){
            this.name = name;
        }
    }

    public class Student {
        public string name;
        public Student(string name){
            this.name = name;
        }
    }

    public class Mascot {}

}
