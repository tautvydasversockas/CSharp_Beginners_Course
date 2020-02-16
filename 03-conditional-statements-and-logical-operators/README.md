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

## Exercise 3.1: create an application that reads an integer number from the console and writes to the console if the number is lower or greater or equal to 5.

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
<details>
<summary>Solution</summary>
<p>
    
### Step 1
Read an integer from the console:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter number:");
    var number = int.Parse(Console.ReadLine());
}
```
### Step 2
Write `if-else` statement to check if the number is lower or greater or equal to 5:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter number:");
    var number = int.Parse(Console.ReadLine());
    
    if (number < 5)
        Console.WriteLine("The number is lower than 5.");
    else
        Console.WriteLine("The number is greater or equal to 5.");
}
```
### Step 3
Run the application.

</p>
</details>

## Exercise 3.2: create an application that reads a name and an age from the console and writes if the name and age are the same as yours.

If your name is "Jonh", your age is 19 and given values are the same your console should look like this:
```
Please enter your name:
John
Please enter your age:
19
Wow, you are me!
```
and if the given values are different:
```
Please enter your name:
Tim
Please enter your age:
19
You are not me!
```

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Define your age and name:
```csharp
static void Main(string[] args)
{
    var myName = "John";
    var myAge = 19;
}
```
### Step 2
Read a name and an age from the console:
```csharp
static void Main(string[] args)
{
    var myName = "John";
    var myAge = 19;
    
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    
    Console.WriteLine("Please enter your age:");
    var age = int.Parse(Console.ReadLine());
}
```
### Step 3
Write `if-else` statement using `AND` operator to check if provided name and age are the same as yours:
```csharp
static void Main(string[] args)
{
    var myName = "John";
    var myAge = 19;
    
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    
    Console.WriteLine("Please enter your age:");
    var age = int.Parse(Console.ReadLine());
    
    if (name == myName && age == myAge)
        Console.WriteLine("Wow, you are me!");
    else
        Console.WriteLine("You are not me!");
}
```
### Step 4
Run the application.

</p>
</details>

## Exercise 3.3: create an application that reads a country name and an age from the console and writes to the console if it's legal to drink beer in that country at that age. 
In Lithuania the legal drinking age is 20. In Denmark the legal drinking age is 16. If provided country is not Lithuania or Denmark your application should write that the legal drinking age is unknown. Use `switch` statement.

If provided country is Lithuania and provided age is greater or equal to 20 your console should look like this:
```
Please enter a country name:
Lithuania
Please enter your age:
20
You can legally drink beer.
```

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Read a country name and an age from the console:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter a country name:");
    var country = Console.ReadLine();
    
    Console.WriteLine("Please enter your age:");
    var age = int.Parse(Console.ReadLine());
}
```
### Step 2
Write a `switch` statement and combine it with `if-else` to check the legal drinking age:
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Please enter a country name:");
    var country = Console.ReadLine();
    
    Console.WriteLine("Please enter your age:");
    var age = int.Parse(Console.ReadLine());
    
    switch (country)
    {
        case "Lithuania":
            if (age >= 20)
                Console.WriteLine("You can legally drink beer.");
            else
                Console.WriteLine("You can't legally drink beer.");
            break;

        case "Denmark":
            if (age >= 16)
                Console.WriteLine("You can legally drink beer.");
            else
                Console.WriteLine("You can't legally drink beer.");
            break;

        default:
            Console.WriteLine("The legal drinking age is unknown.");
            break;
    }
}
```
### Step 3
Run the application.

</p>
</details>

## Exercise 3.4: prevent animal removal when there are no animals and animal addition when there are 20 animals already added.

<details>
<summary>Solution</summary>

### Step 1

Add a constant variable to hold animal capacity:

```csharp
@code {
    private const int AnimalCapacity = 20;

    ......
}
```

We will use this variable for validating our animal count.
Constant variables (with `const` keyword) are variables that don't change.

### Step 2

Add `if` statement to `AddAnimal` method:

```csharp
private void AddAnimal()
{
    if (animalCount < AnimalCapacity)
    {
        animalCount++;
    }
}
```

### Step 3

Add `if` statement to `RemoveAnimal` method:

```csharp
private void RemoveAnimal()
{
    if (animalCount > 0)
    {
        animalCount--;
    }
}
```

