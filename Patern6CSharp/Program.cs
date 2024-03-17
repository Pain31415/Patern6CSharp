namespace Patern6CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext strategyContext = new StrategyContext(new King());
            strategyContext.ExecuteMove();

            strategyContext.SetChessPiece(new Queen());
            strategyContext.ExecuteMove();

            strategyContext.SetChessPiece(new Bishop());
            strategyContext.ExecuteMove();

            strategyContext.SetChessPiece(new Knight());
            strategyContext.ExecuteMove();

            strategyContext.SetChessPiece(new Pawn());
            strategyContext.ExecuteMove();

            strategyContext.SetChessPiece(new Rook());
            strategyContext.ExecuteMove();
        }
    }
}
