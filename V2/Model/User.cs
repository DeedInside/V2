using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Model
{
    public class User
    {
        public User(int id, string? name, string? email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
