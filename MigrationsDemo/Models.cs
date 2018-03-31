using System.Collections.Generic;
using System.Data.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace MigrationsDemo
{
    public  class Blog
    {
        public string Url { get; set; }
        public int BlogID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
    public class BlogContext : DbContext
    {
        public BlogContext()
       :base("ConnectionString")
        {
         }


        public DbSet<Blog> Blogs { get; set; }

        
    }
    public class Post
    {
        public int PostId { get; internal set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
