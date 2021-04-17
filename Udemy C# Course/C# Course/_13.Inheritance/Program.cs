using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post("Thanks for best wishes", true, "Denis");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis", "https://google.com", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost = new VideoPost("Fail Video", "Denis", "https://google.com", true, 10);
            Console.WriteLine(videoPost.ToString());

            videoPost.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost.Stop();

            Console.ReadKey();

        }
    }
}
