using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Inheritance
{
    class Post
    {

        private static int currentPostId;

        protected int ID { get; set; }
        protected string Tiltle { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Tiltle = "My First Post";
            IsPublic = true;
            SendByUsername = "Denis";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Tiltle = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Tiltle = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} by {2}", this.ID, this.Tiltle, this.SendByUsername);
        }

    }
}
