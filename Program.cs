using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {

            string[] arrSubjects = { "English ", "Maths", "Telugu", "History", "Social",  };
            string[] arrauthors = { "Jhon", "Lim", "Tim", "Bheem", "Joo" };



            string[] arrStudents = { "Arif", "Vineeth", "Laddu", "Kiran" };
            List<Students> listStudents = new List<Students>();
            List<Subjects> listSubjects = new List<Subjects>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subjects subject = new Subjects();
                subject.name = arrSubjects[i];

                subject.author = arrauthors[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Students student = new Students();
                student.name = arrStudents[i];
                student.address = "Some address";
                student.Id = 1;
                student.contact = "My Guardian";
                listStudents.Add(student);

            }

            Teachers classTeacher = new Teachers();
            classTeacher.Id = 01;
            classTeacher.name = "Shafi";
            classTeacher.dateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            

            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;


            Console.WriteLine("Class Name: " + class1A.Name);
            Console.WriteLine("Class Teacher: " + class1A.ClassTeacher.name);

            Console.WriteLine("Students in the class:");
            foreach (Students student in class1A.Students)
            {
                Console.WriteLine("- " + student.name);
            }

            Console.WriteLine("Subjects in the class:");
            foreach (Subjects subject in class1A.Subjects)
            {
                Console.WriteLine("- " + subject.name);
            }


            Console.ReadLine();
        }







    }

}
