using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GrosvenorTextEditor.BusinessLogic;

namespace GrosvenorTextEditor.Tests.BusinessLayer
{
    [TestClass]
    public class WordCounterTests
    {
        private char[] wordDelimiterCharacters = new char[] { ' ', '.', ',', '!', '?' };

        [TestMethod]
        public void ShouldBeAbleToAddAWord()
        {
            IWordCounter wordCounter = new WordCounter(wordDelimiterCharacters);
            wordCounter.Add("test");

            int expectedResult = 1;

            Assert.AreEqual(expectedResult, wordCounter.GetTotalNumberOfWords());
        }

        [TestMethod]
        public void ShouldBeAbleToAddAScentence()
        {
            IWordCounter wordCounter = new WordCounter(wordDelimiterCharacters);
            wordCounter.Add("This is a test.");

            int expectedResult = 4;

            Assert.AreEqual(expectedResult, wordCounter.GetTotalNumberOfWords());
        }
    }
}
