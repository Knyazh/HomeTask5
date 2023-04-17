using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Command
{
    public class ShowMessageCommand
    {
        public static void Handle()
        {
            
            foreach(var user in DataContext.Users)
            {

                foreach (var item in user.Messages)
                {
                    Console.WriteLine(item);
                }
            }



        }
    }
}
