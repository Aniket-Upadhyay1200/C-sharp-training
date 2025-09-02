using System;
using System.Threading.Tasks;
class AsyncProg
{
    public async Task DownloadFile()
    {
        Console.WriteLine("Downloading file...");
        await Task.Delay(5000);
        Console.WriteLine("File downloaded.");


    }
}