using System.Text;
using CommandLine;

namespace WcSharp;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(Run);
    }

    private static void Run(Options o)
    {
        var sb = new StringBuilder();
        var content = File.ReadAllBytes(o.FileName);

        var text = new WordCounter().Run(content, o.CountBytes, o.CountLines, o.CountWords);
        sb.Append(text);

        sb.Append(o.FileName);
        Console.WriteLine(sb.ToString());
    }
}
