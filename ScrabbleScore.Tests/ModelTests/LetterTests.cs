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

      Assert.AreEqual("a point accessed", status);
    }
    [TestMethod]
    public void Letter_LetterAccessComparisonListFromListCollections_Status()
    {
      Letter newLetter = new Letter("b");
      newLetter.Access();

      string status = newLetter.Status;

      Assert.AreEqual("b point accessed", status);
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