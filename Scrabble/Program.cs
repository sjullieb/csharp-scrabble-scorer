using System;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to count score in the Scrabble game:");
      string inputWord = Console.ReadLine();

      int outputScore = Scorer.ScoreWord(inputWord);
      Console.WriteLine("The score for '" + inputWord + "' is " + outputScore.ToString());
    }
  }
}
