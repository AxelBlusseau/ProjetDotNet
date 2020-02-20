using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIdotNet.Models
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Error { get; set; }
        public UserResponse(int id, string error)
        {
            this.Id = id;
            this.Error = error;
        }
    }
}