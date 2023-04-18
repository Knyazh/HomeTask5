using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repository;
using TaskManagement.Services;

namespace TaskManagement.Client.Command
{
    internal class CloseAccountCommand
    {
        public static void Handle()
        {

            UserRepository userRepository = new UserRepository();   
            string password = Console.ReadLine();

            if(UserService.CurrentUser.Password != password)
            {
                Console.WriteLine("Invalid password");
                return;
            }

            userRepository.Remove(UserService.CurrentUser);
        }

    }
}
