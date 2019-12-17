using System;
using System.Data.Entity;

namespace CreatePost
{
    class Program
    {
        public class Post
        {
            public int Id { get; set; }
            public DateTime DatePublished { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }

        public class Post2
        {
            public int Id { get; set; }
            public DateTime DatePublished { get; set; }
            public string Title { get; set; }

        }

        public class BlogContext : DbContext
        {
            public DbSet<Post> Posts { get; set; }
        }

        static void Main(string[] args)
        {

        }
    }
}