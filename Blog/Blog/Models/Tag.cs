using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Models
{
    public class Tag
    {

        public int id { get; set; }
        public String tagName { get; set; }
        public String urlSlug { get; set; }
        public List<Post> posts { get; set; }
    }
}
