# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been explicitly assigned a value.  Uninitialized properties will have default values (0 for integers, null for reference types, etc.), which may or may not be what your code expects, leading to unexpected behavior or runtime errors.

The `bug.cs` file contains the erroneous code. The `bugSolution.cs` file shows the corrected version. 

## How to Reproduce

1. Clone this repository.
2. Compile and run the `bug.cs` file. Note the output (which will be 0 for MyProperty).
3. Compile and run `bugSolution.cs` file. Note how explicitly initializing the property fixes the potential issue.

## Learning Points

- Always initialize properties, especially if their initial value affects your application's logic.
- Be mindful of default values and ensure they meet your requirements.
- Use a debugger or static analysis tools to identify potential uninitialized variable/property issues early in the development process.

This simple example highlights the importance of defensive programming practices in C# and other languages.