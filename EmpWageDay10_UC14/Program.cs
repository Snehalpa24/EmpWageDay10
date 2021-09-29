using System;

namespace EmpWageDay10_UC14
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder epWageBuilder = new EmpWageBuilder();
            epWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            epWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            epWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total Wage for DMart company : " + epWageBuilder.getTotalWage("DMart"));

        }
    }
}
