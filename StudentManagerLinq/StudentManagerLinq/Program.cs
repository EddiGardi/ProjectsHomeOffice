using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromHSU();
            um.StudentsFromUniByUniId();
            um.StudentAndUniversityNameCollection();

            int[] someInts = { 30, 12, 4, 3, 12 };
            // Sotieren und umderehen
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            // direkt rückwarts sortiert
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Konstruktor
        public UniversityManager()
        {
            //Initialisieren
            universities = new List<University>();
            students = new List<Student>();

            //Befüllen der Universitätslisten
            universities.Add(new University { Id = 1, Name = "HSU" });
            universities.Add(new University { Id = 2, Name = "UniBwM" });

            //Befüllen der Studententliste
            students.Add(new Student { Id = 1, Name = "Chris Renkes", Gender = "Male", Age = 26, UniversityId = 2 });
            students.Add(new Student { Id = 2, Name = "David Kramer", Gender = "Male", Age = 26, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Toni", Gender = "Male", Age = 19, UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "Carla", Gender = "Female", Age = 23, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Nina", Gender = "Female", Age = 22, UniversityId = 1 });
            students.Add(new Student { Id = 5, Name = "Michael", Gender = "Male", Age = 21, UniversityId = 2 });
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Studenten sortiert nach Alter");
            foreach (var item in students)
            {
                item.Print();
            }
        }

        public void MaleStudents ()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Männliche Studenten");
            foreach (Student item in maleStudents)
            {
                item.Print();
            }
        }

        public void FemaleStudents ()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("Weibliche Studenten");
            foreach (Student item in femaleStudents)
            {
                item.Print();
            }
        }

        public void AllStudentsFromHSU ()
        {
            IEnumerable<Student> hsuStudents = from student in students
                                               join university in universities on student.UniversityId
                                               equals university.Id
                                               where university.Name == "HSU"
                                               select student;
            Console.WriteLine("Studenten der HSU:");
            foreach (var item in hsuStudents)
            {
                item.Print();
            }
        }

        public void StudentsFromUniByUniId ()
        {
            Console.WriteLine("Wie lautet die Id der Universität?");
            try
            {
                int writtenID = Convert.ToInt32(Console.ReadLine());

                IEnumerable<Student> studentsByUniId = from student in students
                                                       join university in universities on student.UniversityId
                                                       equals university.Id
                                                       where university.Id == writtenID
                                                       select student;
                Console.WriteLine("Stundenten an der gewählten Uni:");
                foreach (var item in studentsByUniId)
                {
                    item.Print();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Falscher Wert");
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId
                                equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("Neue Sammlung");
            foreach (var item in newCollection)
            {
                Console.WriteLine("Student {0} von der {1}", item.StudentName, item.UniversityName);
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Universität {0} mit der Id {1}.", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key = Fremdschlüssel
        public int UniversityId { get; set; }

        public void Print ()
        {
            Console.WriteLine("Student {0} mit der Id {1}, dem Geschlecht {2} " +
                "und Alter {3} von der Universität mit der Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }

}
