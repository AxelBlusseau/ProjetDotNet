using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIdotNet.Models
{
    public class UserId
    {
        public int Id { get; set; }

        public UserId(int id)
        {
            this.Id = id;
        }
    }
}