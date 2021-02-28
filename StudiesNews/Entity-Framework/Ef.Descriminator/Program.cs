using Ef.Descriminator.Context;
using Ef.Descriminator.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ef.Descriminator
{
    public class Program
    {

        static void Main(string[] args)
        {

            using (var db = new MyContext())
            {
                var blog = new Blog()
                {
                    BlogId = 2,
                    Url = "www.blog.com.br"
                };

                var rssBlog = new RssBlog()
                {
                    BlogId = 4,
                    Url = "xyz",
                    RssUrl = "www.rssblog.com.br"
                    
                };

                //db.Blogs.Add(blog);
                db.RssBlogs.Add(rssBlog);
                db.SaveChanges();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
