using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemComp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the EmployeeWage Computation Problem");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Employee();
        }
    }
}
