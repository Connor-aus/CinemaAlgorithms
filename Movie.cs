using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class Movie : Object
    {
        public string MovieTitle { get; set; }

        // constructor
        public Movie(string title)
        {
            MovieTitle = title;
        }

        // used to output the movie title
        public override string ToString()
        {
            return (MovieTitle + "\n");
        }
    }
}
