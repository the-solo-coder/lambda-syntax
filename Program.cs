using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie01 = new Movie("Jurassic Park",
                "Dinosaurs going crazy", 
                150, 
                53);
            Console.WriteLine(movie01);

            Movie movie02 = new Movie("Back To The Future",
                "Comedy Sci-Fi Adventure",
                2045,
                146);
            Console.WriteLine(movie02);

            Movie movie03 = new Movie("Star Wars",
                "Epic Science Fantasy Space Opera",
                4523,
                251);
            Console.WriteLine(movie03);

            var movieList = new List<Movie>();

            movieList.Add(movie01);
            movieList.Add(movie02);
            movieList.Add(movie03);

            //7 - lambda expressions with LINQ
            //var filteredList = movieList.Where(IsGreaterThan80);
            var filteredList = movieList.Where(m => m.Score > 80);

            Console.WriteLine($"# of Movies that scored above 80%: {filteredList.Count()}");
        }

        //public static bool IsGreaterThan80(Movie m)
        //{
        //    return m.Score > 80;
        //}
    }
}
