using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreModels;
using System.Collections.Generic;


namespace ScrabbleScore.Tests 
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordIntoLetters_BreakWordIntoCollectionOfLetters_LetterTypes()
    {
      string input = "jam";
      Word newWord = new Word(input);
      newWord.GetLetters();

      List<char> letters = newWord.Letters;

      //checking to see if middle is as expected
      Assert.AreEqual('a', letters[1]);
    }
    [TestMethod]
    public void TallyPoints_RetreivePointsPerLetter_Int()
    {
      string input = "moo";
      Word newWord = new Word(input);
      newWord.GetLetters();

      int totalPoints = newWord.Score;

      Assert.AreEqual(5, totalPoints);
    }
  }
}