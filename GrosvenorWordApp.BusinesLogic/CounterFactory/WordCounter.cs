using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorTextEditor.BusinessLogic
{
    public delegate void ChangedWordCountEventHandler(object sender, WordCounterEventArgs e);

    public class WordCounter : CounterBase<string>, IWordCounter
    {
        #region Member Variables

        private char[] _wordDemiliterCharacters;

        #endregion

        #region Constructors

        public WordCounter(char[] wordDemiliterCharacters)   
            : base()
        {
            _wordDemiliterCharacters = wordDemiliterCharacters;
        }

        #endregion

        #region Public Methods

        public override void Add(string key)
        {
            //if (ContainsDelimiter(key))
            //{               
                foreach (var w in key.Split(_wordDemiliterCharacters, StringSplitOptions.RemoveEmptyEntries))
                {
                    base.Add(w.Trim());
                }                
            //}

            OnWordCountChanged(new WordCounterEventArgs(GetTotalNumberOfWords(), GetLargestWord(), GetSmallestWord(), GetMostFrequentlyUsedWord()));
        }
        
        public override void Remove(string key)
        {
            base.Remove(key);

            OnWordCountChanged(new WordCounterEventArgs(GetTotalNumberOfWords(), GetLargestWord(), GetSmallestWord(), GetMostFrequentlyUsedWord()));
        }

        public string GetLargestWord()
        {
            if (Items.Count == 0) return string.Empty;
            
            return Items.OrderByDescending(kp => kp.Key.Length).FirstOrDefault().Key;
        }

        public string GetMostFrequentlyUsedWord()
        {
            if(Items.Count == 0) return string.Empty;
           
            return Items.OrderByDescending(kp => kp.Value).Select(kp => kp.Key).FirstOrDefault();;
        }

        public string GetSmallestWord()
        {
            if (Items.Count == 0) return string.Empty;

            return Items.OrderBy(kp => kp.Key.Length).FirstOrDefault().Key;
        }

        public int GetTotalNumberOfWords()
        {
            return base.GetTotalSumOfValues();
        }

        public int GetWordCount(string word)
        {
            if (IsCaseSensitive == false)
            {
                word = word.ToUpper();
            }

            return base.GetKeyValue(word);
        }

        #endregion

        #region Private Members

        private bool ContainsDelimiter(string text)
        {
            foreach (var d in _wordDemiliterCharacters)
            {
                if (text.ToCharArray().Any(x => x.Equals(d))) return true;
            }

            return false;
        }

        #endregion

        #region Events

        public event ChangedWordCountEventHandler WordCountChanged;
        protected virtual void OnWordCountChanged(WordCounterEventArgs e)
        {
            if (WordCountChanged != null)
            {
                WordCountChanged(this, e);
            }
        }

        #endregion                  
    }

    public class WordCounterEventArgs : EventArgs
    {
        public WordCounterEventArgs(int totalWordCount, string largestWord, string smallestWord, string mostFrequentWord)
        {
            LargestWord = largestWord;
            SmallestWord = smallestWord;
            MostFrequentWord = mostFrequentWord;
            TotalWordCount = totalWordCount;
        }

        public string LargestWord { get; set; }
        public string MostFrequentWord { get; set; }
        public string SmallestWord { get; set; }
        public int TotalWordCount { get; set; }
    }
}
