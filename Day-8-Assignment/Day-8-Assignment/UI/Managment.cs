using System;
using System.Collections.Generic;
using Day_8_Assignment;
using Day_8_Assignment.Service;

namespace Day_8_Assignment.UI
{
    class Managment
    {
        public static void Main()
        {
            student obj = new student();

            StudentService service = new StudentService();

            bool flag = true;
            while (flag)
            {
                int n;
                Console.WriteLine("Enter 1 For Add Student..");
                Console.WriteLine("Enter 2 For Get Student list..");
                Console.WriteLine("Enter 3 For Update Student..");
                Console.WriteLine("Enter 4 For Delete Student..");
                Console.WriteLine("Enter 5 For Search Student..");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Enter your choice...");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter student Id : ");
                        obj.studentId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Student Name : ");
                        obj.studentName = Console.ReadLine();
                        Console.WriteLine("Enter Student Roll Number : ");
                        obj.studentRollNo = int.Parse(Console.ReadLine());
                        service.addStudent(obj);
                        break;
                    case 2:
                        service.GetStudents();
                        break;
                    case 3:
                        Console.WriteLine("Enter Id to replace ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        service.updateStudents(id);
                        break;
                    case 4:
                        Console.WriteLine("Enter Id to Remove ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        service.deleteStudent(id1);
                        break;
                    case 5:
                        Console.WriteLine("Enter Id to search Student.");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        service.SearchStudent(id2);
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice..");
                        break;

                }
                string ch;
                Console.WriteLine("Do you want to Continue ? Enter 'Y' for Yes. Otherwise Press 'N'");
                ch = Console.ReadLine();
                if (ch =="Y" || ch =="y")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
        }
    }
}
