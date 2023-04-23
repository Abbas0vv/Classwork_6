using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class ShowMessagesCommand
    {
        public static void Handle()
        {
            MessageRepository messageRepository = new MessageRepository();
            List<Message> messages = messageRepository.GetAllByReceiver(UserService.CurrentUser);

            int currentRowNumber = 1;

            foreach (Message message in messages)
            {
                Console.WriteLine($"{currentRowNumber}.{message.Sender.GetFullName()} {message.Sender.Email} | {message.Content}");

                currentRowNumber++;
            }
        }
    }
}
