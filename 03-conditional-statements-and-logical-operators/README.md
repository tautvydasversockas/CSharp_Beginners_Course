# 3. Conditional statements and logical operators

C# has a lot of different operators: comparison, equality, logical, etc. Don't stop reading if you don't know what an operator is because it is pretty self-explanatory. The only thing you have to remember is that to understand operators you have to understand `bool` types (see chapter 2). Following operators are arguably the most common ones:
* `==` (EQUAL) - returns  `true` if both sides are equal i.e. 1 == 2 returns `false`, 2 == 2 returns `true`...
* `!=` (NOT EQUAL) - returns  `true` if both sides are not equal i.e. 1 != 2 returns `true`, 2 != 2 returns `false`...
* `>` (GREATER) and `<` (LOWER) - returns  `true` if one of the sides is greater (or lower) than the other i.e. 1 > 2 returns `false`, 3 > 2 returns `true`...
* `>=` (GREATER OR EQUAL) and `<=` (LOWER OR EQUAL) - returns  `true` if one of the sides is greater or equal (or lower or equal) than the other i.e. 1 >= 2 returns `false`, 2 >= 2 returns `true`...
* `&&` (AND) - returns  `true` if both of the sides are equal to `true` i.e. `true` && `false` returns `false`, `false` && `false` returns `false`, `true` && `true` returns `true`...
* `||` (OR) - returns  `true` if at least one of the sides is equal to `true` i.e. `true` || `false` returns `true`, `false` || `false` returns `false`, `true` || `true` returns `true`...

Keep in mind that you can use those operators with variables:
```csharp
var givenName = Console.ReadLine();
var myName = "John";
var isGivenMyName = givenName == myName;
```

To make matters more interesting C# has conditional `if-else` statement which can be combined with operators:
```csharp
var givenName = Console.ReadLine();
var myName = "John";

if (givenName == myName) 
{
  Console.WriteLine("It is my name!");
}
else
{
  Console.WriteLine("It is not my name!");
}
```
If the statement passed to `if` is `true` (in this case if given name is equal to my name) then the first block of code is going to be executed (we would see "It is my name!" in the console), otherwise execution starts with `else` block (we would see "It is not my name!" in the console).

Now imagine if we had to compare a lot of names and depending on the name do different things. C# has us covered with `switch` statement which is nothing more than fancy alternative to `if-else`:
```csharp
var givenName = Console.ReadLine();

switch (givenName)
{
  case "John":
    Console.WriteLine("Hello, Johny!");
    break;
    
  case "Tim":
    Console.WriteLine("Greetings, Tim!");
    break;
    
  default:
    Console.WriteLine("Welcome, stranger!");
    break;
}
```
Here's how it would look like with `if-else`:
```csharp
var givenName = Console.ReadLine();

if (givenName == "John")
{
  Console.WriteLine("Hello, Johny!");
}
else if (givenName == "Tim")
{
  Console.WriteLine("Greetings, Tim!");
}
else
{
  Console.WriteLine("Welcome, stranger!");
}
```

## Exercise 3.1: create an application that reads an integer number from the console and writes back to the console if it is greater or equal to 5.

Your console should look like this if the number is lower than 5:
```
Please enter number:
4
The number is lower than 5.
```
and like this if the number is greater or equal to 5:
```
Please enter number:
6
The number is greater or equal to 5.
```

## Exercise 3.2: create an application that reads a name and age from the console and writes back if the name and age is the same as yours.

If your name is "Jonh", your age is 19 and given values are the same your console should look like this:
```
Please enter your name:
John
Please enter your age:
19
Wow, you are like me!
```
and if the given values are different:
```
Please enter your name:
Tim
Please enter your age:
19
You are completely different than me!
```
