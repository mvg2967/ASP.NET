using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Models
{
    public class BlogDBContext : DbContext
    {
        public DbSet<Post> posts { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<Comment> comments { get; set; }
    }
}