using System;
using System.IO;

public class logger
{
	private readonly string logFilePath;

	public logger(string filePath)
	{
		logFilePath = filePath;
	}

	public void Log(string message)
	{
		string logEntry = $"{DateTime.Now}: {message}";
		File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
		Console.WriteLine(logEntry); // Optionally, log to console too
	}

	public void LogError(Exception ex)
	{
		string errorLog = $"{DateTime.Now}: ERROR - {ex.Message}{Environment.NewLine}{ex.StackTrace}";
		File.AppendAllText(logFilePath, errorLog + Environment.NewLine);
		Console.WriteLine(errorLog); // Optionally, log to console too
	}
}
