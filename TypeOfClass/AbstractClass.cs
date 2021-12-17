using System;

namespace TypeOfClass
{
    public abstract class AbstractClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        public abstract void GetFullName(string FirstName, string LastName);

        public void GetDetails()
        {
            Console.WriteLine("OK Google");
        }
    }

    public class AbstractClassExtensions : AbstractClass
    {
        public override void GetFullName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
