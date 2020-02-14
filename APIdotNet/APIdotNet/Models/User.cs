using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIdotNet.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Grade { get; set; }
    }
}
