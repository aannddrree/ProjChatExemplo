using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjChatExemplo.Models
{
    public class ChatMessage
    {
        public Int64 Destination { get; set; }
        public User Sender { get; set; }
        public string Message { get; set; }
    }
}
