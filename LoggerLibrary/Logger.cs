using LoggerLibrary;
using System;
using System.IO;

namespace LoggerLibrary
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private readonly string _logFilePath;

        private Logger()
        {
            _logFilePath = "application.log";
            Console.WriteLine("Logger initialized.");
        }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            try
            {
                File.AppendAllText(_logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Logging error: {ex.Message}");
            }
        }
    }
}

