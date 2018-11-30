using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordApp.Models;
using System.Collections.Generic;
using System;

namespace WordApp.Tests
{
  [TestClass]
  public class WordCounterTest
  {

    [TestMethod]
    public void InputConstructor_TypeOfInput_Type()
    {
      WordCounter newWord = new WordCounter("test", "test two");
      Assert.AreEqual(typeof(WordCounter), newWord.GetType());
    } 

   [TestMethod]
    public void Counter_CheckForInstanceOfWordInSentence_int()
    {

      string Word = "dog";
      string Sentence = "My dog is a dog";
      WordCounter myWord = new WordCounter(Word, Sentence);

      Assert.AreEqual(2, myWord.countWords(Word,Sentence));
    }  
  }
}