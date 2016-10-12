using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication
{

    public class Program
    {
        public static string join(IEnumerable<string> arr){
            string s = "";
            foreach(var item in arr){
                s += item;
            }
            return s;
        }

        public static string join(IEnumerable<char> arr){
            string s = "";
            foreach(var item in arr){
                s += item;
            }
            return s;
        }

        public static string camel(string word){
            char[] chars = word.ToCharArray();
            chars[0] = Char.ToUpper(chars[0]);
            return join(chars);
        }

        public static string camelAll(IEnumerable<string> words){
            List<string> result = new List<string>();
            foreach(string w in words){
                result.Add(camel(w));
            }
            return join(result);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(camel("hello"));

            List<string> otherWords = new List<string>();
            otherWords.Add("hello");
            otherWords.Add("world");
            otherWords.Add("i");
            otherWords.Add("am");
            otherWords.Add("legend");

            string[] words = "hello world i am legend".Split(new char[]{ ' ' });

            Console.WriteLine( camelAll(words) );
            Console.WriteLine( camelAll(otherWords) );

            // requires 'using System.Linq'
            Console.WriteLine( join(words.Select(w => camel(w))) );
            Console.WriteLine( join(words.Select(w =>
                Char.ToUpper(w[0]) + w.Substring(1)
            )) );

            Console.WriteLine( join(otherWords) );

            Console.WriteLine( join(words) );

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

            Console.WriteLine("Current students: {0}", dotNET);
            Console.WriteLine("Hi! You need moar students! What's his or her name?");

            var newStudent = new Student(Console.ReadLine());
            dotNET.students.Add(newStudent);
            Console.WriteLine("------------");
            Console.WriteLine("New roster of students: {0}", dotNET);

            Console.ReadLine();
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
        public override string ToString(){
            string result = "";
            // walk over each student in students and append to result
            foreach(Student s in students){
                result = result+", "+s;
            }
            return result;
        }
    }

    public class Student {
        public string name;
        public override string ToString(){
            return name;
        }
        public Student(string name){
            this.name = name;
        }
    }

    public class Mascot {}

}
