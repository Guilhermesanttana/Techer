using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            using (var streamWrite = new StreamWriter(_path, true))
            {
                streamWrite.WriteLine("ERROR: " + message);
            }
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWrite = new StreamWriter(_path, true))
            {
                streamWrite.WriteLine(messageType + ": " + message);
            }
        }
    }
}
