using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyWage
{
    class CompanyWage 
    {
       
        public string CompanyName;        
        public int EmpRatePerHr;        
        public int MaxHrPerMonth;
        public int MaxWorkingDays;
        public int TotalWage;

        public CompanyWage(string CompanyName, int EmpRatePerHr, int maxHrPerMonth, int maxWorkingDays)
        {
            this.CompanyName = CompanyName;
            this.EmpRatePerHr = EmpRatePerHr;
            this.MaxHrPerMonth = maxHrPerMonth;
            this.MaxWorkingDays = maxWorkingDays;             
                }
        public void setTotalEmpWage(int TotalWage )
        {
            this.TotalWage = TotalWage;   
        }
        public string ToString()  //here we are getting total wage of differentCompanies
        {
            return "Total employee Wage for" + this.CompanyName + "is" + this.TotalWage;

        }

    }
}
