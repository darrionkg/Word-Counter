namespace WordCounter.Models
{
  public class ReplaceWords
  {
    private string _word;
    private string _sentence;
    private string _replacementWord;
    private bool _replacePartialWord;
    private bool _ignoreCase;
    private bool _useWildCard;
    private string[] _sentenceArray;

    public ReplaceWords(string word, string sentence, string replacementWord)
    {
      _word = word;
      _sentence = sentence;
      _replacementWord = replacementWord;
      _replacePartialWord = false;
      _ignoreCase = false;
      _useWildCard = false;
      _sentenceArray = sentence.Split(' ');
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string[] GetSentenceArray()
    {
      return _sentenceArray;
    }

    public void SetSentenceArray(string[] sentenceArray)
    {
      _sentenceArray = sentenceArray;
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
      for(int i = 0; i < _sentenceArray.Length; i++) {
        _sentenceArray[i] = _sentenceArray[i].ToLower();
      }
      _replacementWord = _replacementWord.ToLower();
      _ignoreCase = ignoreCaseTrue;
    }

    public int CheckForMatches()
    {
      int matches = 0;
      for(int i = 0; i < _sentenceArray.Length; i++) {
        if(_sentenceArray[i] == _word) {
          matches++;
        } else {
          continue;
        }
      }
      return matches;
    }

    public string Replace()
    {
      for(int i = 0; i < _sentenceArray.Length; i++) {
        if(_sentenceArray[i] == _word) {
          _sentenceArray[i] = _replacementWord;
        } else {
          continue;
        }
      }
      string newSentenceString = string.Join(" ", _sentenceArray);
      return newSentenceString;
    }

    public string ReplacePartialWord()
    {
      string newSentence = _sentence.Replace(_word, _replacementWord);
      return newSentence;
    }
  }
}
