using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDiem.Areas.Admin.Models
{
    public class Message
    {
        public string type { get; set; }
        public string content { get; set; }

        public Message()
        {

        }
        public Message(string type, string content)
        {
            this.type = type;
            this.content = content;
        }
    }
}