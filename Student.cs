using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Student
    {
        public int rollNo;
        public string name;
        public string classs;
        public string sem;
        public string branch;
        public int[] marks = new int[5];
        
        public Student(int rollNo, string name,string classs, string sem, string branch, int[] marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.classs = classs;
            this.sem = sem;
            this.branch = branch;
            this.marks=marks;
        }
        public void Details()
        {
            Console.WriteLine("RollNo:{0}\t Name:{1}\t Class:{2} \tSem:{3} \tBranch:{4}, Marks:{5}", rollNo,name, classs,sem,branch,marks);
        }
        public void displayResult()
        {
            int sum = 0;
            foreach(int i in marks)
            {
                sum += i;
            }
            int avg = sum / 5;
            Console.WriteLine(avg);
            Console.WriteLine(sum);

            foreach (int i in marks)
            {
                if (i < 35)
                {
                    Console.WriteLine("Fail1");
                    Environment.Exit(0);
                }
            }
            if (avg < 50)
            {
                Console.WriteLine("Fail2");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Pass");
            }
                
        }
        static void Main(string[] args)
        {
            Student st = new Student(10, "Abhisar", "12th", "2nd", "Science", new int[] { 36, 40, 38, 40, 94 });
            //st.Details();
            st.displayResult();
        }
    }

}
