using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Client.Command;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction(User user)
        {
            Console.WriteLine($"Hello! : {user.Email} {user.Password}");


            Console.WriteLine("Aviable commands:");
            Console.WriteLine("/update-user");
            Console.WriteLine("/close-account");
            Console.WriteLine("/message-show");
            Console.WriteLine("/logout");

            while (true)
            {
                Console.Write("Enter command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/update-user":
                        UpdateSettingCommand.Handle();
                        break;
                    case "/message-show":
                         ShowMessageCommand.Handle();
                        break;
                    case "/close-account":
                       CloseAccountCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }

        }
    }
}
