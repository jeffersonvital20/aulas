using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {
            Database.Connection.ConnectionString = @"data source=DESKTOP-ET9UPCQ\SQLEXPRESS;
                                                    initial catalog=BlogBDLivro; Integrated Security=SSPI";
        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
    }
}