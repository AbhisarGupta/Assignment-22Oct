using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_22ndOctober
{
    class journey
    {
        private double hrs;   
        private double min;  
        private double sec;

        public journey()
        {
        }

        public journey(int hrs,int min,int sec)
        {
            this.hrs = hrs;
            this.min = min;
            this.sec = sec;
        }
        public void Show()
        {
            Console.WriteLine($"{hrs}:{min}:{sec}");
        }
        

        
        public static journey operator -(journey j1, journey j2)
        {
            journey Jour = new journey();
            Jour.hrs = j1.hrs - j2.hrs;
            Jour.min = j1.min - j2.min;
            Jour.sec = j1.sec - j2.sec;
            return J;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            journey j1 = new journey(10,20,30); 
            Console.WriteLine($"Departure Time: ");
            j1.Show();
            journey j2 = new journey(5,4,20);  // 
            Console.WriteLine($"Arrival Time: ");
            j2.Show();
            journey j3 = new journey();   // 
           
            j3 = j1 - j2;
            Console.WriteLine("Journey Time:");
            j3.Show();

            
            ;
        }
    }
}
