using System;

namespace ArithmaticIncrement
{
    /* IncrementValue class to perform increments
   * Author name: Varsha B T
   * date: 03 feb 2021 */
    class IncrementValue
    {
        /* .....main method creation......*/
        static void Main(string[] args)
        {
            /* variable intialization*/

            int value = 10;

            /*displaying variable value*/

            Console.WriteLine("value before increment: "+value);

            ++value;
            Console.WriteLine("value after pre-increment"+value);
            value++;
            Console.WriteLine("value after post-increment" + value);
        }
    }
}
