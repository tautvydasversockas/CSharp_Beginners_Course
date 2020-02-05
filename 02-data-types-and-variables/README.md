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
<details>
<summary>Solution</summary>
<p>
    
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

</p>
</details>

## Exercise 2.2: create an application that reads two integer numbers from the console, multiplies them with each other and writes the result back to the console.

Your console should look like this:
```
Please enter first number:
4
Please enter second number:
5
Result: 20
```
<details>
<summary>Solution</summary>
<p>
    
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

</p>
</details>

## Exercise 2.3: create an application that reads a word from the console and writes back the 2nd letter back to the console. For now provide words only longer than 2 letters.

Your console should look like this:
```
YourWord
o
```
<details>
<summary>Solution</summary>
<p>
    
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

</p>
</details>

## Exercise 2.4: create an empty Blazor web application for animal shelter project.

During the course you will be building an animal shelter web application.

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Open the terminal and browse to your workspace directory by executing the following commands:
```
$ mkdir C:/AnimalShelter; cd C:/AnimalShelter
```
`mkdir` is used to create a folder while `cd` is used to browse to the folder.
### Step 2
Type the following command to create a default Blazor web application:
```
$ dotnet new blazor
```
### Step 3
Open the application in Visual Studio Code:
```
$ code .
```
### Step 4
Select debug tab of Visual Studio Code and click `Start Debugging` or click `F5`. You should see the application opened in your web browser. Feel free to explore it by clicking different tabs, buttons. Congratulations - you have just created your first web application.

</p>
</details>

## Exercise 2.5: update home page text for it to be more "animal shelter like"

<details>
<summary>Solution</summary>
<p>

### Step 1
Update `Index.razor` file in folder `Pages`:

```cshtml
@page "/"

<h1>Welcome to our animal shelter page!</h1>

Here you can adopt your future pet.

```

`Index.razor` is the file that represents our home page.

</p>
</details>

## Exercise 2.6: make animal registration page

Use `Counter` page as a base for the task.

Rename menu item `Counter` to `Animal Registration`.

Rename `Click me` to `Add animal`, add button `Remove animal` and implemet the logic behind it. `Remove Animal` should decrement our animal count. 

Please make sure that methods (a code block that contains a series of statements), variables and files themselves are named properly and their names represent their purpose.

Instead of `Current count:` display `Currently we have *animal number goes here* animals`

<details>
<summary>Solution</summary>
<p>

### Step 1
Change text `Counter` to `Animal Registration` in `NavMenu.razor` file under `Shared` folder:

```html
...
<span class="oi oi-plus" aria-hidden="true"></span> Animal Registration

...
```
`NavMenu.razor` file represents our menu.

### Step 2
Rename file `Counter.razor` to `AnimalRegistration.razor`.
Change first line of the file to `@page "/animalregistration"`.
Change menu item in `NavMenu.razor` to point to the new page name which is `animalregistration`.
```htlm
<NavLink class="nav-link" href="animalregistration">
    <span class="oi oi-plus" aria-hidden="true"></span> Animal Registration
</NavLink>
```
We use purposeful names for files and code so that other developers who will read your code would have an easier time understanding it. Also, for yourself when you return to the code after some time.

Setting first line of our page code to `@page "/animalregistration"` will make the page available under this path (note the URL of the page when you're on animal registration page).

We also have to update `href` on our menu item so the code knows where to point us when we click menu item.

### Step 3
In `AnimalRegistration.razor` rename methods and variables:

- Rename `currentCount` variable to `animalCount`.
- Rename method `IncrementCount` to `AddAnimal`.
- Rename button to `Add animal`.

We also have to rename those methods and variables in all places they are used.
```cshtml
@page "/animalregistration"

<h1>Animal Registration</h1>

<p>Currently we have @animalCount animals</p>

<button class="btn btn-primary" @onclick="AddAnimal">Add Animal</button>

@code {
    private int animalCount = 0;

    private void AddAnimal()
    {
        animalCount++;
    }
}

```
Proper naming is extremelly important in programming.

### Step 4
Add method for handling animal removal:
```csharp
private void RemoveAnimal()
{
    animalCount--;
}
```
Don't worry if you still don't understand what method is. We're going to come back to it later.
In `RemoveAnimal` method we decrement variable `animalCount`.

### Step 5
Add button `Remove animal`. Very similar to `Add animal` button. Don't forget to set onclick method to `RemoveAnimal`:

```cshtml
...
<button class="btn btn-primary" @onclick="RemoveAnimal">Remove animal</button>
...
```
Here we added button with text `Remove animal` which executes method `RemoveAnimal` when clicked.

### Step 6
Run the application and try out the new animal registration page.

</p>
</details>

## Exercise 2.7: show current date in animal registration page.

Instead of:
```
Currently we have 5 animals
```
we should see:
```
At 2020-02-05 we have 5 animals
```

<details>
<summary>Solution</summary>

You can use `DateTime` type like this:

```cshtml
<p>At @DateTime.Today.ToShortDateString() we have @animalCount animals.</p>
```

We can access current date by calling `Today` from type `DateTime`. When Today gets converted (automatically) from type `DateTime` to type `String` it displays time as zeros - instead of "2020-02-04" we get "2020-02-04 00:00:00". To fix this we use `ToShortDateString` method which returns date as a type `String` without time part.

</details>
