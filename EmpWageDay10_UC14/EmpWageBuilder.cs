using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageDay10_UC14
{
     public class EmpWageBuilder: IComputeEmpWage
    {
        public const int Is_PART_TIME = 1;
        public const int Is_FULL_TIME = 2;

        private LinkedList<EmployeeWageComputationProblem> CompanyEmpWagesList;
        private Dictionary<string, EmployeeWageComputationProblem> CompanyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.CompanyEmpWagesList = new LinkedList<EmployeeWageComputationProblem>();
            this.CompanyToEmpWageMap = new Dictionary<string, EmployeeWageComputationProblem>();

        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            EmployeeWageComputationProblem companyEmpWage = new EmployeeWageComputationProblem(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
            this.CompanyEmpWagesList.AddLast(companyEmpWage);
            this.CompanyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmployeeWage()
        {
            foreach(EmployeeWageComputationProblem companyEmpWage in this.CompanyEmpWagesList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmployeeWage(EmployeeWageComputationProblem));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int ComputeEmployeeWage(EmployeeWageComputationProblem companyEmpWage)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            while(emphrs <= companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numofWorkingDays)
            {


                workingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch(EmpCheck)
                {
                    case Is_FULL_TIME:
                        emphrs = 8;
                        break;

                    case Is_PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                hrs += emphrs;

                Console.WriteLine("Day " + workingDays + "Emp hrs :-" + emphrs);
            }

            return emphrs * companyEmpWage.empRatePerHour; 
        }

        public int getTotalWage(string company)
        {
            return this.CompanyToEmpWageMap[company].totalEmpWage;
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            throw new NotImplementedException();
        }
        public void ComputeEmpWage()
        {
            throw new NotImplementedException();
        }


    }
}
