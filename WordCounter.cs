using System.Text;
using System.Text.RegularExpressions;

namespace WcSharp;

public class WordCounter
{
    public string Run(byte[] content, bool countBytes, bool countLines, bool countWords)
    {
        var sb = new StringBuilder();
        if (countBytes) sb.Append(content.Length + " ");
        
        var text = Encoding.UTF8.GetString(content);
        
        var wasSpace = false;
        var wordCount = 0;
        var lineCount = 0;
        var spaceRegex = new Regex("\\s", RegexOptions.Compiled);
        
        foreach (var c in text)
        {
            if (countLines && c == '\n') lineCount++;
            if(!countWords) continue;
            
            var isSpace = spaceRegex.IsMatch(c.ToString());
            if (isSpace && !wasSpace) wordCount++;

            wasSpace = isSpace;
        }

        if (countLines) sb.Append(lineCount + " ");
        if (countWords) sb.Append(wordCount + " ");
        return sb.ToString();
    }
}