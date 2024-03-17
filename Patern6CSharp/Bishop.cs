using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Bishop : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("Bishop moves any number of squares diagonally.");
        }
    }
}
