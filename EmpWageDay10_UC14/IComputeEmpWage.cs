using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageDay10_UC14
{
    /*UC11 To 14  UC11 Ability to manage Employee Wage of multiple companies using API approach
      UC12 Refactor to have list of multiple companies to manage Employee Wage.
      UC13 Store the Daily Wage along with the Total Wage.
      UC14 Ability to get the Total Wage when queried by Company.
    */


    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth);

        public void ComputeEmpWage();

        public int getTotalWage(string company);
    }

    public class EmployeeWageComputationProblem
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMonth;
        public int totalempwage;
        internal int totalEmpWage;
    

        public EmployeeWageComputationProblem(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;

        }

            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalempwage = totalEmpWage;

            }

        public string toString()
        {
            return "Total Emp Wage  for company : " + company + "is :" + totalempwage;

        }
    }
}
