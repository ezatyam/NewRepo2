using System;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
namespace WebApplication4.Data
{
    public class Conn : DbContext
    {

        public Conn(DbContextOptions<Conn> options) : base(options)
        {
        }
        public DbSet<Register> Register { get; set; }


    }
}