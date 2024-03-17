using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Rook : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("Rook moves any number of squares along a rank or file.");
        }
    }
}
