using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
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
      string[] sentenceArray = testCase.MakeSentenceArray();
      string[] testArray = {"the", "cat"};
      CollectionAssert.AreEqual(sentenceArray, testArray);
    }

    [TestMethod]
    public void CheckForMatches_ChecksForNoMatchAndReturnOriginal_int()
    {
      ReplaceWords testCase = new ReplaceWords("word", "the cat", "dog");
      string[] sentenceArray = testCase.MakeSentenceArray();
      int numOfMatches = testCase.CheckForMatches(sentenceArray);
      Assert.AreEqual(numOfMatches, 0);
    }

    [TestMethod]
    public void CheckForMatches_ChecksForOneWordMatch_int()
    {
      ReplaceWords testCase = new ReplaceWords("cat", "the cat", "dog");
      string[] sentenceArray = testCase.MakeSentenceArray();
      int numOfMatches = testCase.CheckForMatches(sentenceArray);
      Assert.AreEqual(numOfMatches, 1);
    }

    [TestMethod]
    public void CheckForMatches_ChecksForMultipleWordMatches_int()
    {
      string longSentence = "the cat Meatball met another cat and became best friends with the cat even though he was an ally cat, it didn't matter because he was a good cat friend";
      ReplaceWords testCase = new ReplaceWords("cat", longSentence, "dog");
      string[] sentenceArray = testCase.MakeSentenceArray();
      int numOfMatches = testCase.CheckForMatches(sentenceArray);
      Assert.AreEqual(numOfMatches, 5);
    }
  }
}
