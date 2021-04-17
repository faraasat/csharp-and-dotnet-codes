using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13.Inheritance
{
    class VideoPost : Post
    {

        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Tiltle = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;

        }

        public void Play()
        {
            if(!isPlaying)
            {
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
                isPlaying = true;
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s ", currDuration);
                GC.Collect();  // To collect garbage
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
                isPlaying = false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} by {4}", this.ID, this.Tiltle, this.VideoURL, this.Length, this.SendByUsername);
        }

    }
}
