using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

    namespace WordCounter.Tests
    {
        [TestClass]
        public class WordCounterTest
        {
            [TestMethod]
            public void UserWord_Check()
            {

            WordCount myCount = new WordCount();
            Assert.AreEqual("Hello", myCount.wordInput("Hello"));
            }

            [TestMethod]
            public void Sentence_Check()
            {

            WordCount mySentence = new WordCount();
            Assert.AreEqual("Hello", "There", mySentence.sentenceInput("Hello There"));
            }
            
            [TestMethod]
            public void Sentence_Check()
            {

            WordCount mySentence = new WordCount();
            Assert.AreEqual("Hello", "There", mySentence.sentenceInput("Hello There"));
            }
        }
    }
