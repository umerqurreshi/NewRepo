namespace ConsoleApplication2
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }

        public enum Occupation
        {
            SoftwareDeveloper,
            Engineer,
            Lawyer,
            Doctor,
            Nurse
        }

        public enum Sex
        {
            Female = 1,
            Male = 2
        }
    }
}
