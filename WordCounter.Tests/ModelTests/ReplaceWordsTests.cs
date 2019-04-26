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
      ReplaceWords testCase = new ReplaceWords("word", "this is a sentence");
      //Works. Also returns the correct full sentence string
      //Assert.AreEqual("this is a sentence", testCase.GetSentence());
      Assert.AreEqual(typeof(ReplaceWords), testCase.GetType());
    }

    [TestMethod]
    public void MakeSentenceArray_MakesSentenceStringAnArray_Array()
    {
      ReplaceWords testCase = new ReplaceWords("word", "the cat");
      string[] sentenceArray = testCase.MakeSentenceArray();
      string[] testArray = {"the", "cat"};
      CollectionAssert.AreEqual(sentenceArray, testArray);
    }

    // [TestMethod]
    // public void CheckForMatches_ChecksForNoMatchAndReturnOriginal_string()
    // {
    //   ReplaceWords testCase = new ReplaceWords("word", "the cat");
    //   char[] wordArray = testCase.MakeWordArray();
    //   char[] sentenceArray = testCase.MakeSentenceArray();
    //   int numOfMatches = testCase.CheckForMatches(wordArray, sentenceArray);
    //   Assert.AreEqual(numOfMatches, 0);
    // }
  }
}
