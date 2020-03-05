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
      newWord.getLetters();

      List<char> letters = newWord.Letters;

      //checking to see if middle is as expected
      Assert.AreEqual('a', letters[1]);
    }
  }
}