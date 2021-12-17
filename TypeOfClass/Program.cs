using System;

namespace TypeOfClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Example of Abstract Class
            //AbstractClassExtensions ACExtensions = new AbstractClassExtensions();
            //ACExtensions.FirstName = "Rahul Lodhe";
            //ACExtensions.LastName = "Kumar";
            //ACExtensions.GetFullName(ACExtensions.FirstName, ACExtensions.LastName);

            //// Example Of Partial Class - PartialClass1 and PartialClass2, PartialClassExtensions
            //PartialClassExtensions PCExtensions = new PartialClassExtensions();
            //PCExtensions.FirstName = "Partial";
            //PCExtensions.LastName = "Example";
            //PCExtensions.GetFullName();

            //// Example of Sealed Class 
            //SealedClassExtensions SCExtensions = new SealedClassExtensions();
            //SCExtensions.SealedClassExt();

            //// Example of Static Class 
            StaticClass.FirstName = "C#";
            StaticClass.LastName = "Programming";
            StaticClass.GetStaticFunction();
        }
    }
}
