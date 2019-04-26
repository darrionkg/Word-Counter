namespace WordCounter
{
  public class ReplaceWords
  {
    private string _word;
    private string _sentence;
    private string _replacementWord;
    private bool _replacePartialWord;

    public ReplaceWords(string word, string sentence, string replacementWord)
    {
      _word = word;
      _sentence = sentence;
      _replacementWord = replacementWord;
      _replacePartialWord = false;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetReplacePartialWordTrue(bool partialWordTrue)
    {
      _replacePartialWord = partialWordTrue;
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
  }
}
