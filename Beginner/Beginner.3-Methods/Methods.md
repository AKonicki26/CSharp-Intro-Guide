# Methods
Methods can be thought of as sections of code that exist under a name, which can then be called through its name.
If you have a section of code you want to be able to re-use multiple times, it's best to move the code to a new
method and call it when needed than to copy and paste the chunk of code multiple times.

You've actually been using two methods already throughout this tutorial, `Main` and `Console.WriteLine`!
`Main` is the method that get called when our program starts, 
and `Console.WriteLine` is used to output text to the console!

But what if we want to create our own methods to call our code? Well, we can do that!

## Parts of a Method
There are two different parts of a method, the **Method Signature** and the **Method Body**.
Every method MUST have both a signature and a body to be complete.

### Method Signature
A method signature defines how the method exists. It is composed of several parts, 
however we will not change any besides the name for the time being.

| Syntax         | Meaning                                                                                                                 |
|----------------|-------------------------------------------------------------------------------------------------------------------------|
| Modifiers      | Modifiers that specify who can and cannot call the method. We will only use `public` for now                            |
| Return Type    | The data type of a value that the method will return. `void` means the method will not return anything.                 |
| **Name**       | The name of the method to be used when calling it                                                                       |
| **Parameters** | Optional data to be used within the function body. If parameters are defined, they must be used when calling the method |

Our Main Method's signature is `public static void Main()`. `public static` are the method's modifiers, 
`void` is the return type, `Main` is the method's name, and there are no parameters.

### Method Body 
A method body defines what the method actually does. 
The method body is the actual code that is run when the method is called.
Any variables created in a method body cannot be accessed outside the method, 
however variables from a larger scope than the method can be accessed  

## Creating your own method
Take the **Method Signature** we used for the Main Method, `public static void Main()` and copy it elsewhere in our
`Program` class. Then, change the name Main for whatever you'd like.
You want the name of the method to be relevant to what it performs. 

For this tutorial, we'll have a method we make print the value of the variable `OurVariable` defined in the `Program` class.
Within the **method body**, print the value of `OurVariable` by passing it into the `Console.WriteLine` function
just as we've done before.

To call our new method, type the name of the method followed by empty parenthesis inside the main method body.
So, if you named your method `MyMethod()`, your main function would look like the following:

```cs
public static void Main() 
{
    MyMethod();
}
```

If you've follow the steps up until here, you should be able to run the program and see the output in the console!

## Methods with Parameters
Method signatures can have special **parameters** to pass information into them as **arguments**.
When defining parameters, you must specify the type of the parameter and the name to call it, 
exactly like defining a variable. Then, when calling the method, values are passed into the method as arguments
to be used within the method body.

You've actually already been using a method with arguments, `Console.WriteLine`! 
When you call Console.WriteLine, you pass in the value you want to be written to the console inside the parenthesis!

This is also where we define parameters in our **Method Signature**, so it's very easy to know what to pass to a method 
when using them!

Let's create a new function that will take in two numbers, and print the result of their addition.
For now, use the same base method signature as our other two methods, changing the name to something relevant.

Then, inside the parenthesis, we'll want to add two `int` parameters. 
This can be done by declaring two comma seperated integer variables inside the parenthesis of the method signature, 
such as the following:

```csharp
public static void Sum(int numberOne, int numberTwo) 
{
    
}
```

Then, inside the method body, we can use these variables and add them together!
Try calling this method from inside the main method, passing in two numbers of your choosing.

## Return types
Often times, we will want to use methods to get new information from the work we did inside the method body.
For this, we can use a **return value**.
The `return` keyword specifies two things:
1. Whatever value follows the `return` keyword will be sent out of the method to where it was called
2. The method body will not continue after `return` has been used.

So, rather than directly output the console, why don't we return the result of our addition?
We can change the method signature of our adding method to change the return type from `void` to `int`, 
since the result of adding two integers will always be an integer.

Then, instead of printing our addition directly to the console, we can return the result!
We are then able to take the value from this method and assign it to a variable directly, such as the following:
```csharp
int newNumber = Sum(5, 6);
```

And, if we then ran
```csharp
Console.WriteLine(newNumber);
```

we should see that 11 gets printing to the Console!




