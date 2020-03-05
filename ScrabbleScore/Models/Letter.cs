using System.Collections.Generic;
using System;
namespace ScrabbleScoreModels
{
  public class Letter
  {
    static List<string> pointsAre1 = new List<string> {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
    Dictionary<int,List<string>> letterPointEvals = new Dictionary <int,List<string>>() {{1, pointsAre1}};
    // Dictionary<string, int> letterPointEvals = new Dictionary <string, int>() {{"A", 1}, {"E",1}, {""}}
    public string CurrentLetter {set;get;}
    public int Points {set;get;}
    public string Status {set;get;}
    public Dictionary<int,List<string>> Options {get;}
    public Letter(string letter)
    {
      CurrentLetter = letter;
      Points = 0;
      Options = letterPointEvals;
      Status = "not retreived";
    }
    public void Access()
    {
      Dictionary<int,List<string>>.ValueCollection valueLists = Options.Values;
      Dictionary<int,List<string>>.KeyCollection keyColl = Options.Keys;

      foreach (List<string> list in valueLists)
      {
      if (list.Contains(CurrentLetter))
      {
        Status = "point accessed";
      }

      }
    }
  }
}