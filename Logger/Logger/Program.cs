using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
	internal class Program
	{
		
		static void Main(string[] args)
		{

			logger logger = new logger("log.txt");
			

			string Keypress()
			{
				if (Console.ReadLine() == "a") 
				{
					logger.Log("Pressed a");
					
				}else
				{
					logger.Log("Not pressed a");
					
				}
				return "";
			}

			Keypress();

			try
			{
				logger.Log("Application started");
				
				int a = 10;
				int result = a / 0;
				// Simulating an error
				//throw new InvalidOperationException("Something went wrong!");
			}
			catch (Exception ex)
			{
				logger.LogError(ex);
				Console.WriteLine("YOU HAVE ERROR " + ex.ToString());
			}
			finally
			{
				logger.Log("Application ended");
			}

			Console.ReadLine();
		}
	}
}
