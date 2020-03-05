using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreModels;

namespace ScrabbleScore.Tests 
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void LetterAccessed_LetterConfirmsOriginInDictionary_Status()
    {
      Letter newLetter = new Letter('a');
      newLetter.SetPoint();

      string status = newLetter.Status;

      Assert.AreEqual("a point accessed", status);
    }
    [TestMethod]
    public void GetPoint_LetterReturnsPoints_PointValue()
    {
      Letter newLetter = new Letter('q');
      newLetter.SetPoint();

      int points = newLetter.Points;

      Assert.AreEqual(10, points);
    }
  }
}