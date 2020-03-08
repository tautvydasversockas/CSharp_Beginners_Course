# 5. Arrays and loops

Imagine that you have to store 2 values. That doesn't sound like a big problem - you can define 2 variables. But what if the number of values that you have to store is 100 or even 1000? Luckily there is a thing called array which is used to store multiple variables into a single one. Here's how it looks:
```csharp
var fruits = new string[10];
```
Do you see the number 10? It is the size of the fruits array. You have to provide the number of elements you would like to store in the array (array size) to initialize it. Well... Unless you know the values - then it can be initialized like this:
```csharp
var fruits = new []{"Mango", "Apple", "Banana...nana...nana...BATMAN!", "Orange"};
```
In this case, the size of the array is 4. This is important since you cannot change the size after initializing the array. Notice the silly joke with Batman - arrays are restricted by the type which means you can put any values in the fruits array as long as they are of type `string`.


Do you remember the task where you had to select a second letter from a given word? You were able to do that by using `givenString[1]` syntax because `string` is an array of `char` type values. You can select values in the same way from any arrays (just remember that values are counted starting from 0 and the number is called index):
```csharp
var fruits = new []{"Mango", "Apple", "Banana...nana...nana...BATMAN!", "Orange"};
var secondFruit = fruits[1];
```
For a minute imagine if you did not find my joke about batman funny... How could you... You can override array values if you know their index:
```csharp
var fruits = new []{"Mango", "Apple", "Banana...nana...nana...BATMAN!", "Orange"};
fruits[2] = "Banana";
```
Now imagine you have to write first 5 array values to the console. You could do it like this:
```csharp
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(array[3]);
Console.WriteLine(array[4]);
```
That wasn't that hard, was it? But what if you had to write 100 values? 1000? 10000? To write all of those lines would take quite some time. Fortunately, we can do better by utilising the `while` loop:
```csharp
var i = 0;
while (i < 100)
{
    Console.WriteLine(array[i]);
    i++;
}
```
The `while` loop consists of 2 parts - a condition and a code block. The loop loops through the code block as long as a specified condition is equal to `true`. In the example, the code in the loop will run, over and over again, as long as the variable `i` is less than 100. During each loop, we are increasing the value of `i` by 1 (if you forgot, `i++` is the same as `i = i + 1`) making the loop stop after 100 loops. 

However, since you know the number of times you want to loop through a block of code, you could use the `for` loop instead:
```csharp
for (var i = 0; i < 100; i++)
{
    Console.WriteLine(array[i]);
}
```
This `for` loop consists of 3 statements and a code block. The first statement `i = 0` is executed one time before the execution of the code block. In this case, we create a variable named `i` and assign a value of 0 to it. The second statement `i < 100` defines the condition for executing the code block (same as with the `while` loop). The last statement `i++` is executed every time after the code block has been executed. As you can probably guess, the `foor` loop is the same `while` loop with some syntax improvements.

To make matters more interesting, there's one more loop called `foreach` which you could use to loop through all of the array values: 
```csharp
foreach (var value in array)
{
    Console.WriteLine(value);
}
```
Despite the syntax differences, the `foreach` loop is nothing more than the good old `foor` loop:
```csharp
for (var i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
```
Since we already discovered, that the `for` loop is nothing more than the good old `while` loop, you could argue that if you understand the `while` loop, you understand them all.


If you were reading thoroughly, you know that you need to provide an array size to initialize the array. But what would you do if you didn't know the size right now since you were planning to add some values to the array later? You could create an extremely huge array with a size of 10000. However, if you had more values than 10000, you would still be facing the same issue. Lucky for us, there is a data structure called `List` which utilises arrays to grow it's size dynamically:
```csharp
var myList = new List<int>();
for (var i = 0; i < 10000; i++)
{
    myList.Add(i);
}
```

## Exercise 5.1: write a method that takes an array of words and writes all of them to the console.

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Define a method that returns nothing:
```csharp
public void WriteToConsole(string[] array)
{
}
```
### Step 2
Implement the defined method:
```csharp
public void WriteToConsole(string[] array)
{
    foreach (var item in array)
        Console.WriteLine(item);
}
```
### Step 3
Call the method to test it. 
</p>
</details>

