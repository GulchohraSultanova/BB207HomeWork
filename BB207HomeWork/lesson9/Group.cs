using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson9
{
    internal class Group
    {
        

        public string No;
        public Student[] Students = new Student[0];
        public int StudentLimit;
        public int StudentCount;
        public Group(string no, int studentLimit)

        {
            No = no;
            StudentLimit = studentLimit;
            StudentCount = 0;
            Students = new Student[studentLimit];

        }
        public void AddStudent(Student student)
        {
            
            Students[StudentCount++] = student;
          
        }
       



    }
}
