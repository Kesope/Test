using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BootstrapKnockout.DomainModel;

namespace DatabaseService
{
    public class Sova : DbContext
    {

        public DbSet<Comments> Comments { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Comments
            modelBuilder.Entity<Comments>().ToTable("comments");
            modelBuilder.Entity<Comments>().Property(t => t.id).HasColumnName("commentid");
            modelBuilder.Entity<Comments>().Property(t => t.postid).HasColumnName("postid");
            modelBuilder.Entity<Comments>().Property(t => t.score).HasColumnName("commentscore");
            modelBuilder.Entity<Comments>().Property(t => t.text).HasColumnName("commenttext");
            modelBuilder.Entity<Comments>().Property(t => t.createdate).HasColumnName("commentcreatedate");
            modelBuilder.Entity<Comments>().Property(t => t.userid).HasColumnName("userid");

            //Post
            modelBuilder.Entity<Post>().ToTable("post");
            modelBuilder.Entity<Post>().Property(p => p.id).HasColumnName("postid");
            modelBuilder.Entity<Post>().Property(p => p.typeid).HasColumnName("posttypeid");
            modelBuilder.Entity<Post>().Property(p => p.parentid).HasColumnName("parentid");
            modelBuilder.Entity<Post>().Property(p => p.acceptedanswerid).HasColumnName("acceptedanswerid");
            modelBuilder.Entity<Post>().Property(p => p.creationdate).HasColumnName("creationdate");
            modelBuilder.Entity<Post>().Property(p => p.score).HasColumnName("score");
            modelBuilder.Entity<Post>().Property(p => p.body).HasColumnName("body");
            modelBuilder.Entity<Post>().Property(p => p.closeddate).HasColumnName("closeddate");
            modelBuilder.Entity<Post>().Property(p => p.title).HasColumnName("title");
            modelBuilder.Entity<Post>().Property(p => p.userid).HasColumnName("userid");

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=sova;uid=root;pwd=kevin");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
