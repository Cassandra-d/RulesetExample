using System;
using System.Threading.Tasks;

namespace CLI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dispossable = new System.IO.StreamWriter("file.txt", append: true);
            await dispossable.WriteLineAsync();
        }
    }
}
