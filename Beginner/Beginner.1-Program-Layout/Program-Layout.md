# Program Layout
This file will take you through the basics of the program layout of C#.
Each program created after this will follow this same basic structure.

## Namespace
Firstly, we need what is called a **Namespace**.
Namespaces are containers for your code. All code *must* be inside a namespace.
This is done to allow some sections of code to reference other sections of code through what are known as 
`using` directives. 

As a general rule, namespaces are named after the folder that contains them. 
Using this rule, we can start by giving our `Program.cs` file a namespace.
To add a namespace, we use the `namespace` keyword followed by the name of the namespace we want to use.

Since our folder contains special characters, we'll need to replace them with characters that can be in a namespace.
In `Program.cs`, set the namespace of the file to `Beginner.Program_Layout`.

> Note: Namespaces can either have their own scope, or be file-scoped. 
> File-scoping a namespace is preferred unless manual-scoping is required.
> To make a namespace file-scoped, add a semicolon `;` after the name of the namespace.
> To manual-scope a namespace, use curly braces `{ }`. All code inside the curly braces will be inside the namespace.

Now, your `Program.cs` file should look like this:

```csharp
namespace Beginner.Program_Layout;
```

## Program Class
C#/.NET is an **Object-Oriented Programming Language**. This means that code for C# belongs in what are called **objects**.
Objects are a more advanced topic than we will cover right now, so we will set up our first object, 
and learn more about how objects exist and interact with one another later.

In the namespace created earlier, we're going to create an object called `Program` to match the name of our file.
After declaring a file-scoped namespace, enter the line 

`public class Program` 

and add a `{` on the next line, with a `}` on the line after.

This Program class will serve as a container for all data relating to our program. 
For now however, we have no data.

Now, your `Program.cs` file should look like one of the following:

```csharp
namespace Beginner.Program_Layout;

public class Program 
{
    
}
```

## Main Method
Now, we need a place for our code to start its execution from. This is called the **Entry Point** of the program,
and is sometimes referred to as the **Main Method**. 
To create our programs entry point, enter the following line in between the curly braces `{ }` of the Program class:

`public static void Main()` 

and follow with another set of curly braces.

Now, your `Program.cs` file should look like one of the following:

```csharp
namespace Beginner.Program_Layout;

public class Program 
{
    public static void Main() 
    {
        
    }
}
```

There are a lot of words here that are confusing, and that's okay! 
By now, you're not supposed to know what public, class, static, or void mean. 
We'll get to each of those in the next few projects.

But, now our program is runnable! In your IDE, set the startup project to Beginner.1-Program-Layout and run the program.

But... nothing happened? That's right, because we haven't entered anything in our code yet!

## Writing code
Now we're set to start writing code in our Main method! To print to the console, we want to call 
`Console.WriteLine();`
Then, inside of those parenthesis, we can enter what we want to print between two quotation marks `"`.
To start, enter `Console.WriteLine("Hello World!");`

in the main method.

When done, your code should look like the following:

```csharp
namespace Beginner.Program_Layout;

public class Program 
{
    public static void Main() 
    {
        Console.WriteLine("Hello World!");
    }
}
```

Now if you run the program again, you should see this print out the console! 
Congratulations, you've officially written what may be your first program in C#/.NET!

Next, we'll look at variables and how we can store information. 