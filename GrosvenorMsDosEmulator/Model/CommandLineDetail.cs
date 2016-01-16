using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorMsDosEmulator
{
    class CommandLineDetail
    {
        private const string DEFAULT_COMMAND = "CD";
        private const char DEFAULT_COMMANDLINE_DELIMITER = ' ';

        private string _commandLineText;


        private CommandLineDetail()
        {
            Arguments = new List<string>();
            HasArguments = false;
        }

        public CommandLineDetail(string commandLineText)
            : this()
        {
            _commandLineText = commandLineText;
            
            ParseInput(commandLineText);
        }


        public string Command { get; set; }
        public bool HasArguments { get; set; }
        public List<string> Arguments { get; set; }


        public override string ToString()
        {
            return _commandLineText;
        }


        private void ParseInput(string commandLineText)
        {
            SetCommand(commandLineText);
            SetArguments(commandLineText);
        }

        private void SetCommand(string commandLineText)
        {
            if (string.IsNullOrEmpty(commandLineText))
            {
                Command = DEFAULT_COMMAND;
            }
            else
            {
                var items = commandLineText.Split(DEFAULT_COMMANDLINE_DELIMITER);

                if(items.Length > 0)
                {
                    Command = items[0].ToUpper();

                    if (Command.Contains(".."))
                    {
                        Command = Command.TrimEnd('.');
                    }

                    if (Command.Contains(":"))
                    {
                        Command = DEFAULT_COMMAND;
                    }
                }
            }
        }

        private void SetArguments(string commandLineText)
        {
            var items = commandLineText.Split(DEFAULT_COMMANDLINE_DELIMITER);

            if (items.Length > 0 && items[0].EndsWith(".."))
            {
                HasArguments = true;
                Arguments.Add("..");
            }
            else if (items.Length > 0 && items[0].Contains(":"))
            {
                HasArguments = true;
                Arguments.Add(items[0]);
            }
            else if (items.Length > 1)
            {
                HasArguments = true;
                Arguments = items.Skip(1).ToList();
            }
        }
    }
}
