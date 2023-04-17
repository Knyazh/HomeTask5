using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Database.Models
{
    public class Message
    {

        string Context { get; set; }

        User User { get; set; }
        public Message(string context, User user)
        {
            Context = context;
            User = user;
        }
    }
}
