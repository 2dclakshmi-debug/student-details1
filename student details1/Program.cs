using System;

namespace student_details1
{
    public class Student
    {
        public static string CollegeName = "ABC College";
        public int stdID;
        public string stdName;
        public int age;
        public int sub1;
        public int sub2;
        public int sub3;
        public int sub4;
        public int sub5;
        public int sub6;

        public void AcceptStudentDetails()
        {

            Console.WriteLine("Enter Student ID :");
            stdID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student name :");
            stdName = Console.ReadLine();

            Console.WriteLine("Enter Student Age :");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Subject 1 marks :");
            sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 2 marks :");
            sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 3 marks :");
            sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 4 marks :");
            sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 5 marks :");
            sub5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 6 marks :");
            sub6 = int.Parse(Console.ReadLine());


        }
        public static void DisplayCollege()
        {
            Console.WriteLine("College name is : " + CollegeName);
        }

        public void DisplayStudentDetails()
        {
        
            Console.WriteLine("Student id is : " + stdID);
            Console.WriteLine("Student Name is : " + stdName);
            Console.WriteLine("Student age is : " + age);
            Console.WriteLine("subject 1 marks are :"+sub1);
            Console.WriteLine("subject 2 marks are : " + sub2);
            Console.WriteLine("subject 3 marks are :" + sub3);
            Console.WriteLine("subject 4 marks are : " + sub4);
            Console.WriteLine("subject 5 marks are :" + sub5);
            Console.WriteLine("subject 6 marks are : " + sub6);
            int total = sub1 + sub2 + sub3 + sub4 + sub5 + sub6;
            Console.WriteLine("Total marks are :" + total);
            int average = total / 6;
            Console.WriteLine("Average marks are  :" + average);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Student[] obj = new Student[2];

                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i] = new Student();
                    obj[i].AcceptStudentDetails();
                }
                for(int i = 0; i < obj.Length; i++)
                { 
                    obj[i].DisplayStudentDetails();
                }
                Student.DisplayCollege();
               
            }
        }
    }
}