## Exercise 5.2: write a method that returns the sum of first n natural numbers.

If n is 11, the sum should be 66.
<details>
<summary>Solution</summary>
<p>
    
### Step 1
Define a method that returns nothing:
```csharp
public int GetNNumbersSum(int n)
{
}
```
### Step 2
Implement the defined method:
```csharp
public int GetNNumbersSum(int n)
{
    var sum = 0;

    for (var i = 1; i <= n; i++)
        sum += i;

    return sum;
}
```
`sum += i` is another way of writing `sum = sum + i`.
### Step 3
Call the method to test it. 
</p>
</details>

## Exercise 5.3: write a console application that asks for a secret word. If the given word is "cattywampus" the application writes congratulating message to the console and closes, otherwise the application says that the word is incorrect and lets to try again.

Your console should look something like this:
```
What's the secret word?
bumfuzzle
No no no, that is not the secret word!
What's the secret word?
cattywampus
Congratulations, it's correct!
```
<details>
<summary>Solution</summary>
<p>
    
### Step 1
Implement the logic using the while loop:
```csharp
static void Main()
{
    while (Console.ReadLine().ToLower() != "cattywampus")
        Console.WriteLine("No no no, that is not the secret word!");

    Console.WriteLine("Congratulations, it's correct!");
}
```
### Step 2
Run the application. 
</p>
</details>

## Exercise 5.4: write a console application that reads all user input lines. When the user writes "stop", the application writes all of the inputs to the console.

Your console should look something like this:
```
Gardyloo
Taradiddle
Collywobbles
Flibbertigibbet
stop
Gardyloo
Taradiddle
Collywobbles
Flibbertigibbet
```
Fun fact - those crazy words are real.

<details>
<summary>Solution</summary>
<p>
    
### Step 1
Read user words and store them into a list:
```csharp
static void Main()
{
    var words = new List<string>();

    string givenWord;
    while ((givenWord = Console.ReadLine()).ToLower() != "stop")
        words.Add(givenWord);
}
```
### Step 2
Write words from the list back to the console:
```csharp
static void Main()
{
    var words = new List<string>();

    string givenWord;
    while ((givenWord = Console.ReadLine()).ToLower() != "stop")
        words.Add(givenWord);

    foreach (var item in words)
        Console.WriteLine(item);
}
```
### Step 3
Run the application. 
</p>
</details>

## Exercise 5.5: update animal registration page to read animal names before adding them to the list. Prevent duplicate animal names. Rewrite GetAnimalCountText method to work with the new logic.

As we did last time with `ShelterCalendarService` now we need something that would be responsible for storing our animals. Let's create `ShelterAnimalService` which will be responsible for everything we do with our animals. Create `ShelterAnimalService.cs` file in Data folder:

```csharp
using System;
using System.Collections.Generic;

namespace AnimalShelter.Data
{
    public class ShelterAnimalService
    {
        private List<string> _animals = new List<string>();
    }
}
```

Animals list will be holding animals of the shelter. It's private because we don't want anyone to mess with the list. `ShelterAnimalService` is responsible for it and everyone will have to play by its rules.

Just like the last time with `ShelterCalendarService` we need to register our new service in `Startup.cs` file in `ConfigureServices` method:

```csharp
services.AddSingleton<ShelterAnimalService>();
```

Also, inject it in every page we are going to use. For now only in animal registration page:
```cshtml
@inject ShelterAnimalService AnimalService 
```

For now let's remove our "Remove Animal" button and method behind it. We will add this feature again but in different place.

In animal registration page we have some logic that should be part of `ShelterAnimalService`. This component is responsible for animals and it should know the rules when we are allowed to add animal and when we are not allowed to do it. But to add this logic to our `ShelterAnimalService` we need to make use of `ShelterCalendarService` there too. Also we should have the capacity there too:

```csharp
using System;
using System.Collections.Generic;

namespace AnimalShelter.Data
{
    public class ShelterAnimalService
    {
        public readonly int AnimalCapacity = 20;

        private readonly ShelterCalendarService _calendarService;

        private List<string> _animals = new List<string>();

        public ShelterAnimalService(ShelterCalendarService calendarService)
        {
            _calendarService = calendarService;
        }
    }
}
```

