# 1. Console Application

A console application is a computer program that is designed to be used via text-only computer interface such as text terminal, the command line interface of some operating systems (Unix, DOS, etc.) or the text-based interface, such as Win32 console in Microsoft Windows, Terminal in macOS and xterm in Unix. 

## Overview

In this chapter you will explore a console application written in C#. 

## Exercise 1.1: create a new "Hello World" console application

"Hello World" is nothing more than a computer program that outputs "Hello, World!" to the user. Since it is usually very easy to write it is mostly used to illustrate the basic syntax and working of a programming language.

If you have followed the instructions for [preparing your machine for the course](https://github.com/tautvydasversockas/CSharp_Beginners_Course/blob/master/README.md#preparing-your-machine-for-the-course) you have already created a new "Hello World" console application. 

By now you should see something similar to this:
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
Run the application. You should see *"Hello World and Good Bye!"* in a terminal window.

### Step 1
```csharp 
using System;
```
`using` directive allows the use of types in a namespace (we will get to that later) so that you do not have to qualify the use of a type in that namespace. In this application we need to use `System` namespace since the `Console` part is from `System` namespace. 

Try to remove `using System` line. You will see your compiler "complaining" (word Console marked in red). 

Change from: 
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
to: 
```csharp
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
Run the application. You should see *"Hello World and Good Bye!"* in a terminal window. However it is usually more convenient to keep the `using` lines since by having them you are able to use everything from that namespace (in this exaple it is `System`) without the need of prefixing everything with the name of it.

### Step 2
```csharp 
namespace MyApp 
{
}
```
Namespaces in C# are used in order to organize the source code (like folders in windows in some sense).
```csharp
System.Console.WriteLine("Hello World and Good Bye!");
```
`System` is a namespace and `Console` is a type in that namespace.

Change from: 
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
to: 
```csharp
using System;

namespace MyDifferentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
Run the application. You should see *"Hello World and Good Bye!"* in a terminal window even though you have changed the namespace (a folder name in some sense).

### Step 3
```csharp 
static void Main(string[] args)
{
}
```
`Main` method (for now just remember that it is called a method) is an entry point to the application.

Change from: 
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
to: 
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void MyCustomName(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
Run the application. Instead of *"Hello World and Good Bye!"* in a terminal window you should see an error similar to this *"Program does not contain a static 'Main' method suitable for an entry point"*. 

### Step 4
```csharp 
Console.WriteLine("Hello World and Good Bye!");
```
`Console` is a class (we will get to what a class is later) from `System` namespace that represents the standart input, output and error streams for console applications. `WriteLine` is a method that writes provided text to console.

Change from: 
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and Good Bye!");
        }
    }
}
```
to: 
```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void MyCustomName(string[] args)
        {
            Console.WriteLine("It's a me, Mario!");
        }
    }
}
```
Run the application. You should see *"It's a me, Mario!"* in a terminal window.

## Exercise 1.2: print your input to the console

During this exercise you will print your console input line back to the same console.

### Step 1
Store your console input into variable. For now imagine variables as a way of storing information in your computer memory:
```csharp
static void Main(string[] args)
{
    var line = Console.ReadLine();
    Console.WriteLine("Hello World and Good Bye!");
}
```
You have created a variable `line` that is going to store your console input.

### Step 2
Write your console input back to console:
```csharp
static void Main(string[] args)
{
    var line = Console.ReadLine();
    Console.WriteLine(line);
}
```
### Step 3
Run the application. Enter *"My random text"* (or any other text) into console and press Enter. You should see the same text printed back to you in console.

# Additional exercises

## Exercise 1.3: ask for input and print your input back to the console with "Result: " prefix

Your console should look like this:
```
Please enter text:
Hello!
Result: Hello!
```

## Exercise 1.4: write your text to console in green colour
