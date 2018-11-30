using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordApp.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
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
    public void WordInput_TestThatWordisString_string()
    {
      WordCounter myWord = new WordCounter("word", "sentence");
      Assert.AreEqual("string", myWord.wordInput("string"));
    }


   [TestMethod]
    public void Counter_CheckForInstanceOfWordInSentence_int()
    {
      WordCount myWord = new WordCount();
      string Word = "dog";
      string Sentence = "My dog is a dog";
      

      Assert.AreEqual(2, myWord.countWords(Word,Sentence));
    }  
  }
}