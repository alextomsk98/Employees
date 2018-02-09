using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesperson fred = new Salesperson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            PTSalesPerson genry = new PTSalesPerson("Genry", 19, 2, 16000, "652114", 0);
            genry.DisplayStats();
            genry.ReductionSalary();
            genry.DisplayStats();
            Console.ReadLine();
        }
    }
    }
