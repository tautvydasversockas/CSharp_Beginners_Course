# 4. Methods

A method is nothing more than a code block that contains a series of statements. You can execute these statements by calling the method and specifying any required method arguments. The `Main` method (you should have seen it multiple times while doing your tasks with the console application) is the entry point for every C# application and it's called when the program is started. 

To define your method you have to provide an access modifier, a return type, a method name and parameters (if there are any). To be completely honest, there are a couple of things that are intentionally not mentioned to minimise the complexity. So far the definition of a method seems very vague. Let's try to understand how it works from the examples:
```csharp
public void WriteToConsoleTwice(string text)
{
    Console.WriteLine(text);
    Console.WriteLine(text);
}
```
Method `WriteToConsoleTwice` writes provided text to console two times in separate lines. `public` is an access modifier. There are more access modifiers like `private`, etc. For the most part, we are going to use `public` so for now just remember that there are things called access modifiers and methods have those. `void` is a return type that returns nothing. If your method needs to return something the return type must be the same as the type of the value being returned. `WriteToConsoleTwice` is a method name which can be changed without affecting the method functionality. `text` is a parameter of type `string` that our method needs. We can call `WriteToConsoleTwice` method like this:
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

If your name is "Mr Bond" after calling the method your console should look like this:
```
Good evening Mr Bond, I've been expecting you.
```

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Define a method:
```csharp
public void WriteGreetingToConsole(string name)
{
}
```
### Step 2
Implement the defined method:
```csharp
public void WriteGreetingToConsole(string name)
{
    Console.WriteLine("Good evening " + name + ", I've been expecting you.");
}
```
### Step 3
Call the method to test it. If you want to test it from a console app `Program` class, you must make the method `static`:
```csharp
class Program
{
    static void Main(string[] args)
    {
        WriteGreetingToConsole("Mr Bond");
    }

    public static void WriteGreetingToConsole(string name)
    {
        Console.WriteLine("Good evening " + name + ", I've been expecting you.");
    }
}
```
</p>
</details>

## Exercise 4.2: write a method that that takes 3 numbers as parameters and checks if the sum of the first two numbers is equal to the third number.

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Define a method:
```csharp
public bool CheckSumOfTwoNumbers(int num1, int num2, int sum)
{
}
```
### Step 2
Implement the defined method:
```csharp
public bool CheckSumOfTwoNumbers(int num1, int num2, int sum)
{
    return num1 + num2 == sum;
}
```
### Step 3
Call the method to test it. 
</p>
</details>

## Exercise 4.3: write a method that returns the n-th letter of a given word.

If the word is "pneumonoultramicroscopicsilicovolcanoconiosis" and n is 29 the returned letter should be "c"... or perhaps "o"... I don't know... the word is too long...

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Define a method:
```csharp
public char GetLetter(string word, int n)
{
}
```
### Step 2
Implement the defined method:
```csharp
public char GetLetter(string word, int n)
{
    return word[n];
}
```
### Step 3
Call the method to test it. 
</p>
</details>

## Exercise 4.4: prevent animal additional/removal if the shelter is closed.

We already did an open/closed check on our home page. Now we need the same check in the second place on the animal registration page. We don't want to copy and paste the same code in different places so we will create a method that could be used in both places.

We need to create a class in the `Data` folder (don't worry if you don't know what the class is, we will cover it in later). This class will hold our method. Just create file `ShelterCalendarService.cs` in `Data` folder and paste this code there:

```csharp
using System;

namespace AnimalShelter.Data
{
    public class ShelterCalendarService
    {
        
    }
}
```

This class will hold our method. To use this both in the home and animal registration pages we need to add this code in page files right after the first line:

```cshtml
@using AnimalShelter.Data
@inject ShelterCalendarService CalendarService 
```

Now in `Startup.cs` file in `ConfigureServices` method add this line of code(it's ok not to understand this):

```csharp
services.AddSingleton<ShelterCalendarService>();
```

Now you can access your `ShelterCalendarService` methods through `CalendarService`. Here `ShelterCalendarService` is a type while `CalendarService` is the name of an instance of the type.

Everything is ready to perform the task. Create a method that would tell us if we are open. If we are open it has to return `true` and if we are closed it has to return `false`. Then use this method on the home page to print open/closed text and animal registration page to prevent animal addition/removal in case we are closed.

<details>
<summary>Solution</summary>

### Step 1

Create a `public` method that returns a value of type `bool` in the class we created earlier. You have already created the logic for it in the last lesson:

```csharp
public bool IsShelterOpen()
{
    switch (DateTime.Today.DayOfWeek)
    {
        case (DayOfWeek.Monday):
        case (DayOfWeek.Tuesday):
        case (DayOfWeek.Wednesday):
        case (DayOfWeek.Thursday):
        case (DayOfWeek.Friday):
            if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 17)
                return true;
            else
                return false;
        default:
            return false;
    }
}
```

### Step 2

Rewrite `GetOpenClosedText` method on the home page to use the new method of `ShelterCalendarService`:

```csharp
private string GetOpenClosedText()
{
    if (CalendarService.IsShelterOpen())
        return "open";
    else
        return "closed";
}
```

The code in the home page became very simple. We hid all the logic of checking if we are open in the `IsShelterOpen` method. Now `GetOpenClosedText` method only focuses on returning a text indicating if the shelter is closed or open. The code became easier to read and understand.

### Step 3

Add open/closed check to `AddAnimal` and `RemoveAnimal` methods in the code of animal registration page:

```csharp
private void AddAnimal()
{
    if (CalendarService.IsShelterOpen() && animalCount < AnimalCapacity)
        animalCount++;
}

private void RemoveAnimal()
{
    if (CalendarService.IsShelterOpen() && animalCount > 0)
        animalCount--;
}
```

### Step 4

Run the application.

</details>
