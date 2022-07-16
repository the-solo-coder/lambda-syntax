using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class Movie
    {
        private string category;

        public string Name { get; set; }

        public string Description { get; set; }

        public int ThumbsUp { get; set; }

        public int ThumbsDown { get; set; }

        // 1 - read-only property c# 6
        //public double Score
        //{
        //    get
        //    {
        //        return (double)ThumbsUp / (ThumbsUp + ThumbsDown) * 100;
        //    }
        //}
        public double Score => (double)ThumbsUp / (ThumbsUp + ThumbsDown) * 100;

        // 2 - simple methods with no return type
        //public void Play()
        //{
        //    Console.WriteLine("The movie is playing....");
        //}

        public void Play() => Console.WriteLine("The movie is playing now....");

        // 4 - simple methods with return type c# 6
        //public bool IsInTheaters()
        //{
        //    return false;
        //}
        public bool IsInTheaters() => false;

        // 5 - properties with getters and setters
        //public string Category 
        //{ 
        //    get
        //    {
        //        return category;
        //    }
        //    set
        //    {
        //        category = value;
        //    }
        //}

        public string Category
        {
            get => category;
            set => category = value;
        }

        public MovieStatus Status { 
            get
            {
                switch (Score)
                {
                    case < 70 when Score >= 0:
                        return MovieStatus.Bad;
                    case >= 70 when Score < 90:
                        return MovieStatus.Good;
                    case >= 90 when Score <= 100:
                        return MovieStatus.Great;
                    default:
                        return MovieStatus.Invalid;
                }
            }
        }

        public override string ToString()
        {
            // 6 - switch statements c# 8
            string statusDescription;

            //switch (Status)
            //{
            //    case MovieStatus.Great:
            //        statusDescription = "You Must Watch";
            //        break;
            //    case MovieStatus.Good:
            //        statusDescription = "You Should Watch";
            //        break;
            //    case MovieStatus.Bad:
            //        statusDescription = "Don't Watch";
            //        break;
            //    case MovieStatus.Invalid:
            //        statusDescription = "Invalid Status!";
            //        break;
            //    default:
            //        statusDescription = "Unidentified Status!";
            //        break;
            //};

            statusDescription = Status switch
            {
                MovieStatus.Great => "You Must Watch",
                MovieStatus.Good => "You Should Watch",
                MovieStatus.Bad => "Don't Watch",
                MovieStatus.Invalid => "Invalid Status!",
                _ => "Unidentified Status!",
            };

            return $"{Name} - Movie Score: {Score:N2}% - {statusDescription}";
        }

        public Movie(string name,
            string description,
            int thumbsUp,
            int thumbsDown)
        {
            Name = name;
            Description = description;
            ThumbsUp = thumbsUp;
            ThumbsDown = thumbsDown;
        }

        // 3 - constructors with one line of code
        //public Movie()
        //{
        //    Console.WriteLine("Created a Movie with the default Constructor");
        //}

        public Movie() => Console.WriteLine("Created a Movie with the default Constructor");

    }
}
