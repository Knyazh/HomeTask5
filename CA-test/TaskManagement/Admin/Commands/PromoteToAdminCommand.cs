using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repository;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdminCommand
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            Console.Write("Enter an email:");
            string email = Console.ReadLine()!;
            User user = userRepository.GetUserOrDefaultByEmail(email);

            if(user == null)
            {
            Console.WriteLine("Email not found:");
                return;
            }

            if(user.IsAdmin)
            {
                Console.WriteLine("User is already admin");
                return;
            }

           user.IsAdmin = true;
            Console.WriteLine("User successfully promoted to admin!");
        }

    }
}
