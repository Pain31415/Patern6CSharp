using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Queen : ChessPiece
    {
        public override void Move()
        {
            Console.WriteLine("Queen moves any number of squares in any direction.");
        }
    }
}
