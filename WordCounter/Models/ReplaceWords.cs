namespace WordCounter
{
  public class ReplaceWords
  {
    private string _word;
    private string _sentence;

    public ReplaceWords(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    // public char[] MakeWordArray()
    // {
    //   string lowerCaseWord = _word.ToLower();
    //   char[] wordArray = lowerCaseWord.ToCharArray();
    //   return wordArray;
    // }
    public string[] MakeSentenceArray()
    {
      string[] sentenceArray = _sentence.Split(' ');
      return sentenceArray;
    }

    public int CheckForMatches(string[] sentenceArray)
    {
      int matches = 0;

      return matches;
    }

    // public int CheckForMatches(char[] wordArray, char[] sentenceArray)
    // {
    //   int matches = 0;
    //   // 20 is the max number of characters in a word I'm testing
    //   char[] tempWord = new char[20];
    //   for(int i = 0; i < sentenceArray.Length; i++) {
    //     for(int j = 0; j < wordArray.Length; j++) {
    //       if(sentence[i] != ' ') {
    //
    //         if(sentenceArray[i] == wordArray[j]) {
    //           tempWord[j] = word[j];
    //         }
    //         else {
    //
    //         }
    //       else {
    //         // if tempWord matches sentenceWord
    //         Array.Clear(tempWord, 0, 19);
    //       }
    //     }
    //   }
    //   if(matches != 0) {
    //     return 1;
    //   }
    //   else {
    //     return 0;
    //   }
    // }
  }
}
