# 2. Data types and variables

Variables are nothing more than containers for storing data values. Variables in C# have types describing what kind of data is being stored. In fact, you can create your own variable types but we will get to that later. These are some of the variable types defined in C#:
* `int` - stores integers (whole numbers) i.e.:  1, 2, 3...
* `double` - stores floating point numbers with decimals i.e.:  1.5, 2.317, -17.923...
* `char` - stores single character i.e.: 'a', 'b', 'C', 'Z'...
* `string` - stores text i.e.: "It's a me, Mario!", "Hello, World!"... 
* `bool` - stores value that can be one of two states i.e.: true, false.

You have already used variables in exercise 1.2: 
```csharp
var line = Console.ReadLine();
```
Variable `line` is of type `string`. In fact, you can write it like this:
```csharp
string line = Console.ReadLine();
```
C# automatically resolves types in most of the cases therefore you can use type `var` instead of concrete types (I would argue that you should use `var` whenever possible). Take a look at the following:
```csharp
var myInt = 5; //int
var myDouble = 5.7; //double
var myChar = 'c'; //char
var myString = "Hello there"; //string
var myBool = true; //bool
```
Notice the `=` symbol - as you might have already guessed that is how you assing values to your variables.

All variables in the same scope (for now imagine it as everything between `{}` brackets) must have unique names.

In this chapter you will use variables in a more complicated fashion as well as explore some of the operations that you can do with them.