### Step 4

Run the application.

</details>

## Exercise 3.5: display "no animals" when there are no animals and "20 (full capacity)" when we reach 20 animals in the shelter.

If there are no animals your page should look like this:

```
At 2020-02-09 we have no animals
```

If there are 20 animals your page should look like this:

```
At 2020-02-09 we have 20 (full capacity) animals
```

Otherwise it should stay the same as it was before:

```
At 2020-02-09 we have 5 animals`
```

<details>
<summary>Solution</summary>

### Step 1
Define a method that would return string representation of animal count:

```csharp
private string GetAnimalCountText()
{
    
}
```

Call this method:

```cshtml
<p>At @DateTime.Today.ToShortDateString() we have @GetAnimalCountText() animals.</p>
```

### Step 2
Add `if` statement to the method and handle the case when there are no animals:

```csharp
private string GetAnimalCountText()
{
    if (animalCount == 0)
    {
        return "no";
    }
}
```

### Step 3

Add `else if` part to handle the full capacity case:

```csharp
private string GetAnimalCountText()
{
    if (animalCount == 0)
    {
        return "no";
    }
    else if (animalCount == AnimalCapacity)
    {
        return animalCount + " (full capacity)";
    }
}
```

### Step 4

Add `else` part to handle other cases.

```csharp
private string GetAnimalCountText()
{
    if (animalCount == 0)
    {
        return "no";
    }
    else if (animalCount == AnimalCapacity)
    {
        return animalCount + " (full capacity)";
    }
    else
    {
        return animalCount.ToString();
    }
}
```

### Step 5

Run the application.
</details>

## Exercise 3.6: add business hours to your home page and display "We are open" if we are open now and "We are closed" otherwise.

Your page should look like this:

```
We are open every workday from 8:00 - 17:00

We are closed.
```

<details>
<summary>Solution</summary>

### Step 1

Add the following text to the `Index.razor` file:

```cshtml
<p>We are open every workday from 8:00 - 17:00</p>

<p>We are .</p>
```

Text that we put between `<p>` and `</p>` will be shown in a separate paragraph.

Note that we left space empty where `open` or `closed` should be displayed. We will get back to this in a few steps when we have everything ready.

### Step 2

Add a code block to the page. This is where we will write our logic.

```cshtml
@code {

}
```

We have the same block in our animal registration page. There we've defined the logic for animal addition and removal.

### Step 3

Add a method `GetOpenClosedText` to the code block. This will return us a string "open" or "closed".

```cshtml
private string GetOpenClosedText()
{

}
```

### Step 4

Add logic checking working days:

```cshtml
private string GetOpenClosedText()
{
    switch(DateTime.Today.DayOfWeek)
    {
        case(DayOfWeek.Monday):
        case(DayOfWeek.Tuesday):
        case(DayOfWeek.Wednesday):
        case(DayOfWeek.Thursday):
        case(DayOfWeek.Friday):
            return "open";
        default:
            return "closed";
        }
    }
```

Here we use type `DateTime` from it we access `Today` and then `DayOfWeek`.

Then we use switch statement to split the logic. Return "open" for Monday, Tuesday, Wednesday, Thursday and Friday. In other cases (Saturday and Sunday) return "closed".

### Step 5

Add logic checking business hours:

```cshtml
private string GetOpenClosedText()
{
    switch(DateTime.Today.DayOfWeek)
    {
        case(DayOfWeek.Monday):
        case(DayOfWeek.Tuesday):
        case(DayOfWeek.Wednesday):
        case(DayOfWeek.Thursday):
        case(DayOfWeek.Friday):
            if(DateTime.Now.Hour > 8 && DateTime.Now.Hour < 17)
            {
                return "open";
            }
            else
            {
                return "closed";
            }
        default:
            return "closed";
    }
}
```

We add if statement to check if we are in business hours. Here `DateTime` type is used. This time we access `Now` because `Today` contains only date without time.

Notice that we did not use `break`. If we return and do nothing else then `break` is not needed.

### Step 6

Add a method call to the `GetOpenClosedText` from the text in our page.

```cshtml
<p>We are @GetOpenClosedText() right now.</p>
```

### Step 7

Run the application. Play around with the code by changing the business hours to see if you can get both `open` and `closed` options.

</details>