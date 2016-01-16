using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrosvenorTextEditor.BusinessLogic;

namespace GrosvenorTextEditor
{
    public partial class TextEditorForm : Form
    {          
        private const char BACKSPACE_CHARACTER = '\b';
        private const char PASTE_CHARACTER = (char)22;
        private const int MAX_INPUT_CHARACTERS = 8000;

        private ICharacterCounter _characterCounter;
        private IWordCounter _wordCounter;

        public TextEditorForm()
        {
            InitializeComponent();

            char[] nonCountedCharacters = new char[] { '\n', '\t', '\r', ' ', }; /// -> best to load from a settings file

            _characterCounter = new CharacterCounter(nonCountedCharacters, isCaseSensitiveToolStripMenuItem.Checked, MAX_INPUT_CHARACTERS);
            _characterCounter.CharacterCountChanged += new ChangedCharacterCountEventHandler(TextMonitor_CharacterCountChanged);

            char[] wordDelimiterCharacters = new char[] { ' ', ',', ';', '.', '!', '"', '(', ')', '\n', '\t', '\r', '?' }; /// -> best to load from a settings file
                                                                                   
            _wordCounter = new WordCounter(wordDelimiterCharacters);
            _wordCounter.WordCountChanged += new ChangedWordCountEventHandler(WordCounter_WordCountChanged);
        }

       

        void TextMonitor_CharacterCountChanged(object sender, CharacterCounterEventArgs e)
        {
            CharacterCountToolStripStatusLabel.Text = e.TotalCharacterCount.ToString();
            DistinctCharacterCountToolStripStatusLabel.Text = e.DistinctCharacterCount.ToString();
            NumCharactersRemainingToolStripStatusLabel.Text = (MAX_INPUT_CHARACTERS - e.TotalCharacterCount).ToString();

            ///doesn't work well with pasting over the limit
            //if (MAX_INPUT_CHARACTERS == e.TotalCharacterCount)
            //{
            //    MessageBox.Show("Sorry, the maximum number of characters allowed in this text field has been reached", "Grosvenor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        void WordCounter_WordCountChanged(object sender, WordCounterEventArgs e)
        {
            LargestWordToolStripMenuItem.Text = String.Format("Largest Word: '{0}'", e.LargestWord);
            MostFrequentWordToolStripMenuItem.Text = String.Format("Most Freqent Word: '{0}'", e.MostFrequentWord);
            SmallestWordToolStripMenuItem.Text = String.Format("Smallest Word: '{0}'", e.SmallestWord);
            TotalWordCountToolStripStatusLabel.Text = e.TotalWordCount.ToString();
        }
            
        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != PASTE_CHARACTER)
            {
                if (InputTextBox.SelectionLength > 0)
                {
                    RemoveFromCharacterCounter(InputTextBox.SelectedText);

                    if (e.KeyChar != BACKSPACE_CHARACTER)
                    {
                        AddToCharacterCounter(e.KeyChar);
                    }
                }
                else
                {
                    if (e.KeyChar == BACKSPACE_CHARACTER)
                    {
                        RemoveFromCharacterCounter(GetPreCursorCharacter());
                    }
                    else
                    {
                        AddToCharacterCounter(e.KeyChar);
                    }
                }
            }
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveFromCharacterCounter(GetPostCursorCharacter());
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                if (InputTextBox.SelectionLength > 0)
                {
                    ReplaceSelection(InputTextBox.SelectedText, Clipboard.GetText());
                }
                else
                {
                    AddToCharacterCounter(Clipboard.GetText());
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();

            _characterCounter.Reset();
            _wordCounter.Reset();
        }       


        private void AddToCharacterCounter(char c)
        {
            _characterCounter.Add(c);
        }

        private void AddToCharacterCounter(string s)
        {
            _characterCounter.Add(s);
        }

        private void RemoveFromCharacterCounter(char c)
        {
            _characterCounter.Remove(c);
        }

        private void RemoveFromCharacterCounter(string s)
        {
            _characterCounter.Remove(s);
        }       


        private void ReplaceSelection(string selectedText, string replacementText)
        {
            RemoveFromCharacterCounter(selectedText);

            AddToCharacterCounter(replacementText);            
        }

        private char GetPreCursorCharacter()
        {
            if (InputTextBox.SelectionStart > 0)
                return InputTextBox.Text[InputTextBox.SelectionStart - 1];

            return '\0';
        }

        private char GetPostCursorCharacter()
        {
            if (InputTextBox.TextLength > 0)
                return InputTextBox.Text[InputTextBox.SelectionStart];

            return '\0';
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {           
            _wordCounter.Reset();
            _wordCounter.Add(InputTextBox.Text);
        }

        private void characterStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterUsageForm form = new CharacterUsageForm(_characterCounter.GetAll());
            form.ShowDialog(this);
        }

        private void isCaseSensitiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Changing the case sensitivity will clear the text field\n\nDo you want to continue?", "Grosvenor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _characterCounter.IsCaseSensitive = isCaseSensitiveToolStripMenuItem.Checked;
                InputTextBox.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
