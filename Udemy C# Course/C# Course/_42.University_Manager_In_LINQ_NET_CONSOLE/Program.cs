using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.University_Manager_In_LINQ_NET_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityCollection();

            int[] someInt = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInt orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }
            IEnumerable<int> reversedSortedInts = from i in someInt orderby i descending select i;
            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter University Id:");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Value");
            }

            Console.ReadKey();

        }

    }

    // This class will handle University and Students in LINQ way
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "Female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "Male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "Trans-Gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Frank", Gender = "Male", Age = 22, UniversityId = 2 });

        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male Students: ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femalStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("Male Students: ");
            foreach (Student student in femalStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Student Sorted by  Age");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities 
                                               on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;
            Console.WriteLine("Student From Beijing are:");
            foreach (Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                               join university in universities
                                               on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;
            Console.WriteLine("Student From Beijing {0} are:", Id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityCollection()
        {
            var newCollection = from student in students
                                join university in universities
                                on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection:");
            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }

    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} With id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // FOREIGN KEY
        public int UniversityId { get; set; }
        
        public void Print()
        {
            Console.WriteLine("Student {0} With id {1}, Gender {2} and Age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }

}
