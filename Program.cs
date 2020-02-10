using System;
using System.Collections.Generic;

namespace Lab_Number_11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movies> ListofMovies = new List<Movies>();
            ListofMovies.Add(new Movies("It", "Horror"));
            ListofMovies.Add(new Movies("Friday the 13th", "Horror"));
            ListofMovies.Add(new Movies("Friday", "Comedy"));
            ListofMovies.Add(new Movies("Next Friday", "Comedy"));
            ListofMovies.Add(new Movies("Love Jones", "Love"));
            ListofMovies.Add(new Movies("Notebook", "Love"));
            ListofMovies.Add(new Movies("Malcolm X", "BioPic"));
            ListofMovies.Add(new Movies("Notorious", "BioPic"));
            ListofMovies.Add(new Movies("Like Mike", "Sports"));
            ListofMovies.Add(new Movies("He Got Game", "Sports"));


            string UserContinue = String.Empty;
            do
            {
                Console.WriteLine("What category are you interested in?");
                string input = Console.ReadLine();

                foreach (Movies films in ListofMovies)
                {
                    if (films.Category.Contains(input))
                    {
                        Console.WriteLine(films);
                    }
                }
                Console.WriteLine("Do you want to continue?");
                UserContinue = Console.ReadLine();
            } while (UserContinue == "yes");


        }
    }
}
