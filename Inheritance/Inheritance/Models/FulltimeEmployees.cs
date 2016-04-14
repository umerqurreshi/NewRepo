using System.Collections.Generic;

namespace Inheritance.Models
{
    public sealed class FulltimeEmployees : Employees
    {
        public string AnnualSalary { get; set; }

        public static List<FulltimeEmployees> GetAllEmployees()
        {
            var fte = FulltimeEmployeesRegister();

            return fte;
        }

        private static List<FulltimeEmployees> FulltimeEmployeesRegister()
        {
            List<FulltimeEmployees> fte = new List<FulltimeEmployees>
            {
                new FulltimeEmployees
                {
                    Firstname = "Lucas",
                    Lastname = "Jirto",
                    Occupation = "Lawyer",
                    AnnualSalary = "23000",
                    Age = 32
                },
                new FulltimeEmployees
                {
                    Firstname = "James",
                    Lastname = "Joy",
                    Occupation = "Admin",
                    AnnualSalary = "12500",
                    Age = 27
                },
                new FulltimeEmployees
                {
                    Firstname = "Leyton",
                    Lastname = "Kims",
                    Occupation = "Doctor",
                    AnnualSalary = "43000",
                    Age = 35
                },

                new FulltimeEmployees
                {
                    Firstname = "Leyton",
                    Lastname = "Joicud",
                    Occupation = "Analyst",
                    AnnualSalary = "87000",
                    Age = 31
                }
            };
            return fte;
        }
    }
}
