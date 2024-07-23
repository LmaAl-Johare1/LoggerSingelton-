using System;
using LoggerLibrary;

class Program
{
    static void Main(string[] args)
    {
        Logger logger = Logger.Instance;

        logger.Log("Application started.");
        logger.Log("Performing some operations...");
        logger.Log("Application ended.");

        Console.WriteLine("Messages have been logged.");
    }
}
