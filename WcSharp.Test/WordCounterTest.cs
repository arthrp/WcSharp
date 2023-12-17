namespace WcSharp.Test;

public class WordCounterTest
{
    [Fact]
    public void WordCounter_ReturnsCorrectCountOfBytes()
    {
        var bytes = File.ReadAllBytes("hello.txt");
        var wc = new WordCounter();

        var str = wc.Run(bytes, true, false, false);
        Assert.Equal("6 ", str);
    }
}