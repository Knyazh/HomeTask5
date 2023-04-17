using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdminCommand
    {
        public static void Handle()
        {
            Console.Write("Enter an email:");
            string email = Console.ReadLine()!;

            foreach (User  user in DataContext.Users)
            {
               if (user.Email == email)
                {
                    if (user.IsAdmin)
                    {
                        Console.WriteLine($"{user.Name} is already admin");
                        return;
                    }
                    else
                    {
                        user.IsAdmin = true;

                        Console.WriteLine($"{user.Name} is now admin");

                        return;
                    }
                }

            }
            Console.WriteLine("Email not found:");

        }

    }
}
