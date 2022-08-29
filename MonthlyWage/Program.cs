namespace MonthlyWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("we clculate different company monthly w");
            Console.WriteLine("\n");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.AddEmpWage("Reliance", 20, 150, 10);
            employeeWage.AddEmpWage("Toyata", 12, 150, 20);
            employeeWage.ComputeEmpWage();
            employeeWage.ToString();
        }
    }
}