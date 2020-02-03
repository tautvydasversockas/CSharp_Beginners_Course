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
Notice the `=` symbol - as you might have already guessed that is how you assign values to your variables.

All variables in the same scope (for now imagine it as everything between `{}` brackets) must have unique names.

In this chapter you will use variables in a more complicated fashion as well as explore some of the operations that you can do with them.

## Exercise 2.1: create an application that writes your name and age to the console. Both your name and age should be stored in variables. 

Your console should look like this:
```
John: 19
```
### Step 1
Store your name and age into a separate variables:
```csharp
static void Main(string[] args)
{
    var name = "John";
    var age = 19;
}
```
Even though they are of different types (`string` and `int`) you can and probably should use type `var` in most of the cases.
### Step 2
Combine your name and age into a separate variable:
```csharp
static void Main(string[] args)
{
    var name = "John";
    var age = 19;
    var nameAndAge = name + ": " + age;
}
```
### Step 3
Write your name and age combination to the console:
```csharp
static void Main(string[] args)
{
    var name = "John";
    var age = 19;
    var nameAndAge = name + ": " + age;
    Console.WriteLine(nameAngAge);
}
```
### Step 4
Run the application. You should see your name and age in the console.

## Exercise 2.2: create an application that reads two integer numbers from the console, multiplies them with each other and writes the result back to the console.

Your console should look like this:
```
Please enter first number:
4
Please enter second number:
5
Result: 20
```
### Step 1
Read both numbers from the console:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter first number:");
    var number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number:");
    var number2 = int.Parse(Console.ReadLine());
}
```
Notice the `int.Parse()` method - it is called parsing. `Console.ReadLine()` method returns result of type `string`. In order to use multiplication we need both of those numbers to be of type `int`. Since we know that we are only going to enter integer numbers we can try to tell the application to transform `string` to `int` by using parsing method - `int.Parse()`. Keep in mind that if your line is not an `int` number your application will crash.
### Step 2
Multiply your numbers and store the result into a separate variable:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter first number:");
    var number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number:");
    var number2 = int.Parse(Console.ReadLine());
    var result = number1 * number2;
}
```
### Step 3
Write the multiplication result to the console:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter first number:");
    var number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number:");
    var number2 = int.Parse(Console.ReadLine());
    var result = number1 * number2;
    Console.WriteLine("Result: " + result);
}
```
### Step 4
Run the application. You should see the console application multiplying your provided numbers.

## Exercise 2.3: create an application that reads a word from the console and writes back the 2nd letter back to the console. For now provide words only longer than 2 letters.

Your console should look like this:
```
YourWord
o
```
### Step 1
Read the word from the console:
```csharp
static void Main(string[] args)
{
    var word = Console.ReadLine();
}
```
### Step 2
Place the second letter into a separate variable:
```csharp
static void Main(string[] args)
{
    var word = Console.ReadLine();
    var letter = word[1];
}
```
You can access letters from text by using `text[place - 1]` syntax. In this example the second letter place is 2 therefore we access it by using `word[2 - 1]` which is equal to `word[1]`. We can do that because text is of type `string` and type `string` is an `array` of type `char` (letters) but let's leave `array` for the future reference.
### Step 3
Write the letter to the console:
```csharp
static void Main(string[] args)
{
    var word = Console.ReadLine();
    var letter = word[1];
    Console.WriteLine(letter);
}
```
### Step 4
Run the application. You should see a second letter of your given word written back to the console.
