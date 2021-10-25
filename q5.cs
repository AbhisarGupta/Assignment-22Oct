using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAssignment_2
{
    public class Student

    {
       protected int rollno; protected string name; protected int class_name; protected int sem; protected string branch; protected double total; protected double avg;
        protected  bool result = true;
        public Student(int rollno, string name, int class_name, int sem, string branch)
        {
            this.rollno = rollno;///rollno, name, class, SEM, branch
            this.name = name;
            this.class_name = class_name;
            this.sem = sem;
            this.branch = branch;
        }
        
    }
    public class Marks : Student
    { 
        int[] mark = new int[5];
        public Marks() : base(101, "Ram", 3, 1, "Science")
      
        {

        }

        public void compute()
         {
            Console.WriteLine($"Input the Marks of 5 subjects of {name} Roll no.{rollno} branch {branch} Semister {sem}");
            for (int i= 0;i < 5;i++)
                {
                mark[i] = Convert.ToInt32(Console.ReadLine());

                 }
            for (int i = 0; i < 5; i++)
            {
                total += mark[i];
            }
            avg = (total) / 5.0;
            Console.WriteLine($"Total marks is {total} and Average is {avg}");
            for (int i = 0; i < 5; i++)
            {

                if (mark[i] < 35)
                {
                    result = false;
                    return;

                }

            }
            if (avg < 50)
            {
                result = false;
            }
            else if (avg > 50)
                result = true;




        }
        public void display()
        {
            
            if (result == true)
            {
                Console.WriteLine($"Result of {name} Roll no.{rollno} branch {branch} Semister {sem} = Pass");
            }
            else
            {
                Console.WriteLine($"Result of {name} Roll no.{rollno} branch {branch} Semister {sem} =Fail");
            }


        }
    }
    interface Sports
    {
        public void CalWeight(double weight); 
    }
    public class StuWeight : Sports
    {
        public void CalWeight(double weight)
        {
            Console.WriteLine($"The weight is {weight} Kgs");
        }
    }

    public class Demo
    {

    static void Main(string[] args)
    {
            Marks M1 = new Marks();
            M1.compute();
            M1.display();
           

            StuWeight W1 = new StuWeight();
            W1.CalWeight(65.0);
           

    }


    }



}


                

       





