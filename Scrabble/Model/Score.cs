using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Scorer
  {
    private static string points1 = "AEIOULNRST";
    private static string points2 = "DG";
    private static string points3 = "BCMP";
    private static string points4 = "FHVWY";
    private static string points5 = "K";
    private static string points8 = "JX";
    private static string points10 = "QZ";

    private static Dictionary<char, int> singleLetterScore = new Dictionary<char, int>{};

    private static void PopulateScoreDictionary(string lettersPoints, int points)
    {
      char[] letters = lettersPoints.ToCharArray();
      foreach (char letter in letters) {
        singleLetterScore.Add(letter, points);
      }
    }

    private static void ValidateScores()
    {
      if (singleLetterScore.Count == 0)
      {
        PopulateScoreDictionary(points1, 1);
        PopulateScoreDictionary(points2, 2);
        PopulateScoreDictionary(points3, 3);
        PopulateScoreDictionary(points4, 4);
        PopulateScoreDictionary(points5, 5);
        PopulateScoreDictionary(points8, 8);
        PopulateScoreDictionary(points10, 10);

        // foreach (KeyValuePair<char, int> entry in singleLetterScore) {
        //   Console.WriteLine(entry.Key + " " + entry.Value.ToString());
        // }
      }
    }

    public static int ScoreWord(string word)
    {
      ValidateScores();
      int total = 0;
      int points;
      char[] arr = (word.ToUpper()).ToCharArray();
      foreach(char letter in arr)
      {
        if (singleLetterScore.TryGetValue(letter, out points))
          total += points;
      }
      return total;
    }
  }
}
