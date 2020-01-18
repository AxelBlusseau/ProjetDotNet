using System;

namespace FrontBlazor.Data
{
    public class Excuse
    {

        public int Id { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public int UserID { get; set; }
        public int NbVote { get; set; }
        public bool Voted { get; set; } //Cet attribut sert a préciser si l'excuse vient d'être liké
    }
}
