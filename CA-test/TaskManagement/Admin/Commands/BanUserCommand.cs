using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class BanUserCommand
    {
        public static void Handle()
        {
            Console.Write("Enter an email:");
            string email = Console.ReadLine()!;
            foreach (User user in DataContext.Users)
            {
                if (user.Email== email)
                {
                    if(user.IsAdmin)
                    {
                        user.IsAdmin = false;
                        Console.WriteLine("Admin cant be ban");
                        return;
                    }
                    else
                    {
                        user.IsBanned = true;
                        Console.WriteLine($"{user.Name} is banned");
                        return;
                    }

                }

            }
            Console.WriteLine("Email not found");

        }
    }
}
