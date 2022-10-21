using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_A_Level
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<string> MyQ = new Queue<string>();
			MyQ.Enqueue("Abc");
			MyQ.Enqueue("Def");
			MyQ.Enqueue("Ghj");

			Console.WriteLine("Queue Demonstration");
			Console.WriteLine($"Queue Count: {MyQ.Count}");
			Console.WriteLine($"Dequeued: {MyQ.Dequeue()}");
			Console.WriteLine($"Queue Count after dequeue: {MyQ.Count}");

			Console.WriteLine("For each through the rest");
			foreach (string StringTing in MyQ)
			{
				Console.WriteLine($"More String Queues: {StringTing}");
			}

		}
	}
}
