using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
	public static async void Method1()
	{
		Task<string> task = Method2();
		Console.WriteLine("Method1 Executed and waiting for Method 2");
		var message = await task;
		Console.WriteLine(message);
	}

	public static async Task<string> Method2()
	{
		await Task.Delay(2000);
		return "Return something from Method 2 to Method 1 after Delay";
	}
	public static void Main()
	{
		Console.WriteLine("Running From Main");
		Method1();
		Console.Read();
	}
}