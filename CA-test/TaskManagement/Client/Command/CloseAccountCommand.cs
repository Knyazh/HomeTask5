using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Command
{
    internal class CloseAccountCommand
    {
        public static void Handle()
        {
            Console.Write("Enter email:");
            string email =Console.ReadLine();
            Console.Write("Enter password:");
            string password =Console.ReadLine();

            foreach (User user in DataContext.Users)
            {

                if (user.Email == email && user.Password== password)
                {
                    Console.WriteLine("Your acoount deleted");
                    DataContext.Users.Remove(user);
                    return;
                }

            }
            Console.WriteLine("Email or password are incorrect");
        }

    }
}
