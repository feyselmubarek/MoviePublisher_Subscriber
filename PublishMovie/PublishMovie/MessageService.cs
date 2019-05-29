using System;

namespace PublishMovie
{
    class MessageService
    {
        public void OnMovieEncoded(object sender, MovieEventArgs args)
        {
            Console.WriteLine("Message Service: Sending Email... " + args.Movie.Titile.ToString());
        }
    }
}
