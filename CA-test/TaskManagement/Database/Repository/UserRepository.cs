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
        public User CurrentUser { get; internal set; }

        public User GetUserOrDefaultByEmail(string email)
        {
            foreach (User user in DataContext.Users)
            {
                if (user.Email == email) return user;

            }
            return null!;
        }

        public User GetUserOrDefaultByID(int id)
        {
            foreach (User user in DataContext.Users)
            {
                if (user.Id == id) return user;

            }
            return null!;
        }
        public void RemaoveByemail(string email)
        {
            User user = GetUserOrDefaultByEmail(email);
            DataContext.Users.Remove(user);
        }
        public void RemaoveById(int id)
        {
            User user = GetUserOrDefaultByID(id);
            DataContext.Users.Remove(user);
        }
         
        public void Remove(User user)
        {
            DataContext.Users.Remove(user);
        }

    }
}
