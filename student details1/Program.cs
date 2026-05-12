using System;

namespace student_details1
{
    public class Student
    {
        public static string CollegeName;
        public int stdID;
        public string stdName;
        public int age;

        public void AcceptStudentDetails()
        {
            Console.WriteLine("Enter college name :");
            CollegeName = Console.ReadLine();

            Console.WriteLine("Enter Student ID :");
            stdID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student name :");
            stdName = Console.ReadLine();

            Console.WriteLine("Enter Student Age :");
            age = int.Parse(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("College name is : " + CollegeName);
            Console.WriteLine("Student id is : " + stdID);
            Console.WriteLine("Student Name is : " + stdName);
            Console.WriteLine("Student age is : " + age);
            Console.WriteLine();
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Student[] obj = new Student[100];

                for (int i = 0; i < 100; i++)
                {
                    obj[i] = new Student();

                    Console.WriteLine("Enter Details of Student " + (i + 1));

                    obj[i].AcceptStudentDetails();
                }

                Console.WriteLine("\nStudent Details:\n");

                for (int i = 0; i < 100; i++)
                {
                    obj[i].DisplayStudentDetails();
                }
            }
        }
    }
}