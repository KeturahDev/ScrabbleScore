using System.Collections.Generic;
namespace ScrabbleScoreModels
{
  public class Letter
  {
    public string CurrentLetter {set;get;}
    public int Points {set;get;}
    public Letter(string letter)
    {
      CurrentLetter = letter;
      Points = 0;
    }
  }
}