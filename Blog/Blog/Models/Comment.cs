using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Models
{
    public class Comment
    {

        public int id { get; set; }
        public String author { get; set; }
        public String body { get; set; }
        public DateTime published { get; set; }
        public Post post { get; set; }
    }
}
