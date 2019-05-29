using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishMovie
{
    // Demonstrating Event Driven Architecture by publisher and subscriber
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new Movie() { Titile = "Game of Thrones" };
            
            // pulisher
            var encoder = new MovieEncoder();

            // 1st subscriber
            var mailService = new MailService();

            // 2nd subscriber
            var messageService = new MessageService(); 

            // subscribing process
            encoder.MovieEncoded += mailService.OnMovieEncoded;
            encoder.MovieEncoded += messageService.OnMovieEncoded;

            //publishing
            // if this is not published the subscribers can find it
            encoder.Encode(movie);
        }
    }
}
