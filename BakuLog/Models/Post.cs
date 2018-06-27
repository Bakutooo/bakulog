using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DateTime = System.DateTime;

namespace BakuLog.Models
{
    public class Post
    {
        public int PostID { get; set; }

        public string Content { get; set; }
        public DateTime PublishedDateTime { get; set; }

        public Post()
        {
            PublishedDateTime = DateTime.Now;
        }
    }
}