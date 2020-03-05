using System.Collections.Generic;
using System;
namespace ScrabbleScoreModels
{
  public class Letter
  {
    Dictionary<string, int> letterPointEvals = new Dictionary <string, int>() {{"a", 1}, {"e", 1}, {"i", 1}, {"o", 1}, {"u", 1}, {"l", 1}, {"n", 1}, {"r", 1}, {"s", 1}, {"t", 1}, {"d", 2},{"g", 2},{"b", 3},{"c", 3},{"m", 3},{"p", 3},{"f", 4},{"h", 4},{"v", 4},{"w", 4},{"y", 4},{"k", 5},{"j", 8},{"x", 8},{"q", 10},{"z", 10},};
    public string CurrentLetter {set;get;}
    public int Points {set;get;}
    public string Status {set;get;}
    public Dictionary<string, int> Options {get;}
    public Letter(string letter)
    {
      CurrentLetter = letter;
      Points = 0;
      Options = letterPointEvals;
      Status = "not retreived";
    }
    public void setPoint()
    {
      Dictionary<string,int>.KeyCollection keyColl = Options.Keys;
      foreach (string key in keyColl) 
      {
        if (key.Contains(CurrentLetter))
        {
          Status = CurrentLetter +" point accessed";
        }
      }
      // foreach (List<string> list in valueLists)
      // {
      //   if (list.Contains(CurrentLetter))
      //   {
      //     Status = CurrentLetter +" point accessed";
      //     //Points = list.key
      //   }

      // }
    }
  }
}