using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Command
{
    internal class UpdateSettingsCommand
    {
        public static void Handle()
        {
            Console.Write("Enter an email:");
            string email = Console.ReadLine()!;


            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    user.Name = Console.ReadLine()!;
                    user.LastName = Console.ReadLine()!;
                    user.Password = Console.ReadLine()!;
                    Console.WriteLine(user.GetShortInfo());
                    return;

                }
            }
            Console.WriteLine("Email not found");
        }

    }
}
