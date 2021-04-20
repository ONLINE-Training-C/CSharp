using System;

namespace LearnSchool
{
    class WorkingProgran
    {
        static void Main(string[] args)
        {
            int NoOfWorkingdays = 5;
            Console.WriteLine("No of working days: "+ NoOfWorkingdays);

            //....... pass by value to value type...............

            /*  updateWorkingDays( NoOfWorkingdays);
             Console.WriteLine("No of working days after update: " + NoOfWorkingdays);

              void updateWorkingDays(int NoOfWorkingDays)
             {
                 NoOfWorkingdays += 1;
             } */

            //............pass by ref to value type............
            updateWorkingDays(NoOfWorkingdays);
            Console.WriteLine("No of working days after update  ref : " + NoOfWorkingdays);

            void updateWorkingDays( int refNoOfWorkingdays)
            {
                NoOfWorkingdays += 1;
            }

           // String[] employees = new String[3];
           // employees= { "sam", "jhon", "Merry"  ,"Shine" };
            //Console.WriteLine(" employee in 2nd place is: " + employees[1]);


            // updateName(ref employees[]);

            //..........pass value to ref type...............

            /*updateName(employees);
            Console.WriteLine(" employee in 2nd place is: " + employees[1]);

            void updateName( string[] employees)
            {

                employees[1] = "james";
            } */

            //...............pass ref type to ref.........

             /* void updateName( String refemployees){

                employees[4] = "sunny";
                

            }  */

               int[] marks= { 10, 20, 30, 40, 50, 50 };
            

            Console.WriteLine("print the array elements");
            for ( int i=marks.Length-1; i > 0 ;i-- )
            {
                if(i==4)
                {
                    continue;
                }
                Console.WriteLine(marks[i]);
            }

            Console.WriteLine("print the array elements using for each ");
     

            foreach (int  i in marks)
            

                Console.WriteLine(i);




        }
        
    }
}
