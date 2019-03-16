using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igor.TCP;



namespace ChodbaSvetlaInteraction
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Hello world");
			Console.WriteLine("Enter the ip of the esp");
			string address = Console.ReadLine();
			
			while (true)
			{
				TCPClient client = new TCPClient(address, Constants.PORT);
				client.Connect();


			}




			

			

		}
	}
}
