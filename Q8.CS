using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22ndOctober
{
    class Q8
    {
        interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }
     class TCS:GovtRules
        {
            public int empID;
            public double basic_salary;
            public string name, dept, designation;
            public void TCSconstructor(int eID, double bSalary, string name, string department, string desg)
            {
                empID = eID;
                basic_salary = bSalary;
                this.name = name;
                dept = department;
                designation = desg;
                Console.WriteLine("\nEmpID:" + empID);
                Console.WriteLine("Name:" +name);
                Console.WriteLine("Basic Salary:" +basic_salary);
                Console.WriteLine("Department:" +dept);
                Console.WriteLine("Designation:" +designation);

            }
            public double EmployeePF(double basic_salary)
            {
                double PF = 0.12 * basic_salary;
                double PFempContribution = 0.0833 * basic_salary;
                double pensionFund = 0.0367 * basic_salary;
                Console.WriteLine("PF:" + PF);
                Console.WriteLine("PF Employee Contribution:" + PFempContribution);
                Console.WriteLine("Pension Fund:" + pensionFund);
                return 1;
            }
            public string LeaveDetails()
            {
                int casualLeavePerYear = 12;
                int sickLeavePerYear = 12;
                int privilegeLeavePerYear = 10;
                Console.WriteLine("Casual Leaves:" + casualLeavePerYear);
                Console.WriteLine("Sick Leaves:" + sickLeavePerYear);
                Console.WriteLine("Privilege Leaves:" + privilegeLeavePerYear);
                return null;
            }
            public double gratuityAmount(float serviceCompleted, double basicSalary)
            {
                double gratAmount = 0;
                if (serviceCompleted < 5)
                {
                    gratAmount = 0;
                }
                else if (serviceCompleted > 5 && serviceCompleted<10)
                {
                    gratAmount = basic_salary;
                }
                else if (serviceCompleted > 10 && serviceCompleted<20)
                {
                    gratAmount = 2 * basic_salary;
                }
                else
                {
                    gratAmount = 3 * basic_salary;
                }
                Console.WriteLine("Gratuity Amount is:" + gratAmount);
                return 1;
            }

        }
        class Accenture:GovtRules
        {
            public int empID, basic_salary;
            public string name, dept, designation;
            public void Accentureconstructor(int eID, int bSalary, string name, string department, string desg)
            {
                empID = eID;
                basic_salary = bSalary;
                this.name = name;
                dept = department;
                designation = desg;
                Console.WriteLine("\nEmpID:" + empID);
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Basic Salary:" + basic_salary);
                Console.WriteLine("Department:" + dept);
                Console.WriteLine("Designation:" + designation);
            }
            public double EmployeePF(double basic_salary)
            {
                double PF = 0.12 * basic_salary;
                double PFempContribution =0.12 * basic_salary;
                Console.WriteLine("PF:" + PF);
                Console.WriteLine("PF Employee Contribution:" + PFempContribution);
                return 1;
            }
            public string LeaveDetails()
            {
                int casualLeavePerYear = 24;
                int sickLeavePerYear = 5;
                int privilegeLeavePerYear = 5;
                Console.WriteLine("Casual Leaves:" + casualLeavePerYear);
                Console.WriteLine("Sick Leaves:" + sickLeavePerYear);
                Console.WriteLine("Privilege Leaves:" + privilegeLeavePerYear);
                return null;
            }
            public double gratuityAmount(float serviceCompleted, double basicSalary)
            {
                Console.WriteLine("Gratuity is Not Applcable");
                return 1;
            }
        }
        static void Main(string[] args)
        {
            TCS tcs = new TCS();
            Accenture acc = new Accenture();
            tcs.TCSconstructor(432,10000,"Rahul","Finance","Software Engineer");
            tcs.gratuityAmount(11, tcs.basic_salary);
            tcs.EmployeePF(tcs.basic_salary);
            acc.Accentureconstructor(123, 1000, "Priya", "Finance", "Analyst");
            acc.EmployeePF(acc.basic_salary);
            acc.gratuityAmount(10, acc.basic_salary);
        }
    }
}
