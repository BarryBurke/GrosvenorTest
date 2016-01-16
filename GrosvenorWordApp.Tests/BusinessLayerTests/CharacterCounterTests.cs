using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GrosvenorTextEditor.BusinessLogic;

namespace GrosvenorTextEditor.Tests.BusinessLayer
{
    [TestClass]
    public class CharacterCounterTests
    {
        private char[] forbiddenCharacters = new char[] { '\n', '\t', '\r', ' ', };

        [TestMethod]
        public void ShouldAcceptACharacter()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, false);
            characterCounter.Add('a');

            int expectedResult = 1;

            Assert.AreEqual(expectedResult, characterCounter.GetTotalNumberOfCharacters());
        }

        [TestMethod]
        public void ShouldAcknowledgeCaseWhenAddingCharacters()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, true);
            characterCounter.Add('a');
            characterCounter.Add('A');
            characterCounter.Add('a');

            int expectedResult = 2;

            Assert.AreEqual(expectedResult, characterCounter.GetCharacterCount('a'));
        }

        [TestMethod]
        public void ShouldIgnoreCaseWhenAddingCharacters()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, false);
            characterCounter.Add('a');
            characterCounter.Add('A');
            characterCounter.Add('a');

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, characterCounter.GetCharacterCount('a'));
        }

        [TestMethod]
        public void ShouldIgnoreForbiddenCharactersWhenAddingCharacters()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, false);
            characterCounter.Add('a');
            characterCounter.Add('b');
            characterCounter.Add('c');
            characterCounter.Add('\t');
            characterCounter.Add(' ');

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, characterCounter.GetTotalNumberOfCharacters());
        }

        [TestMethod]
        public void ShouldAcceptAString()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, false);
            characterCounter.Add("abc");

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, characterCounter.GetTotalNumberOfCharacters());
        }

        [TestMethod]
        public void ShouldAcknowledgeCaseWhenAddingAString()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, true);
            characterCounter.Add("AAA aaa");

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, characterCounter.GetCharacterCount('a'));
        }  

        [TestMethod]
        public void ShouldIgnoreCaseWhenAddingAString()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, false);
            characterCounter.Add("AAA aaa");

            int expectedResult = 6;

            Assert.AreEqual(expectedResult, characterCounter.GetCharacterCount('a'));
        }  

        [TestMethod]
        public void ShouldIgnoreForbiddenCharactersWhenAddingAString()
        {
            ICharacterCounter characterCounter = new CharacterCounter(forbiddenCharacters, false);
            characterCounter.Add("Aa \n Bb \t Cc \r");

            int expectedResult = 6;

            Assert.AreEqual(expectedResult, characterCounter.GetTotalNumberOfCharacters());
        }  
    }
}