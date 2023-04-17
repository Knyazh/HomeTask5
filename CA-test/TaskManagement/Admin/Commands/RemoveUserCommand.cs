using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class RemoveUserCommand
    {
        public static void Handle()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter an email:");
                    string email = Console.ReadLine()!;

                    foreach (User user in DataContext.Users)
                    {
                        if (user.Email == email)
                        {

                            if(user.IsAdmin)
                            {
                                Console.WriteLine($"{user.Name} is already admin");
                            }
                            else
                            {
                            Console.WriteLine($"{user.Name} removed the ststem");
                            DataContext.Users.Remove(user);
                            return;

                            }

                        }
                    }

                    Console.WriteLine("Email not found");
                }
                catch
                {
                    Console.WriteLine("Invalid input pls try again");
                }
            }
        }
    }
}
