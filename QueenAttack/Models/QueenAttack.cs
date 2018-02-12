using System;
using System.Text;

namespace QueenAttack
{
  public class Queen
  {
    private int _xQueen;
    private int _yQueen;

    public Queen(int xQ, int yQ)
    {
      _xQueen = xQ;
      _yQueen = yQ;
    }

    public bool CanAttack(int x, int y)
    {
      if (x == _xQueen || y == _yQueen || (Math.Abs(x - _xQueen)) == (Math.Abs(y - _yQueen)))
      {
        return true;
      }
      return false;
    }
  }
}
