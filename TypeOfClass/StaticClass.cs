using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClass
{
    public static class StaticClass
    {
        private static string _FirstName { get; set; }
        private static string _LastName { get; set; }
        public static string FirstName { get { return _FirstName; } set { _FirstName = value; } }
        public static string LastName { get { return _LastName; } set { _LastName = value; } }

        public static void GetStaticFunction()
        {
            Console.WriteLine(_FirstName + "" + _LastName);
        }
    }
}
