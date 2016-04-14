namespace Inheritance.Models
{
    // Our abstract base class. We cannot create an instance of an abstract base class
    // This class ABSTRACTS the Employee info such that this base class takes care of all properties
    // Common to ALL classes that will inherit from these classes. Those classes will then have only
    // those properties which are unique to that class.
    public abstract class Employees
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
    }
}
