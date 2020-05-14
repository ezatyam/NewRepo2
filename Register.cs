using Microsoft.EntityFrameworkCore;
using System;
namespace WebApplication4.Models
{
    public class Register
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int SecurityQuestion { get; set; }
        public string Answer { get; set; }
    }
}