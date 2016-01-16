using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorTextEditor.BusinessLogic
{
    public interface IWordCounter : ICounter<string>
    {
        event ChangedWordCountEventHandler WordCountChanged;

        string GetLargestWord();
        string GetMostFrequentlyUsedWord();
        string GetSmallestWord();
        int GetTotalNumberOfWords();
        int GetWordCount(string word);
    }
}
