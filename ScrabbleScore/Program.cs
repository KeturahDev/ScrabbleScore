using System;
using ScrabbleScoreModels;
namespace ScrabbleScore
{
  public class Program
  {
    static void Main()
    {
      Welcome();
      GetWord();
    }
    public static void Welcome()
    {
      Console.ForegroundColor = ConsoleColor.Magenta;

      Console.WriteLine(@"  ___              _    _    _       ___                 
 / __| __ _ _ __ _| |__| |__| |___  / __| __ ___ _ _ ___ 
 \__ \/ _| '_/ _` | '_ \ '_ \ / -_) \__ \/ _/ _ \ '_/ -_)
 |___/\__|_| \__,_|_.__/_.__/_\___| |___/\__\___/_| \___|
              ___ _           _                          
             / __| |_  ___ __| |_____ _ _                
            | (__| ' \/ -_) _| / / -_) '_|               
             \___|_||_\___\__|_\_\___|_|                 
                                                         "); Console.ResetColor();

    }
    public static void GetWord()
    {
      Console.WriteLine("============================================================");
      Console.Write("Please enter the word you would like checked");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("      'E' to exit");
      Console.ResetColor();
      string word = Console.ReadLine().ToLower();
      if (word == "e")
      {
        Console.WriteLine("Goodbye!");
      }
      else
      {
      CheckScore(word);
      }
    }
    public static void CheckScore(string word)
    {
      Word newWord = new Word(word);
      newWord.GetLetters();
      int wordScore = newWord.Score;
      Console.Write("That words score is: ");
      Console.WriteLine($"{wordScore}");
      GetWord();
    }
  }
}