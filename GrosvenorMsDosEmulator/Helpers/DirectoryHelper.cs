using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace GrosvenorMsDosEmulator.Helpers
{
    public static class DirectoryHelper
    {
        public static string GetCurrentDirectory()
        {
            return Environment.CurrentDirectory;
        }

        public static List<FileInfo> GetFiles(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                    throw new IOException(string.Format("Directory {0} not found.", directoryPath));

                DirectoryInfo directory = new DirectoryInfo(directoryPath);

                return directory.GetFiles().ToList();
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<DirectoryInfo> GetFolders(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                    throw new IOException(string.Format("Directory {0} not found.", directoryPath));

                DirectoryInfo directory = new DirectoryInfo(directoryPath);
                
                return directory.GetDirectories().ToList();
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void DeleteFile(string workingDirectory, string file)
        {
            try
            {
                DeleteFile(Path.Combine(workingDirectory, file));
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void DeleteFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new IOException(string.Format("File {0} not found.", filePath));
               
                File.Delete(filePath);
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteFolder(string workingDirectory, string directory)
        {
            try
            {
                DeleteFolder(Path.Combine(workingDirectory, directory));
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void DeleteFolder(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                    throw new IOException(string.Format("Directory {0} not found.", directoryPath));

                DirectoryInfo directory = new DirectoryInfo(directoryPath);

                directory.Delete(true);              
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool DirectoryExists(string directoryPath)
        {
            try
            {
                if(!Directory.Exists(directoryPath))
                    throw new IOException(string.Format("Directory {0} not found.", directoryPath));

                return true;               
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void RenameFile(string workingDirectory, string fileName, string newFileName)
        {
            try
            {
                RenameFile(Path.Combine(workingDirectory, fileName), Path.Combine(workingDirectory, newFileName));
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void RenameFile(string filePath, string newFileName)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new IOException(string.Format("File {0} not found.", filePath));

                FileInfo file = new FileInfo(filePath);

                File.Move(filePath, Path.Combine(file.DirectoryName, newFileName));

                File.Delete(filePath);
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
