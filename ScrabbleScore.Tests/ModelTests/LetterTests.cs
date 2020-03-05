using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreModels;

namespace ScrabbleScore.Tests 
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void LetterPoints_LettersReturnPoints_intPoint()
    {
      Letter newLetter = new Letter("A");

      int point = newLetter.Points;

      Assert.AreEqual(1, point);
    }
  }
}