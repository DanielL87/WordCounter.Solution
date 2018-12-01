
using System.Collections.Generic;
using System;
using System.Linq;

namespace WordApp.Models
{ 


   public class WordCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private int _wordCount = 0;

    public WordCounter(string wordInput, string sentenceInput)
    {
      _wordInput = wordInput.ToLower();
      _sentenceInput = sentenceInput.ToLower();
    }

    public string GetWord()
    {
      return _wordInput;
    }

    public string GetSentence()
    {
      return _sentenceInput;
    }

    public int GetWordCount()
    {
      return _wordCount;
    }

    public int CountWords()
    {

      string [] userSentenceSplit = _sentenceInput.Split(' ').ToArray();
      
      int _wordcounter = 0;
      for (int x = 0; x < userSentenceSplit.Length;x++)
      {
        if(userSentenceSplit[x] ==  _wordInput)
        {
          _wordcounter++;
        }
      }
     return _wordcounter;
    }
  }
}  
