using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void QueenCanAttack_offline_false()
    {
      Queen testQueen = new Queen(1,3);
      Assert.AreEqual(false, testQueen.CanAttack(2,5));
    }
    [TestMethod]
    public void QueenCanAttack_horizontal_True()
    {
      Queen testQueen = new Queen(1,3);
      Assert.AreEqual(true, testQueen.CanAttack(1,5));
    }
    [TestMethod]
    public void QueenCanAttack_vertical_True()
    {
      Queen testQueen = new Queen(1,3);
      Assert.AreEqual(true, testQueen.CanAttack(5,3));
    }
    [TestMethod]
    public void QueenCanAttack_diagonal_True()
    {
      Queen testQueen = new Queen(1,3);
      Assert.AreEqual(true, testQueen.CanAttack(4,0));
    }
  }
}
