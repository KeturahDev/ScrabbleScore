using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreModels;

namespace ScrabbleScore.Tests 
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void Letter_LetterAccessesComparisonList_Status()
    {
      Letter newLetter = new Letter("a");
      newLetter.Access();

      string status = newLetter.Status;

      Assert.AreEqual("point accessed", status);
    }
    // [TestMethod]
    // public void LetterPoints_LettersReturnPoints_intPoint()
    // {
    //   Letter newLetter = new Letter("a");
    //   newLetter.setPoint();

    //   int point = newLetter.Points;

    //   Assert.AreEqual(1, point);
    // }
  }
}