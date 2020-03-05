using System.Collections.Generic;
using System;
namespace ScrabbleScoreModels
{
  public class Letter
  {
    static List<string> pointsAre1 = new List<string> {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
    static List<string> pointsAre2 = new List<string> {"d", "g"};
    static List<string> pointsAre3 = new List<string> {"b", "c", "m", "p"};
    static List<string> pointsAre4 = new List<string> {"f", "h", "v", "w", "y"};
    static List<string> pointsAre5 = new List<string> {"k"};
    static List<string> pointsAre8 = new List<string> {"j", "x"};
    static List<string> pointsAre10 = new List<string> {"q", "z"};
    Dictionary<int,List<string>> letterPointEvals = new Dictionary <int,List<string>>() {{1, pointsAre1}, {2, pointsAre2}, {3, pointsAre3}, {4, pointsAre4}, {5, pointsAre5}, {8, pointsAre8}, {10, pointsAre10}};
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
          Status = CurrentLetter +" point accessed";
        }

      }
    }
  }
}