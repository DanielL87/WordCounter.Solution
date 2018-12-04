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
    public void WordConstructor_CreatesInstanceOfWord_String()
    {
      string str = "beetles";
      WordCounter newWord = new WordCounter(str, "test");
      Assert.AreEqual("beetles", newWord.GetWord());
    } 

    [TestMethod]
    public void SentenceConstructor_CreatesInstanceOfSentence_String()
    {
      string str = "beetles are bugs";
      WordCounter newSentence = new WordCounter("test", str);
      Assert.AreEqual("beetles are bugs", newSentence.GetSentence());
    } 

    [TestMethod]
    public void Counter_CheckForInstanceOfWordInSentence_int()
    {
      string word = "dog";
      string sentence = "My dog is a dog with a dog who is also a dog";
      WordCounter myWord = new WordCounter(word, sentence);

      Assert.AreEqual(4, myWord.CountWords());
      
    }  
  }
}