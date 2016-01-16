using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorTextEditor.BusinessLogic
{
    public delegate void ChangedCharacterCountEventHandler(object sender, CharacterCounterEventArgs e);

    public class CharacterCounter : CounterBase<char>, ICharacterCounter
    {
        #region Member Variables

        private const int DEFAULT_MAX_CHARACTER_CAPACITY = 8000;
        
        private int _maxCharacterCapacity;
        private char[] _forbiddenCharacters;

        #endregion

        #region Constructors

        public CharacterCounter(char[] forbiddenCharacters)
            : this(forbiddenCharacters, false)
        {
          
        }

        public CharacterCounter(char[] forbiddenCharacters, bool isCaseSensitive)
            : this(forbiddenCharacters, isCaseSensitive, DEFAULT_MAX_CHARACTER_CAPACITY)           
        {           
        }

        public CharacterCounter(char[] forbiddenCharacters, bool isCaseSensitive, int maxCharacterCapacity)
            : base()
        {
            IsCaseSensitive = isCaseSensitive;
            _maxCharacterCapacity = maxCharacterCapacity;
            _forbiddenCharacters = forbiddenCharacters;
        }

        #endregion

        #region Public Methods

        public override void Add(char c)
        {
            if (!IsCaseSensitive)
            {
                c = Char.ToUpper(c);
            }

            if (IsValidCharacter(c) && (GetTotalNumberOfCharacters() < _maxCharacterCapacity))
            {
                base.Add(c);
            }

            OnCharacterCountChanged(new CharacterCounterEventArgs(Items.Count, GetTotalNumberOfCharacters()));
        }

        public void Add(string s)
        {
            foreach (var c in s.ToCharArray())
            {
                Add(c);
            }
        }

        public int GetCharacterCount(char character)
        {
            if (IsCaseSensitive == false)
            {
                character = char.ToUpper(character);
            }

            return base.GetKeyValue(character);
        }

        public int GetTotalNumberOfCharacters()
        {
            return base.GetTotalSumOfValues();
        }

        public override void Remove(char c)
        {
            if (!IsCaseSensitive)
            {
                c = Char.ToUpper(c);
            }

            if (IsValidCharacter(c))
            {
                base.Remove(c);
            }

            OnCharacterCountChanged(new CharacterCounterEventArgs(Items.Count, GetTotalNumberOfCharacters()));
        }

        public void Remove(string s)
        {
            foreach (var c in s.ToCharArray())
            {
                Remove(c);
            }
        }

        public override void Reset()
        {
            base.Reset();

            OnCharacterCountChanged(new CharacterCounterEventArgs(Items.Count, GetTotalNumberOfCharacters()));
        }

        #endregion

        #region Private Members     

        private bool IsValidCharacter(char c)
        {
            if(_forbiddenCharacters != null && _forbiddenCharacters.Length > 0)
                return !_forbiddenCharacters.Any(x => x.Equals(c));

            return true;
        }
      
        #endregion

        #region Events

        public event ChangedCharacterCountEventHandler CharacterCountChanged;
        protected virtual void OnCharacterCountChanged(CharacterCounterEventArgs e)
        {
            if (CharacterCountChanged != null)
                CharacterCountChanged(this, e);
        }
       
        #endregion                  
    }

    public class CharacterCounterEventArgs : EventArgs
    {
        public CharacterCounterEventArgs(int distinct, int count)
        {
            DistinctCharacterCount = distinct;
            TotalCharacterCount = count;
        }

        public int DistinctCharacterCount { get; set; }
        public int TotalCharacterCount { get; set; }        
    }

}
