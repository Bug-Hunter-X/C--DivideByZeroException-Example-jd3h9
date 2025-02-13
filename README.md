# C# DivideByZeroException Example

This repository demonstrates a common runtime error in C#: the `DivideByZeroException`.  The `bug.cs` file contains code that attempts to divide by zero, resulting in a crash.  The `bugSolution.cs` file provides a solution to handle this exception gracefully.

## Bug

The `bug.cs` file contains a simple class with a method that attempts to divide an integer by zero. This will inevitably cause a `DivideByZeroException`, leading to program termination.

## Solution

The `bugSolution.cs` file shows how to use a `try-catch` block to handle the exception.  This prevents the program from crashing and allows for alternative actions to be taken (such as logging an error, displaying a user-friendly message, or using a default value).