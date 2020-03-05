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
      Letter newLetter = new Letter("a");
      newLetter.setPoint();

      string status = newLetter.Status;

      Assert.AreEqual("a point accessed", status);
    }
  }
}