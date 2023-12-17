using CommandLine;

namespace WcSharp;

public record Options
{
    [Option('c', HelpText = "Print the number of bytes in file")]
    public bool CountBytes { get; init; }
    
    [Option('l', HelpText = "Print line count in the file")]
    public bool CountLines { get; init; }
    
    [Option('w', HelpText = "Print word count in file")]
    public bool CountWords { get; init; }
    
    [Value(0)]
    public string FileName { get; init; }
}