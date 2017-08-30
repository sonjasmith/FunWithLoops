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
            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //foreach (string month in months)
            //{
            //    Console.WriteLine(month);
            //    if (month == "Dec")
            //    {
            //        Console.WriteLine("That's the best month");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That month is ok I guess...");
            //    }

            //}
            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            //foreach (string band in musicians)
            //{
            //    Console.WriteLine(band);
            //}

            //Creat a program that asks the user for their fav food and stores those values in an array
            //Loop through the array and all of the foods
            //string[] favFoods = new string[3];
            //Console.WriteLine("What is your favorite food");



            //Create an array of lucky numbers using  a foreach loop, print the following:
            //int[] luckyNumbers = { 2, 4, 25 };
            //foreach(int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is:" + number);
            //}

            //example that strings are character arrays
            //string words = "I like cake";
            //foreach(char letter in words)
            //{
            //    Console.WriteLine(letter);
            //}

            //string[] Names = {"Jordan", "Max", "Peter"};
            //foreach (string name in Names)
            //    for(int i = 0; i < Names.Length; i++)
            //{
            //    Names[i] = Names[i].ToLower();
            //    Console.WriteLine(Names[i]);
            //}

            //For loop has 3 parts: initializer (temporary variable), condition, updater
            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greetings = "My name is Sonja";
            //string[] word = greetings.Split();

            //for (int i = 0; i< word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //    if(word[i] == "Sonja")
            //    {
            //        word[i] = "Max";
            //    }
            //    Console.WriteLine(word[word.Length -1]);
            //}

            //Create an array called days and add days with the elements monday tuesday etc...
            //use a for loop to print the elements to the console.
            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };
            //for (int i = 0; i < days.Length; i++)
            //    for (int i = 0; i <= days.Length - 1)
            //    {
            //        Console.WriteLine(days[i]);
            //    }

            //Create an int array size 25 put the numbers 0 to 25 in the array and print those number
            //to the console.
            //int[] moreNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
            //for (int i = 0; i < moreNumbers.Length; i++)
            //{
            //    Console.WriteLine(moreNumbers[i]);
            //}

            //int[]numbers = new int [26];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    moreNumbers[int] = int;
            //}

            //Console.WriteLine(i);
            //int[] numbersTo25 = new int[25];
            //for(int i =0; i < numbersTo25; i++)
            //{

            //}

            //Start with the string "Once upon a time" and create an array called storyWords using
            //the Split method. Reverse the order of the elements in the array and using a For Loop, print each word.
            //string storyWords = "Once upon a time";
            //string[] words = storyWords.Split();//splitting it on the white space
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //Array.Reverse(words);
            //Console.WriteLine(story[0]);
            //Console.WriteLine(story[1]);
            //Console.WriteLine(story[2]);

            //WHILE LOOP (ATM transactions loop you back to the top)
            //Console.WriteLine("Do you want to play a game");
            //string playAgain = Console.ReadLine();

            //while(playAgain == "Yes")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play again");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("What is your fav ROYGBIV color");
            //string userColor = Console.ReadLine();
            ////bool isRoygbivColor = false;
            //while (userColor != "red" && userColor != "yellow")
            //{
            //    Console.WriteLine("Sorry That is not the correct color please try again ");
            //    userColor = Console.ReadLine();
            //}
            //Console.WriteLine("This is outside the while loop");
            //while (true)
            //{
            //    Console.WriteLine(10); //continuous loop DO NOT USE
            //}

            //DO WHILE LOOP - automatically happens at least one time
            //Ex. free trials like netflix
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman");
            //    Console.WriteLine("That was fun");
            //    Console.WriteLine("Do you want to build another snowman");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "yes");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 5)
                    {
                    break;
                    }
            }
           


        }
    }
}
