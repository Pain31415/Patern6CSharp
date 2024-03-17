using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class StrategyContext
    {
        private ChessPiece chessPiece;

        public StrategyContext(ChessPiece chessPiece)
        {
            this.chessPiece = chessPiece;
        }

        public void SetChessPiece(ChessPiece chessPiece)
        {
            this.chessPiece = chessPiece;
        }

        public void ExecuteMove()
        {
            chessPiece.Move();
        }
    }
}
