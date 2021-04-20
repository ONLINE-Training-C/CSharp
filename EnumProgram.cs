using System;

namespace BasicEnumerations
{
    // Enum Declaration and Initialisation//
    enum Grades
    {
        FirstClass ,
        SecondClass,
        Thirdclass,
        Fail
    }
    class EnumProgram
    {
        // main method
        static void Main(string[] args)
        {
            // Accessing enum elements
            Console.WriteLine(Grades.Fail);

            //instantiating an enum type by declaring enum type and assign one of the enum constant to it
            //Grades status = Grades.Fail;
           // Console.WriteLine("Grades Status: {0} ({0:D})", status);

            string[] formats = { "G", "F", "D", "X" };
            Grades result = Grades.FirstClass;
            foreach (var fmt in formats)
                Console.WriteLine(result.ToString(fmt));

            // Converting enum type to int type
            int grade = (int)Grades.SecondClass;
            Console.WriteLine(grade);

            //int to enum conversion
            var value = (Grades)2;
            Console.WriteLine(value);


        }
    }
}
