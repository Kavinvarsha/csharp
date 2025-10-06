using System;
using System.Threading.Tasks;

class Program
{
	static async Task<string> FetchDataAsync()
	{
		Console.WriteLine("Fetching data, please wait...");
		await Task.Delay(3000);
		return "Data fetched successfully!";
	}

	static async Task Main()
	{
		Console.WriteLine("Program started");
		string result = await FetchDataAsync();
		Console.WriteLine(result);
		Console.WriteLine("Program ended");
	}
}
