using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repository
{
    public class UserRepository
    {
        public User GetUserOrDefaultByEmail(string email)
        {
            foreach (User user in DataContext.Users)
            {
                if (user.Email == email) return user;

            }
            return null!;
        }
        
    }
}
