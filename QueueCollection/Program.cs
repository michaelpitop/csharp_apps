using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		// Queue<int> callerIds = new Queue<int>();
		// callerIds.Enqueue(1);
		// callerIds.Enqueue(2);
		// callerIds.Enqueue(3);
		// callerIds.Enqueue(4);

		// foreach(var id in callerIds)
		// 	Console.WriteLine(id);

		Queue<string> strQ = new Queue<string>();
		strQ.Enqueue("H");
		strQ.Enqueue("e");
		strQ.Enqueue("l");
		strQ.Enqueue("l");
		strQ.Enqueue("o");

		Console.WriteLine("\nTotal elements: {0}", strQ.Count);

		while (strQ.Count > 0)
			Console.WriteLine(strQ.Dequeue());

		Console.WriteLine("Total elements: {0}", strQ.Count);

    Queue<int> callerIds = new Queue<int>();
		callerIds.Enqueue(1);
		callerIds.Enqueue(2);
		callerIds.Enqueue(3);
		callerIds.Enqueue(4);

		Console.WriteLine(callerIds.Contains(1));
		Console.WriteLine(callerIds.Contains(2));
    Console.WriteLine(callerIds.Contains(10));


	}
}
