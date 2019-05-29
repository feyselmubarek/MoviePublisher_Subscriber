using System;

namespace PublishMovie
{
    class MailService
    {
        public void OnMovieEncoded(object sender, MovieEventArgs args)
        {
            Console.WriteLine("Mail Service: Sending Email... " + args.Movie.Titile.ToString());
        }
    }
}
