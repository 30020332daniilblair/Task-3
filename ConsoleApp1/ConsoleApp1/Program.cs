using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Finder 101");
            Console.WriteLine("Please enter your mark. A whole number out of 100");
            float mark = float.Parse("Console.Readline");
            string message = "";

            if (mark >= 89 && mark <= 100)
                message = ("Very good thats a A+");
            else if (mark >= 79 && mark <= 90)
                message = ("Nice. Your mark equals to an A");
            else if (mark >= 69 && mark <= 80)
                message = ("Good job. You have achieved a B+");
            else if (mark >= 59 && mark <= 70)
                message = ("Keep it up. You have scored a B");
            else if (mark >= 49 && mark <= 60)
                message = ("You have scored a C");
            else if (mark >= 39 && mark <= 50)
                message = ("You score has earnt you a D. More study next time");
            else if (mark >= 0 && mark <= 40)
                message = ("F.Not good. Better luck next time");
            else
                message = ("You have enetered an incorrect key");
            Console.WriteLine(message);
            Console.ReadLine();

        








        }
    }
}
