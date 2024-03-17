using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Pawn : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("Pawn moves forward one square, but captures diagonally.");
        }
    }
}
