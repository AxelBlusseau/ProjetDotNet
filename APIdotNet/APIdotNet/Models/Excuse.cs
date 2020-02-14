using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIdotNet.Models
{
    public class Excuse
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public Byte[] Image { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int NbVote { get; set; }
    }
}
