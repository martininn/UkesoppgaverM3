﻿namespace PensumSjekkUke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies =
            {
                " is now a footballer!", " has started collecting stamps for some reason.", " is watering the plants.",
                " started binging soap operas.", " has become fixated on collecting lightbulbs."
            };

            for (var i = 0; i < 99; i++)
            {
                Console.WriteLine("Who would like a new hobby?");
                string tekst = Console.ReadLine();
                Console.WriteLine(tekst + hobbies[RandomLowNumber()]);
            }
        }

        private static int RandomLowNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            return num;
        }
    }
}