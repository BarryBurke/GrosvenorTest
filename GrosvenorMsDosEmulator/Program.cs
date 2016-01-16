using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GrosvenorMsDosEmulator.Helpers;

namespace GrosvenorMsDosEmulator
{
    class Program
    {
        static string WorkingDirectory { get; set; }

        static void Main(string[] args)
        {
            WorkingDirectory = DirectoryHelper.GetCurrentDirectory();
            WriteToConsole("Welcome to Barry's Command Line Console", true, false);
            WriteToConsole(string.Empty, true, false);
            WriteToConsole(WorkingDirectory, false, true);

            CommandLineDetail cld = new CommandLineDetail(Console.ReadLine());

            while (!string.IsNullOrEmpty(cld.Command) && (cld.Command != "QUIT"))
            {
                DetermineSwitch(cld);

                WriteToConsole(WorkingDirectory, false, true);
                cld = new CommandLineDetail(Console.ReadLine());
            }
        }

        private static void DetermineSwitch(CommandLineDetail cld)
        {
            try
            {
                switch (cld.Command)
                {
                    case "":
                    case "CD":
                    case "CHDIR":
                        if (cld.HasArguments)
                            ChangeDirectoryCommand(cld.Arguments[0]);
                        break;
                    case "DEL":
                        DeleteCommand(cld.Arguments);
                        break;
                    case "DIR":
                        DirectoryCommand(cld.Arguments);
                        break;
                    case "RD":
                    case "RMDIR":
                        RemoveDirectoryCommand(cld.Arguments);
                        break;
                    case "REN":
                    case "RENAME":
                        RenameCommand(cld.Arguments);
                        break;
                    case "HELP":
                        HelpCommand();
                        break;
                    default:
                        WriteToConsole("Unknown Command", true, false);
                        HelpCommand();
                        break;
                }
            }
            catch (Exception ex)
            {
                WriteToConsole(ex.Message, true, false);
            }
        }

        /// <summary>
        /// Displays the name of or changes the current directory.
        /// </summary>
        private static void ChangeDirectoryCommand(string newDirectory)
        {
            if (newDirectory.Contains(':'))
            {
                WorkingDirectory = newDirectory;// +@"\"; 
            }
            else if (newDirectory.Equals(".."))
            {
                var dirs = WorkingDirectory.Split('\\');
                
                WorkingDirectory = WorkingDirectory.Replace(string.Format(@"\{0}", dirs[dirs.Length - 1]), "");
            }
            else
            {
                newDirectory = string.Format(@"{0}\{1}", WorkingDirectory, newDirectory);
                if(DirectoryHelper.DirectoryExists(newDirectory))
                {
                    WorkingDirectory = newDirectory;
                }
                else
                {
                    WriteToConsole("Directory Not Found", true, false);
                }
            }                      
        }

        /// <summary>
        /// Deletes one or more files.
        /// </summary>
        private static void DeleteCommand(List<string> filesToDelete)
        {
            if (filesToDelete.Count > 0)
            {
                foreach (var file in filesToDelete)
                {
                    DirectoryHelper.DeleteFile(WorkingDirectory, file);
                }
            }
        }

        /// <summary>
        /// Displays a list of files and subdirectories in a directory.
        /// </summary>
        private static void DirectoryCommand(List<string> args)
        {
            int sumOfDirs = 0;
            int sumOfFiles = 0;

            WriteToConsole(" Directory of " + WorkingDirectory, true, false);

            foreach (var subDir in DirectoryHelper.GetFolders(WorkingDirectory))
            {
                sumOfDirs++;
                string message = string.Format("{1, -15}   <DIR>   {0}", subDir.Name, subDir.CreationTime.ToString("dd/MM/yyyy HH:mm"));
                WriteToConsole(message, true, false);
            }

            foreach (var fi in DirectoryHelper.GetFiles(WorkingDirectory))
            {
                sumOfFiles++;
                string message = string.Format("{1, -15}       {2,10} {0}", fi.Name, fi.CreationTime.ToString("dd/MM/yyyy HH:mm"), fi.Length.ToString("n0"));
                WriteToConsole(message, true, false);
            }

            WriteToConsole(string.Format("         {0} File<s>", sumOfFiles), true, false);
            WriteToConsole(string.Format("         {0} Dir<s>", sumOfDirs), true, false);
        }

        /// <summary>
        /// Renames a file or files.
        /// </summary>
        private static void RenameCommand(List<string> args)
        {
            if (args.Count == 2)
            {
                string currentFileName = args[0];
                string newFileName = args[1];

                DirectoryHelper.RenameFile(WorkingDirectory, currentFileName, newFileName);
            }
        }

        /// <summary>
        /// Removes (deletes) a directory.
        /// </summary>
        private static void RemoveDirectoryCommand(List<string> directoriesToDelete)
        {
            if (directoriesToDelete.Count > 0)
            {
                foreach (var dir in directoriesToDelete)
                {
                    DirectoryHelper.DeleteFolder(WorkingDirectory, dir);
                }
            }
        }

        /// <summary>
        /// Display the app help
        /// </summary>
        private static void HelpCommand()
        {
            WriteToConsole("", true, false);
            WriteToConsole("Available commands:", true, false);
            WriteToConsole("", true, false);
            WriteToConsole("CD (CHDIR) - Change Directory", true, false);
            WriteToConsole("DEL - Deletes one or more files.", true, false);
            WriteToConsole("DIR - Displays a list of files and subdirectories in a directory.", true, false);
            WriteToConsole("RD (RMDIR) - Removes (deletes) a directory.", true, false);
            WriteToConsole("REN (RENAME) - Renames a file or files.", true, false);
            WriteToConsole("", true, false);
        }
      
        private static void WriteToConsole(string text, bool isNewLine, bool includeArrow)
        {
            if (includeArrow)
            {
                text = string.Format("{0}>", text);
            }

            if (isNewLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }
        }       
    }
}
