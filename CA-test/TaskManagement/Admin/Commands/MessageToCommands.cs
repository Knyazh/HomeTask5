using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repository;
using TaskManagement.Services;

namespace TaskManagement.Admin.Commands
{
    public class MessageToCommands
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            MessageRepository messageRepository = new MessageRepository();
            Console.Write("Enter an email");
            string email = Console.ReadLine()!;
            User receiver = userRepository.GetUserOrDefaultByEmail(email);

            Console.Write("Enter  content");

            string content = Console.ReadLine()!;
            //MessageToCommands.IsvalidContend();


            if (receiver == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Message message = new Message(content, UserService.CurrentUser,receiver);
            messageRepository.Insert(message);
        }

        //public static void IsvalidContend()
        //{
        //    string content = Console.ReadLine()!;

        //    if (content == null) return;

        //    if (content.Length > 5 && content.Length < 100)
        //    {
        //        Console.WriteLine(content);
        //    }

        //}
    }
}
