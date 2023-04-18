using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repository;
using TaskManagement.Services;

namespace TaskManagement.Admin.Commands
{
    public class BanUserCommand
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            Console.Write("Enter an email");
            string email = Console.ReadLine()!;
            User user = userRepository.GetUserOrDefaultByEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            if(user==UserService.CurrentUser)
            {
                Console.WriteLine("You cant ban yourself!");
                return;
            }
            if (user.IsAdmin)
            {
                Console.WriteLine($" {user.Name} is admin you can't ban  ");
            }
            user.IsBanned = true;
            userRepository.Remove(user);
            Console.WriteLine("User successfully removed");
        }
    }
}
