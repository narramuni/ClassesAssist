using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAssist
{
    public class CClass
    {

        private string name;
        private Teachers classTeacher;
        private List<Students> students;
        private List<Subjects> subjects;

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public Teachers ClassTeacher
        {
            get { return classTeacher; }
            set { classTeacher = value; }
        }

        public List<Students> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<Subjects>Subjects
            {
                get { return subjects; }
                set { subjects = value; }
            }
        }
    

}
