using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chess_Blazor.Client.Data
{
    public class Piece
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public PieceDirection Direction { get; set; }
        public string Color { get; set; }
        //public int Value { get; set; }
    }

    public enum PieceDirection
    {
        Pion, Tour, Fou, Cavalier, Roi, Reine
    }
}
