using System;
using System.Collections.Generic;
using System.Linq;

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
            //StaticClass.FirstName = "C#";
            //StaticClass.LastName = "Programming";
            //StaticClass.GetStaticFunction();

            List<College> college = new List<College>();
            college.Add(new College
            {
                standard = 10,
                stream = "Scieance",
                Student = new List<StudentModel> { new StudentModel { Id = 1, Name = "Rahul" }, new StudentModel { Id = 2, Name = "Rupesh" } }
            });

            List<StudentModel> ObjStudent = new List<StudentModel>();

            foreach (var col in college)
            {
                var student = col.Student;

                foreach (var studentModel in student)
                {
                    if (studentModel.Id == 1)
                    {
                        ObjStudent.Add(studentModel);
                    }
                }
                if (ObjStudent.Count > 0)
                {
                    col.Student = null;
                    col.Student = ObjStudent;
                }
            }
            Console.WriteLine("Rahul Lodhe");
        }
    }


    public class College
    {
        public int standard { get; set; }
        public string stream { get; set; }
        public List<StudentModel> Student { get; set; }
    }


    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
