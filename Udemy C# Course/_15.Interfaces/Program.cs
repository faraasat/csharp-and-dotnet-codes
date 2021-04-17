using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Interfaces
{
    class Program
    {

        public interface INotifications
        {
            void showNotifications();
            string getDate();
        }

        public class Notification : INotifications
        {

            private string sender;
            private string message;
            public string date;

            public Notification()
            {
                sender = "Admin";
                message = "Yo! what's up?";
                date = " ";
            }

            public Notification(string sender, string message, string date)
            {
                this.sender = sender;
                this.message = message;
                this.date = date;
            }

            public string getDate()
            {
                return date;
            }

            public void showNotifications()
            {
                Console.WriteLine("Message {0} was sent by {1} = at {2}", message, sender, date);
            }
        }

        static void Main(string[] args)
        {

            Notification n1 = new Notification("Denis", "Tsup bro?", "12.06.2018");
            n1.getDate();
            n1.showNotifications();

            Console.ReadKey();
        }
    }
}
