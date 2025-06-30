# C# Introductory Guide

This repository exists to provide a step-by-step guide to learning C#/.NET. 
In the solution, you will find multiple projects that each target a specific aspect of writing code in C#/.NET
Each project also contains unit testing to ensure your implementations work as expected.

To get started, fork the repository and open it in your IDE of choice.
Choose which project you would like to start working with 
(For new C#/.NET developers, it is recommended to start with Beginner.1-Program-Layout)
and solve the first projects.

The projects are ordered in number, and an understanding of each project is expected as a foundation
before moving on to the next. 
For experiences programmers new to C#/.NET, it is recommended to still start with the beginner series of projects
to understand how C#/.NET handles concepts you may already be familiar with.

Guides for how to complete each project are included in Markdown (.md) files within each project.
They will not solve the projects for you, but they will give you an understanding of the concepts required to solve
each project, 
as well as links to additional documentation where you can learn more about each concept if you are still struggling.

If you are still struggling with a given concept, solutions for each project are provided in the
[solutions branch](https://github.com/AKonicki26/CSharp-Intro-Guide/tree/solutions) of the repository.
This can be used to see how each project is supposed to work to reference during your own learning.

## Testing
To test a project, open a terminal to the repository root. 
Then, to test whichever project you are currently working on, run the command 
`dotnet test Tests/[project name].Tests`, replacing [project name] for the name of the project you wish to test.

For example, if you want to test `Beginner.1-Project-Layout`, enter the command 
`dotnet test Tests/Beginner.1-Project-Layout.Tests`.

The test suite is set up to ensure your code functions as expected, without needing to match the solutions line by line.
Error messages will also appear to describe the reasons the tests do not pass with your code.
