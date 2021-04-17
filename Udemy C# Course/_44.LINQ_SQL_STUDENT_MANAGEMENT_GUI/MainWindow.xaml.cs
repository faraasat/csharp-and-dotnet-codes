using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _44.LINQ_SQL_STUDENT_MANAGEMENT_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["_44.LINQ_SQL_STUDENT_MANAGEMENT_GUI.Properties.Settings.dbStudentManConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            InsertUniversities();
            InsertStudents();
            InsertLectures();
            InsertStudentLectureAssociation();
            GetUniversityOfTony();
            GetLectureFromToni();
            GetAllStudentsFromYale();
            GetAllUniversitiesWithTransgenders();
            GetAllLecturesFromBeijingTech();
            UpdateToni();
            DeleteJames();
        }

        public void InsertUniversities()
        {
            // To delete previous data
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University bjt = new University();
            bjt.Name = "Beijing Tech";
            dataContext.Universities.InsertOnSubmit(bjt);

            dataContext.SubmitChanges();

            // To display on table on window
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {

            // Same as "from university in dataContext.University where university == "Yale" select university"
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale")); //First select first element from table 
            University bjt = dataContext.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Toni", Gender = "Male", University = yale });
            students.Add(new Student { Name = "Leyla", Gender = "Female", University = bjt });
            students.Add(new Student { Name = "James", Gender = "Trans-gender", University = bjt });

            dataContext.Students.InsertAllOnSubmit(students); // we InsertAllOnSubmit because it is a list

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {

            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Maths" }); 
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;

        }

        public void InsertStudentLectureAssociation()
        {

            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            Student Leyla = dataContext.Students.First(st => st.Name.Equals("Leyla"));
            Student James = dataContext.Students.First(st => st.Name.Equals("James"));

            Lecture Maths = dataContext.Lectures.First(lc => lc.Name.Equals("Maths"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Maths });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Maths });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = History });

            StudentLecture stLeyla = new StudentLecture();
            stLeyla.Student = Leyla;
            stLeyla.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(stLeyla);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = James, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }

        public void GetUniversityOfTony()
        {

            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            University TonisUniversity = Toni.University;

            List<University> universities = new List<University>();
            universities.Add(TonisUniversity);

            MainDataGrid.ItemsSource = universities;

        }

        public void GetLectureFromToni()
        {

            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            var tonisLectures = from sl in Toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;

        }

        public void GetAllStudentsFromYale()
        {

            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;
            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {

            var studentsFromTrans = from student in dataContext.Students
                                   join university in dataContext.Universities
                                   on student.University equals university
                                   where student.Gender == "Trans-gender"
                                   select university;
            MainDataGrid.ItemsSource = studentsFromTrans;
        }

        public void GetAllLecturesFromBeijingTech()
        {

            var lectureFromBjt = from sl in dataContext.StudentLectures
                                 join student in dataContext.Students
                                 on sl.StudentId equals student.Id
                                 where student.University.Name == "Beijing Tech"
                                 select sl.Lecture;
            MainDataGrid.ItemsSource = lectureFromBjt;
        }

        public void UpdateToni()
        {
            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name == "Toni"); //It returns the first value or a default value if not found

            Toni.Name = "Antonio";
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void DeleteJames()
        {
            Student James = dataContext.Students.FirstOrDefault(st => st.Name == "James");

            dataContext.Students.DeleteOnSubmit(James);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;


        }

    }
}
