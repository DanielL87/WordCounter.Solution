
using System.Collections.Generic;

namespace WordApp.Models
{ 


   public class WordCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private int _wordCount;

    public WordCounter(string wordInput, string sentenceInput)
    {
      _wordInput = wordInput.ToLower();
      _sentenceInput = sentenceInput.ToLower();
    }

    public string GetWord()
    {
      return _wordInput;
    }

     public int countWords(string userWord, string sentence)
    {

      string [] userSentenceSplit = sentence.Split(' ').ToArray();
      
      int counter = 0;
      for (int x = 0; x < userSentenceSplit.Length;x++)
      {
        if(userSentenceSplit[x] == userWord)
        {
          counter++;
        }
      }
     return counter;
    }
  }
}  
