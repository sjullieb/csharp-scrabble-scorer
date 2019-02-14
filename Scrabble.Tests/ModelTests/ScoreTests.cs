using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void ScoreWord_Checks1PointLetters_Score()
    {
      Assert.AreEqual(1, Scorer.ScoreWord("A"));
    }

    [TestMethod]
    public void ScoreWord_Checks2PointLetters_Score()
    {
      Assert.AreEqual(2, Scorer.ScoreWord("D"));
    }

    [TestMethod]
    public void ScoreWord_Checks3PointLetters_Score()
    {
      Assert.AreEqual(3, Scorer.ScoreWord("B"));
    }

    [TestMethod]
    public void ScoreWord_Checks4PointLetters_Score()
    {
      Assert.AreEqual(4, Scorer.ScoreWord("H"));
    }

    [TestMethod]
    public void ScoreWord_Checks5PointLetters_Score()
    {
      Assert.AreEqual(5, Scorer.ScoreWord("K"));
    }

    [TestMethod]
    public void ScoreWord_Checks9PointLetters_Score()
    {
      Assert.AreEqual(8, Scorer.ScoreWord("X"));
    }

    [TestMethod]
    public void ScoreWord_Checks10PointLetters_Score()
    {
      Assert.AreEqual(10, Scorer.ScoreWord("Z"));
    }

    [TestMethod]
    public void ScoreWord_ChecksRandomWord_Score()
    {
      Assert.AreEqual(33, Scorer.ScoreWord("qjkymgt"));
    }

    [TestMethod]
    public void ScoreWord_ChecksNonAlphabeticLetter_Score()
    {
      Assert.AreEqual(2, Scorer.ScoreWord("7d"));
    }
  }
}
