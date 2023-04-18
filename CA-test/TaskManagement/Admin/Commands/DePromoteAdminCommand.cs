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
    internal class DePromoteAdminCommand
    {

        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            Console.Write("Enter an email");
            string email = Console.ReadLine()!;
            User user = userRepository.GetUserOrDefaultByEmail(email);

            if (user == null)
            {
                Console.WriteLine("Email not found");
                return;
            }
            if (!user.IsAdmin)
            {
                Console.WriteLine("User is alreday standar!");
            }

            if (email == UserService.CurrentUser.Email)
            {
                Console.WriteLine("You can't yourself!");
                return;
            }
            user.IsAdmin = false;
            Console.WriteLine("Admin successfully depromoted from admin to user!");

        }
    }
}
