# Uninitialized Property Access in C#

This repository demonstrates a common error in C# programming: accessing a property before it has been initialized.  This can lead to `NullReferenceException` errors if the property is a reference type.

The `bug.cs` file contains the problematic code. The `bugSolution.cs` file shows how to avoid the error.

This issue is important to understand, as it is a frequent cause of runtime exceptions in C# applications.