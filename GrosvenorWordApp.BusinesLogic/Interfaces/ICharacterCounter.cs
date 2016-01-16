using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorTextEditor.BusinessLogic
{
    public interface ICharacterCounter : ICounter<char>
    {
        event ChangedCharacterCountEventHandler CharacterCountChanged;

        void Add(string s);        
        int GetCharacterCount(char character);
        int GetTotalNumberOfCharacters();
        void Remove(string s);
    }
}
