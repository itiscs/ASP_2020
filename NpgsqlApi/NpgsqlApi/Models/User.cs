using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NpgsqlApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class UsersDB : DbContext
    {

        public DbSet<User> Users { get; set; }

        public UsersDB(DbContextOptions<UsersDB> options)
           : base(options)
        {
            // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = 127.0.0.1; UserId = postgres; Password = 1; Port = 5432; Database = UsersDB2020;");
        }
    }
}
