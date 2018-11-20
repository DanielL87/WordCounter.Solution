using System;
using System.Linq;

namespace WordApp
{ 

    public class Program
  {
    public static void Main()
    {
      WordCount myCount = new WordCount();
    }
  }

  public class WordCount
  {
    public string wordInput(string word)
    {
      return word;
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
