using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repositories
{
    public class MessageRepository
    {
        public List<Message> GetAllByReceiver(User receiver)
        {
            List<Message> messages = new List<Message>();

            foreach (Message message in DataContext.Messages)
            {
                if (message.Receiver == receiver)
                {
                    messages.Add(message);
                }
            }

            return messages;
        }

        public void Insert(Message message)
        {
            DataContext.Messages.Add(message);
        }
    }
}
