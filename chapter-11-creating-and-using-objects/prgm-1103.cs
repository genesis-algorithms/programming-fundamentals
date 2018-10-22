/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a program, which prints, on the console which day
|     of the week is today.
|
| Solutions and Guidelines:
|
|     Use DateTime.Today.DayOfWeek.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is {0}.", DateTime.Today.DayOfWeek);
        }
    }
}