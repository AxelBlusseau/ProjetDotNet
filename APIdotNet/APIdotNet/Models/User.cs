using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIdotNet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

    }
}
