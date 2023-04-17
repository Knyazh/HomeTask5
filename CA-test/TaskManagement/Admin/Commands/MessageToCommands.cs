using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class MessageToCommands
    {
        public static void Handle()
        {
            Console.Write("Enter an email:");
            string email = Console.ReadLine();

            foreach(User user in DataContext.Users)
            {
                //if(user.Email == email)
                //{

                //   user.GetShortMessageInfo(user);
                //    return;

                //}

            }
            Console.WriteLine("Email not found");

        }
    }
}
