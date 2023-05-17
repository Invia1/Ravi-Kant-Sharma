using System;
using System.Collections.Generic;
using Day_8_Assignment;

namespace Day_8_Assignment.Service
{
    class StudentService
    {
        List<student> obj = new List<student>();
        public int addStudent(student temp) 
        {
            obj.Add(temp);
            return 1;
        }

        public List<student>  GetStudents()
        {
            foreach (student student in obj)
            {
                Console.WriteLine(student.studentId+" "+student.studentName+" "+student.studentRollNo);
            }
            return obj;
        }

        public void  updateStudents(int id)
        {
            List <student> students = GetStudents();

            foreach (student student in students)
            {
                if(id==student.studentId)
                {
                    student.studentId = id;
                    Console.WriteLine("Enter the new Name");
                    student.studentName=Console.ReadLine();

                    Console.WriteLine("Enter your new Roll Number");
                    student.studentRollNo=Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Id is not Matched.");
                }
                Console.WriteLine(student.studentId + " " + student.studentName + " " + student.studentRollNo);
            }
        }

        public void deleteStudent(int id)
        {
            student st = new student();
            List<student> students= GetStudents();
            foreach (student student in students)
            {
                if(id==student.studentId)
                {
                    st = student;
                }
            }
            if (obj.Remove(st))
            {
                Console.WriteLine("Id is Removed..");
            }
            else
            {
                Console.WriteLine("Id is not Matched..");
            }
        }

        public void SearchStudent(int id)
        {
            student student = new student();
            List <student> students = GetStudents();
            foreach (student temp in students)
            {
                Console.WriteLine("Name : "+ temp.studentName);
                Console.WriteLine("Roll Number : " +temp.studentRollNo);
            }
        }
            
        
    }
}
