using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops reiterates through the entire length
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach (string month in months)
            {
                Console.WriteLine(month);
                if (month == "Dec")
                {
                    Console.WriteLine("That's the best month");
                }
                else
                {
                    Console.WriteLine("That month is ok I guess...");
                }

                }
                string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
                foreach (string band in musicians)
                {
                    Console.WriteLine(band);
                }

            //Creat a program that asks the user for their fav food and stores those values in an array
            //Loop through the array and all of the foods
            string[] favFood = { "Seafood", "Soul Food", "Salad" };
            foreach (string food in favFood)
            {
                Console.WriteLine(food);
            }
            if (food == "Seafood")
            {
                Console.WriteLine("My Favorite of all time!");
            }
            else
            {
                Console.WriteLine("I'll settle...");
            }


            //Create an array of lucky numbers using  a foreach loop, print the following:
            //Your Lucky number is: 4
            //Your Lucky number is: 19
            //Your Lucky number is: 7






        }
    }
}