We also need to expose our collection to the world but prevent others outside our class from editing it. Don't worry if you don't understand what is going on here. What you have to remember is that you will be able to use `Animals` to access our collection outside this class.

```csharp
using System;
using System.Collections.Generic;

namespace AnimalShelter.Data
{
    public class ShelterAnimalService
    {
        public readonly int AnimalCapacity = 20;
        private readonly ShelterCalendarService _calendarService;
        private List<string> _animals = new List<string>();

        public string[] Animals { get { return _animals.ToArray(); }}

        public ShelterAnimalService(ShelterCalendarService calendarService)
        {
            _calendarService = calendarService;
        }
    }
}
```

Now in animal registration page `@code` block add variable for storing currently entered animal name:

```csharp
private string _animalName;
```

Now we need to add text field to our page where user will enter animal name. `@bind="_animalName"` part is responsible for binding our `_animalName` variable with the text field. It means that value of `_animalName` will be the same as value entered to the text field:

```cshtml
<h2>Animal Information</h2>

Name: <input type="text" @bind="_animalName"/><br/><br/>
```

Now everything is ready and you may proceed with the task.

<details>
<summary>Solution</summary>

### Step 1
Define a method in `ShelterAnimalService` for animal addition:

```csharp
public void AddAnimal(string name)
{
    _animals.Add(name);
}
```

### Step 2
Add logic we already had in animal registration page to prevent addition when not in business hours and when reached capacity.

```csharp
public void AddAnimal(string name)
{
    if (!_calendarService.IsShelterOpen())
        return;

    if (_animals.Count == AnimalCapacity)
        return;

    _animals.Add(name);
}
```

### Step 3
Add logic to prevent addition when there is already an animal with the same name in the list.

```csharp
public void AddAnimal(string name)
{
    if (!_calendarService.IsShelterOpen())
        return;

    if (_animals.Count == AnimalCapacity)
        return;

    if (_animals.Contains(name))
        return;

    _animals.Add(name);
}
```

### Step 4
Rewrite `AddAnimal` method in animal registration page to make use of the new method in the `ShelterAnimalService`:

```csharp
private void AddAnimal()
{
    AnimalService.AddAnimal(_animalName);
}
```

### Step 5
AnimalCapacity and animalCount in animal registration page are not relevant anymore. Remove them and rewrite `GetAnimalCountText` to make use of `ShelterAnimalService` to perform the task:

```csharp
private string GetAnimalCountText()
{
    var animalCount = AnimalService.Animals.Count();

    if (animalCount == 0)
    {
        return "no";
    }
    else if (animalCount == AnimalService.AnimalCapacity)
    {
        return animalCount + " (full capacity)";
    }
    else
    {
        return animalCount.ToString();
    }
}
```

### Step 6
Run the application

</details>

## Exercise 5.6: rewrite FetchData page to display list of our animals in the table. Make use of ShelterAnimalService there.

<details>
<summary>Solution</summary>

### Step 1
Rename `FetchData.razor` to `Animals.razor`. At the top of the page file change path of the page:

```cshtml
@page "/animals"
```

Don't forget to update menu:

```cshtml
<li class="nav-item px-3">
    <NavLink class="nav-link" href="animals">
        <span class="oi oi-list-rich" aria-hidden="true"></span> Animals
    </NavLink>
</li>
```

### Step 2
Inject `ShelterAnimalService` into the page:

```cshtml
@using AnimalShelter.Data
@inject ShelterAnimalService AnimalService
```

Update code block to get animals from the `ShelterAnimalService`:

```cshtml
@code {
    private string[] animals;

    protected override async Task OnInitializedAsync()
    {
        animals = AnimalService.Animals;
    }
}
```

### Step 3
Update page to display table of animal names:

```cshtml
<h1>Animals</h1>

<p>Here you can find a list of our animals.</p>

@if (animals == null)
{
    <p><em>Loading...</em></p>
}
else
{
    <table class="table">
        <thead>
            <tr>
                <th>Name</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var animal in animals)
            {
                <tr>
                    <td>@animal</td>
                </tr>
            }
        </tbody>
    </table>
}
```

### Step 4
Run the application

</details>
