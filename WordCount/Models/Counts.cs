namespace Wordcounter
{
  public class WordCount
  {
    public string wordInput(string word)
    {
      string userWord = word;
      return userWord;
    }
    public string sentenceInput(string sentence)
    {
      string [] userSentenceSplit = sentence.Split(' ');
      return userSentenceSplit;
    }
    public int countWords(string userWord, string userSentenceSplit)
    {
      int counter = 0;
      for (int x = 0; x <= userSentenceSplit.Length; x++)
      {
        if(userSentenceSplit[x] == userWord)
        {
          counter++;
        }
          return counter;
      }
    }
  }
}  
