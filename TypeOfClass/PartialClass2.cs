using System;

namespace TypeOfClass
{
    public partial class PartialClass
    {
        private string _FirstName { get; set; }
        private string _LastName { get; set; }

        public void GetFullName()
        {
            Console.WriteLine("Full Name" + FirstName + "" + LastName);
        }
    }
    
    public class PartialClassExtensions : PartialClass
    {

    }
}
