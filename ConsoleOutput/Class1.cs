// Class Written by Vasil Trifonov
// https://www.codeproject.com/Articles/501610/Getting-Console-Output-Within-A-Unit-Test

namespace ConsoleOutput;

public class ConsoleOutputCatcher : IDisposable
{
    private StringWriter stringWriter;
    private TextWriter originalOutput;

    public ConsoleOutputCatcher()
    {
        stringWriter = new StringWriter();
        originalOutput = Console.Out;
        Console.SetOut(stringWriter);
    }

    public override string ToString()
    {
        return stringWriter.ToString();
    }

    public void Dispose()
    {
        Console.SetOut(originalOutput);
        stringWriter.Dispose();
    }
}
