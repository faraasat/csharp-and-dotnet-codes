using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _43.LINQ_WITH_XML_NET_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            string studentXML =
                @"
                    <Students>
                        <Student>
                            <Name>Toni</Name>
                            <Age>21<Age>
                            <University>Yale</University>
                            <Semester>6</Semester>
                        </Student>
                        <Student>
                            <Name>Carla</Name>
                            <Age>17<Age>
                            <University>Yale</University>
                            <Semester>1</Semester>
                        </Student>
                        <Student>
                            <Name>Leyla</Name>
                            <Age>19<Age>
                            <University>Beijing Tech</University>
                            <Semester>3</Semester>
                        </Student>
                        <Student>
                            <Name>Frank</Name>
                            <Age>25<Age>
                            <University>Beijing Tech</University>
                            <Semester>10</Semester>
                        </Student>
                    </Students>
                ";

            XDocument studentsXDoc = new XDocument();
            studentsXDoc = XDocument.Parse(studentXML);
            var students = from student in studentsXDoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from university of {2} in Semester {3}", student.Name, student.Age, student.University, student.Semester);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from university of {2} in Semester {3}", student.Name, student.Age, student.University, student.Semester);
            }

            Console.ReadLine();
        }
    }
}
