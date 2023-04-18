using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repository;
using TaskManagement.Services;

namespace TaskManagement.Client.Command
{
    public class ShowMessageCommand
    {
        public static void Handle()
        {
            MessageRepository messageRepository = new MessageRepository();
            List<Message> messages = messageRepository.GetAllByReceiver(UserService.CurrentUser);

            int currentRowNumber = 1;
            foreach (Message message in messages)
            {
                Console.WriteLine($" {currentRowNumber}{message.Sender.Name} -{message.Sender.Email} | {message.Content}");
            currentRowNumber++;
            }



        }
    }
}
