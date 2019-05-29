using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PublishMovie
{
    class MovieEncoder
    {
        public event EventHandler<MovieEventArgs> MovieEncoded;
        
        public void Encode(Movie movie)
        {
            Console.WriteLine("Encoding Movie....  Please Wait");
            Thread.Sleep(3000);

            OnMovieEncoded(movie);
        }
        
        protected virtual void OnMovieEncoded(Movie m)
        {
            MovieEncoded?.Invoke(this, new MovieEventArgs(){ Movie = m});
        }
    }

    class MovieEventArgs : EventArgs
    {
        public Movie Movie { get; set; }
    }
}
