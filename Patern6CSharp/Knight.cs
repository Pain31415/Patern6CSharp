using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Knight : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("Knight moves in an 'L' shape: two squares in one direction and then one square perpendicular to that direction.");
        }
    }
}
