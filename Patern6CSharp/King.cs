using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class King : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("King moves one square in any direction.");
        }
    }
}
