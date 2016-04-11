using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string manipulation used in real-life scenarios almost daily!

            string sentence = "My name is John Doe";

            // I want to replace the word John with the name David
            sentence = sentence.Replace("John", "David");
            Console.WriteLine(sentence); /*Break point here : See value of sentence variable above*/

            // We can also chain the Replace operators like so

            string sentence2 = "I am a human being and I am not inhuman. Honestly I am not";
            sentence2 = sentence2.Replace("inhuman", "inhuman at all").Replace("Honestly", "Seriously");
            Console.WriteLine(sentence2); /*Break point here : See value of sentence2 variable above*/

            // We have an Employee class Employee.cs with properties. Let's create an instance of
            // the Employee class and access it's properties
            // Notice that the Job title and gender have been placed into Enums which you can see 
            // in Employee.cs.....these enums ensure that the user doesn't make spelling mistakes
            // when typin in gender or job title and so enums give them preset options.
            Employee employee = new Employee();
            employee.Firstname = "Brad";
            employee.Lastname = "Deridan";
            employee.Age = 32;
            employee.Gender = Employee.Sex.Male.ToString();
            employee.JobTitle = Employee.Occupation.Doctor.ToString();

            // A quicker way to do what we have done between lines 28-33
            Employee employee2 = new Employee
            {
                Firstname = "Josh",
                Lastname = "Luigi",
                Gender = Employee.Sex.Female.ToString(),
                Age = 43,
                JobTitle = Employee.Occupation.Nurse.ToString()
            };

            // Now let's print employee2 full name by adding (concatenating) the two string
            // values for Firstname and LastName to the screen..first, the boring long way!
            Console.WriteLine(employee2.Firstname + " " + employee2.Lastname);
            // Try to avoid adding properties and strings like this. In this case, empty string " "
            // Use String.Format instead...first up, the old way of String.Format... 3rd best option
            Console.WriteLine(String.Format("{0} {1}", employee2.Firstname, employee2.Lastname));
            // 2nd best option below:
            Console.WriteLine("{0} {1}", employee2.Firstname, employee2.Lastname);
            // BEST option below:
            Console.WriteLine($"{employee2.Firstname} {employee2.Lastname}");

            // RUN CODE AND NOTICE above 4 lines yield the same result

            Console.ReadLine();
        }
    }
}
