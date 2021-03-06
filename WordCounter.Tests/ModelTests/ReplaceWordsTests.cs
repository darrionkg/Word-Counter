using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class ReplaceWordsTest
  {
    [TestMethod]
    public void SetPropertyWithConstructor_StoresWords_()
    {
      ReplaceWords testCase = new ReplaceWords("word", "this is a sentence", "dog");
      //Works. Also returns the correct full sentence string
      //Assert.AreEqual("this is a sentence", testCase.GetSentence());
      Assert.AreEqual(typeof(ReplaceWords), testCase.GetType());
    }

    [TestMethod]
    public void MakeSentenceArray_MakesSentenceStringAnArray_StringArray()
    {
      ReplaceWords testCase = new ReplaceWords("word", "the cat", "dog");
      string[] testArray = {"the", "cat"};
      CollectionAssert.AreEqual(testCase.GetSentenceArray(), testArray);
    }

    [TestMethod]
    public void CheckForMatches_ChecksForNoMatchAndReturnOriginal_int()
    {
      ReplaceWords testCase = new ReplaceWords("word", "the cat", "dog");
      int numOfMatches = testCase.CheckForMatches();
      Assert.AreEqual(numOfMatches, 0);
    }

    [TestMethod]
    public void CheckForMatches_ChecksForOneWordMatch_int()
    {
      ReplaceWords testCase = new ReplaceWords("cat", "the cat", "dog");
      int numOfMatches = testCase.CheckForMatches();
      Assert.AreEqual(numOfMatches, 1);
    }

    [TestMethod]
    public void CheckForMatches_ChecksForMultipleWordMatches_int()
    {
      // bug with comma in sentence
      string longSentence = "the cat Meatball met another cat and became best friends with the cat even though he was an ally cat it didn't matter because he was a good cat friend";
      ReplaceWords testCase = new ReplaceWords("cat", longSentence, "dog");
      int numOfMatches = testCase.CheckForMatches();
      Assert.AreEqual(numOfMatches, 5);
    }

    [TestMethod]
    public void Replace_ReplacesWordWithNewWord_string()
    {
      string sentenceToFix = "The cat barked at the cathedral";
      string testFixedSentence = "The dog barked at the cathedral";
      ReplaceWords testCase = new ReplaceWords("cat", sentenceToFix, "dog");
      string fixedSentence = testCase.Replace();
      Assert.AreEqual(testFixedSentence, fixedSentence);
    }

    [TestMethod]
    public void ReplacePartialWord_ReplacesPartsOfStrings_string()
    {
      string sentenceToFix = "The cat barked at the cathedral";
      string testFixedSentence = "The dog barked at the doghedral";
      ReplaceWords testCase = new ReplaceWords("cat", sentenceToFix, "dog");
      // this setter will be used for UI logic to determine how the user would like to replace the word
      testCase.SetReplacePartialWordTrue(true);
      string fixedSentence = testCase.ReplacePartialWord();
      Assert.AreEqual(testFixedSentence, fixedSentence);
    }

    [TestMethod]
    public void SetIgnoreCaseTrue_IgnoresCasing_true()
    {
      string sentenceToFix = "ThE cAt BaRked at the CatHedral";
      string testFixedSentence = "the dog barked at the cathedral";
      ReplaceWords testCase = new ReplaceWords("cat", sentenceToFix, "dog");
      testCase.SetIgnoreCaseTrue(true);
      string fixedSentence = testCase.Replace();
      Assert.AreEqual(testFixedSentence, fixedSentence);
    }

  }
}
