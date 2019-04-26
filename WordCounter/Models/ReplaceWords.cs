namespace WordCounter
{
  public class ReplaceWords
  {
    private string _word;
    private string _sentence;
    private string _replacementWord;
    private bool _replacePartialWord;
    private bool _ignoreCase;
    private bool _useWildCard

    public ReplaceWords(string word, string sentence, string replacementWord)
    {
      _word = word;
      _sentence = sentence;
      _replacementWord = replacementWord;
      _replacePartialWord = false;
      _ignoreCase = false;
      _useWildCard = false;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetReplacePartialWordTrue(bool partialWordTrue)
    {
      _replacePartialWord = partialWordTrue;
    }

    public void SetUseWildCard(bool wildCardTrue)
    {
      _useWildCard = wildCardTrue;
    }

    public void SetIgnoreCaseTrue(bool ignoreCaseTrue)
    {
      _word = _word.ToLower();
      _sentence = _sentence.ToLower();
      _replacementWord = _replacementWord.ToLower();
      _ignoreCase = ignoreCaseTrue;
    }

    public string[] MakeSentenceArray()
    {
      string[] sentenceArray = _sentence.Split(' ');
      return sentenceArray;
    }

    public int CheckForMatches(string[] sentenceArray)
    {
      int matches = 0;
      for(int i = 0; i < sentenceArray.Length; i++) {
        if(sentenceArray[i] == _word) {
          matches++;
        } else {
          continue;
        }
      }
      return matches;
    }

    public string Replace(string[] newSentenceArray)
    {
      for(int i = 0; i < newSentenceArray.Length; i++) {
        if(newSentenceArray[i] == _word) {
          newSentenceArray[i] = _replacementWord;
        } else {
          continue;
        }
      }
      string newSentenceString = string.Join(" ", newSentenceArray);
      return newSentenceString;
    }

    public string ReplacePartialWord()
    {
      string newSentence = _sentence.Replace(_word, _replacementWord);
      return newSentence;
    }

    // IGNORE ALL OF THIS. HAVENT FIGURED IT OUT YET. LEFT BECAUSE IT"S A 2 WEEK PROJECT
    // public string UsingWildcard(string[] newSentenceArray)
    // {
    //
    //   for(int i = 0; i < newSentenceArray.Length; i++) {
    //     char[] charArrayOfWord = newSentenceArray.ToCharArray();
    //     //newSentenceArray.IndexOf("*")
    //     for(int i = 0; i < charArrayOfWord.Length; i++) {
    //       if(charArrayOfWord[i] == '*') {
    //         correspondingLetter = FindMissingLetter(charArrayOfWord)
    //         newSentenceArray[i] = newSentenceArray.Replace("*", correspondingLetter);
    //       }
    //     }
    //     } else {
    //       continue;
    //     }
    // }
    //
    // public char = findMissingLetter(char[] charArrayOfWord)
    // {
    //   string foundLetters = "";
    //   for(int i = 0; i < charArrayOfWord.Length; i++) {
    //     for(int j = 0; j < _word.Length; j++) {
    //       // might have to convert _word to string?
    //       if(charArrayOfWord[i] == _word[j]) {
    //         foundLetters += _word[j];
    //       }
    //
    //
    //     }
    //   }
    // }
  }
}
