using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClass
{
    public sealed class SealedClass
    {
        private string _FirstName { get; set; }
        private string _LastName { get; set; }

        public string FirstName { get { return _FirstName; } set { _FirstName = value; } }
        public string LastName { get { return _LastName; } set { _LastName = value; } }
        public void GetSealedClass()
        {
            Console.WriteLine(_FirstName + " " + _LastName);
        }
    }
    public class SealedClassExtensions
    {
        public SealedClass SealedClassExt()
        {
            SealedClass ObjSealedClass = new SealedClass();

            ObjSealedClass.FirstName = "C#";
            ObjSealedClass.LastName = "Programming";
            ObjSealedClass.GetSealedClass();
            return ObjSealedClass;
        }

    }
}
