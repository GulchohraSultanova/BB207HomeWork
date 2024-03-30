using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson9
{
    internal class Program
    {
        //Menu
        static void Main(string[] args)
        {
            Group group=CreateGroup();
            bool flag=false;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------Welcome my GroupApp-----------");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Added Student in Group!");
                Console.WriteLine("2.Show Students in Group!");
                Console.WriteLine("3.Search of Students!");
                Console.WriteLine("0.Exit GroupApp....");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
            
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        AddStudentToGroup(group);
                        break;
                     case "2":
                         ShowAllStudents(group);

                        break;
                     case "3":
                         SearchNameInGroup(group);
                        break;
                      case "0":
                        Console.WriteLine("Exiting the program...");
                          flag = true;
                          break;
                    default:
                        Console.WriteLine("This is not correct! Please, enter correct choice!");
                        break;
                }

            } while (!flag);
        }
        // Yeni Qrupun yaradilmasi
        static Group CreateGroup()
        {
            string no;
            int studentLimit;

            do
            {
                Console.WriteLine("Enter the group name: ");
                no = Console.ReadLine();

            } while (!IsCorrectNo(no));
            do
            {
                Console.WriteLine("Enter the student limit: ");

            } while (!int.TryParse(Console.ReadLine(), out studentLimit) || studentLimit < 0 || studentLimit > 20);
            return new Group(no, studentLimit);
        }

        // Qrup nomresinin dogru daxil olundugunun yoxlanilmasi
        static bool IsCorrectNo(string no)
        {
            if (no.Length != 5)
            {
                return false;
            }
            if (!char.IsLetter(no[0]) || !char.IsLetter(no[1]))
            {
                return false;
            }
            if (!char.IsUpper(no[0]) || !char.IsUpper(no[1]))
            {
                return false;
            }
            if (!char.IsDigit(no[2]) || !char.IsDigit(no[3]) || !char.IsDigit(no[4]))
            {
                return false;
            }
            return true;
        }
        //Telebeni uygun oldugu grupa elave eden metod
        static void AddStudentToGroup(Group group)
        {
           if(group.StudentCount<group.StudentLimit)
            {
                Student student = new Student();
                Console.WriteLine("Enter the student name and surname: ");
                student.FullName = Console.ReadLine();
                student.GroupNo = group.No;
                double avgPoint;
                do
                {
                    Console.WriteLine("Enter the average point: ");
                } while (!double.TryParse(Console.ReadLine(), out avgPoint));
                student.AvgPoint = avgPoint;
                group.AddStudent(student);
            }
            else
            {
                Console.WriteLine("Student limit reached for this group.");

            }
        }
        //Groupda olan telebelerin gosterilmesi
        static void ShowAllStudents(Group group)
        {
            Console.WriteLine($"Group name:{group.No}");
            Console.WriteLine("Students: ");
            foreach (Student student in group.Students)
            {
                if (student != null)
                {
                    Console.WriteLine($"Name and surname: {student.FullName},Average point: {student.AvgPoint}");
                }
            }
        }
        //Her hansi bir telebe adinin qrupda axtarilmasi
        static void SearchNameInGroup(Group group)
        {
            Console.WriteLine("Enter the name and surname of the student you want to search for:");
            string searchName = Console.ReadLine();
            bool flag= false;
         
            foreach (Student student in group.Students)
            {
                if (student != null && student.FullName == searchName) 
                {
                    Console.WriteLine($"Name and surname: {student.FullName},Average point: {student.AvgPoint}");
                    flag = true;
                }
                
            }
            if (!flag)
            {
                Console.WriteLine("This student is not in group.");
            }
        }
    }
}
