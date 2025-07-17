using System.Diagnostics;
using System.Reflection;
using ConsoleOutput;

namespace Beginner.Methods.Tests;

[TestFixture]
public class Tests
{
    private MethodInfo[] _createdMethods;

    [OneTimeSetUp]
    public void Setup()
    {
        List<string> defaultMethodNames = new()
        {
            "Main",
            "GetType",
            "ToString",
            "Equals",
            "GetHashCode",
        };
        string assemblyPath = "Beginner.3-Methods.dll";
        string className = "Beginner.Methods.Program";

        var assembly = Assembly.LoadFrom(assemblyPath);
        var programType = assembly.GetType(className);

        if (programType == null)
            throw new Exception($"{className} must exist in your program!");

        if (!programType.IsPublic)
            throw new Exception($"Class {className} must be public!");

        var methods = programType.GetMethods();

        if (methods.Length == 0)
            throw new Exception($"Class {className} must have a Main method!");

        foreach (var method in methods)
            Trace.WriteLine(method.Name);

        _createdMethods = methods
            .Where(method => !defaultMethodNames.Contains(method.Name))
            .ToArray();

        if (_createdMethods.Length == 0)
            throw new Exception($"You must create your own methods in {className}!");
    }

    [Test]
    [TestCase("Hello")]
    [TestCase("World")]
    [TestCase("Hello World!")]
    // Change the variable in the class that is called for output
    // check against console output for the value of the variable
    public void Program_CreatedMethod_CustomOutput(string input)
    {
        using var consoleOutput = new ConsoleOutputCatcher();
        Program.OurVariable = input;
        foreach (var method in _createdMethods)
            method.Invoke(null, null);

        StringAssert.Contains(input, consoleOutput.ToString());
    }

    [Test]
    [TestCase("Hello")]
    [TestCase("World")]
    [TestCase("Hello World!")]
    // Change the variable in the class that is called for output
    // check against console output for the value of the variable
    public void Program_MainMethod_CreatedMethodCalled_CustomOutput(string input)
    {
        using var consoleOutput = new ConsoleOutputCatcher();
        Program.Main();

        StringAssert.Contains(input, consoleOutput.ToString());
    }
}
