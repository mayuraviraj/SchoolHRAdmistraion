using HRAdmistrationAPI;

namespace SchoolHRAdmistration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            IList<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            foreach (IEmployee employee in employees)
            {
                totalSalaries += employee.Salary;
            }
            Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");
            Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(x => x.Salary)}");

        }

        public static void SeedData(IList<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Fisher",
                Salary = 40000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "John",
                LastName = "Smith",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Jane",
                LastName = "Doe",
                Salary = 50000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Damien",
                LastName = "Johnson",
                Salary = 60000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "Devlin",
                LastName = "Brown",
                Salary = 70000
            };
            employees.Add(headMaster);

        }
        
    }
    public class Teacher : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.02M);
        }
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.03M);
        }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.04M);
        }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.05M);
        }
    }
}
