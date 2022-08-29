using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyWage
{
    public interface IEmpMonthlyWage
    {
        public void AddEmpWage(string CompanyName, int EmpRatePerHr, int maxHrPerMonth, int maxWorkingDays);
        public void ComputeEmpWage();
        
    }

        class EmployeeWage : IEmpMonthlyWage
        {
            public int FullTimeHrPerDay = 1;
            public int PartTimeHrPerDay = 2;
            public int NumberOfCompany = 0;

            public CompanyWage[] companyWageArray;

        public EmployeeWage()
            {
                this.companyWageArray = new CompanyWage[3];
            }
            public void AddEmpWage(string CompanyName, int EmpRatePerHr, int maxHrPerMonth, int maxWorkingDays) //getting employee data using parameters
            {
                companyWageArray[this.NumberOfCompany] = new(CompanyName, EmpRatePerHr, maxHrPerMonth, maxWorkingDays);
                NumberOfCompany++;
            }
        public void ComputeEmpWage()//getting employeewage for multiple companies
        {
            for (int i = 0; i < NumberOfCompany; i++)
            {
                companyWageArray[i].setTotalEmpWage(this.ComputeEmpWage(companyWageArray[i]));

                Console.WriteLine(this.companyWageArray[i].ToString());
            }
        }

               public int ComputeEmpWage(CompanyWage companyWage) // calculate wage of employee
            {
                //throw new NotImplementedException();
                int empHrs = 0, TotalHrs = 0, TotalWorkDays = 0;
                while (TotalHrs <= companyWage.MaxHrPerMonth && TotalWorkDays < companyWage.MaxWorkingDays)
                {
                    TotalWorkDays++;
                    Random random = new Random();
                    int EmpCheck = random.Next(0, 3);

                    switch (EmpCheck)
                    {
                        case 1:
                            empHrs = 8;
                            break;
                        case 2:
                            empHrs = 4;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    TotalHrs += empHrs;
                }
                Console.WriteLine("Total number of work Days" + TotalWorkDays);
                Console.WriteLine("Tota. work Hrs " + TotalHrs);
                return TotalHrs * companyWage.EmpRatePerHr;
            }     

       

       
    }

  }



