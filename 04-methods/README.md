# 4. Methods

A method is nothing more than a code block that contains a series of statements. You can execute these statements by calling the method and specifying any required method arguments. The `Main` method (you should have seen it multiple times while doing your tasks with the console application) is the entry point for every C# application and it's called when the program is started. 

In order to define your own method you have to provide an access modifier, a return type, a method name and parameters (if there are any). To be completely honest, there are a couple of things that are intentionally not mentioned to minimise the complexity. So far the definition of a method seems very vague. Let's try to understand how it works from the examples:
```csharp
public void WriteToConsoleTwice(string text)
{
    Console.WriteLine(text);
    Console.WriteLine(text);
}
```
Method `WriteToConsoleTwice` writes provided text to console two times in separate lines. `public` is an access modifier. There are more access modifiers like `private`, etc. For the most part we are going to use `public` so for now just remember that there are things called access modifiers and methods have those. `void` is a return type that returns nothing. If your method needs to return something the return type must be the same as the type of the value being returned. `WriteToConsoleTwice` is a method name which can be changed without affecting the method functionality. `text` is a parameter of type `string` that our method needs. We can call `WriteToConsoleTwice` method like this:
```csharp
WriteToConsoleTwice("Hello World!");
```
Let's try to write another method with a different return type:
```csharp
public int Multiply(int num1, int num2)
{
    return num1 * num2;
}
```
Method `Multiply` returns an `int` type number which is calculated by multiplying two `int` type parameters `num1` and `num2`. We can call `Multiply` method like this:
```csharp
var multiplied = Multiply(5, 2);
```
See? We are getting good at this!

## Exercise 4.1: write a method that takes a name as a parameter and writes a personalized greeting message to the console.

If your name is "mr. Bond" after calling the method your console should look like this:
```
Good evening mr. Bond, I've been expecting you.
```
## Exercise 4.2: write a method that that takes 3 numbers as parameters and checks if the sum of the first two numbers is equal to the third number.

## Exercise 4.3: write a method that returns the n-th letter of a given word.

If the word is "pneumonoultramicroscopicsilicovolcanoconiosis" and n is 29 the returned letter should be "c"... or perhaps "o"... I don't know... the word is too long...
