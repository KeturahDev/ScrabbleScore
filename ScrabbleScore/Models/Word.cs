using System;
using System.Collections.Generic;
namespace ScrabbleScoreModels
{
  public class Word
  {
    List<char> characters = new List<char> {};
    public string Input {get;set;}
    public List<char> Letters {get;set;}
    public int Score {get;set;}
    public Word(string input)
    {
      Input = input;
      Letters = characters;
      Score = 0;
    }

    public void GetLetters()
    {
      char[] chars = Input.ToCharArray();
      foreach (char character in chars)
      {
        Letters.Add(Char.ToLower(character));
      }
      foreach (char letter in Letters)
      {
        Letter newLetter = new Letter(letter);
        newLetter.SetPoint();
        Score = Score += newLetter.Points;
      }
    }
  }
}