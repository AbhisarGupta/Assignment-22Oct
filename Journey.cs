using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_22ndOctober
{
    class Journey
    {
        private double hrs;   
        private double min;  
        private double sec;

        public Journey()
        {
        }

        public Journey(int hrs,int min,int sec)
        {
            this.hrs = hrs;
            this.min = min;
            this.sec = sec;
        }
        public void Show()
        {
            Console.WriteLine($"{hrs}:{min}:{sec}");
        }
        

        
        public static Journey operator -(Journey j1, Journey j2)
        {
            Journey J = new Journey();
            J.hrs = j1.hrs - j2.hrs;
            J.min = j1.min - j2.min;
            J.sec = j1.sec - j2.sec;
            return J;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Journey j1 = new Journey(10,20,30); 
            Console.WriteLine($"Departure Time is ");
            j1.Show();
            Journey j2 = new Journey(5,4,20);  // 
            Console.WriteLine($"Arrival Time is ");
            j2.Show();
            Journey j3 = new Journey();   // 
           
            j3 = j1 - j2;
            Console.WriteLine("Journey Time is ");
            j3.Show();

            
            ;
        }
    }
}
