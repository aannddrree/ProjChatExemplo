﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjChatExemplo.Models
{
    public class User
    {
        public string name { get; set; }
        public Int64 key { get; set; }
        public DateTime dtConnection { get; set; }
    }
}
