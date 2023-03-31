// C# program to illustrate the
// concept of object array
using System;

class GFG {

	// Main method
	static public void Main()
	{

		// Creating and initializing
		// object array
		object[] arr = new object[] { "Test", "Test2", "Test3", "Test4" };

		// arr[0] = 3.899;
		// arr[1] = 3;
		// arr[2] = 'g';
		// arr[3] = "Greeks";

		// it will display
		// nothing in output
		// arr[4] = null;

		// it will show System.Object
		// in output
		// arr[5] = new object();

		// Display the element of
		// an object array
		foreach(var item in arr)
		{
			Console.WriteLine(item);
		}
	}
}
