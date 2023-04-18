﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repository
{
    internal class MessageRepository
    {
        public void Insert(Message message)
        {
            DataContext.Messages.Add(message);
        }
    }
}