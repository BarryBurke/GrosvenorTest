using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorTextEditor
{
    public interface ITextEditorView
    {
        event EventHandler Clear;
        event EventHandler Exit;
        event EventHandler CharacterStats;
        event EventHandler IsCaseSensitive;

        string CharacterCount { get; set; }
        string CharactersRemaining { get; set; }
        string LongestWord { get; set; }
        string MostFrequentWord { get; set; }
        string ShortestWord { get; set; }
        string Text { get; set; }
        string WordCount { get; set; }
        


    }
}
