using System.Reflection;

namespace Beginner.Program_Layout.Tests;

public class ProgramLayoutTests
{

    [Test]
    public void ClassProgramTests()
    {
        string assemblyPath = "Beginner.1-Program-Layout.dll";
        string className = "Beginner.Program_Layout.Program";
        string methodName = "Main";
        
        Assembly assembly = Assembly.LoadFrom(assemblyPath);
        
        Type? programType = assembly.GetType(className);
        
        Assert.IsNotNull(programType, $"{className} must exist in your program!");
        Assert.IsTrue(programType.IsPublic, $"Class {className} must be public!");

        var methods = programType.GetMethod(methodName);
        
        Assert.IsNotNull(methods, $"{methodName} must be defined in {className}!");
        Assert.IsTrue(methods.IsPublic, $"{className}.{methodName} must be public!");
        Assert.IsTrue(methods.IsStatic, $"{className}.{methodName} must be static!");
    }
}