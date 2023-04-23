using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskManagement.Database.Models
{
    public class Message
    {
        public static int IdCounter { get; private set; }

        public int Id { get; set; }
        public string Content { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }

        public Message(string content, User sender, User receiver)
        {
            Id = ++IdCounter;
            Content = content;
            Sender = sender;
            Receiver = receiver;
        }
    }
}
