using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Post
    {

        public int id { get; set; }
        public String body { get; set; }
        public String title { get; set; }
        public DateTime published { get; set; }
        public String urlSlug { get; set; }
        public List<Tag> tags { get; set; }
        public List<Comment> comments { get; set; }

    }
}