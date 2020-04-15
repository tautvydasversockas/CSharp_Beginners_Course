# 6. Classes and objects

C# is an object-oriented programming (OOP) language. Everything in C# is associated with classes, objects, their attributes and methods. 

In OOP a class is a blueprint for creating objects. It provides initial values for state, behaviours (methods). This is how you could define a class:
```csharp
class Person
{
}
```
Using our defined blueprint we can create an object (notice the keyword `new`) which in this case is a person:
```csharp
var person = new Person();
```
Since it is merely a blueprint, we can create as many people as we like:
```csharp
var person1 = new Person();
var person2 = new Person();
...
```
This class is nothing more but our representation of a person in code. Let's improve it by adding a name:
```csharp
class Person
{
    private string _name;

    public void SetName(string value)
    {
        _name = value;
    }

    public string GetName()
    {
        return _name;
    }
}
```
```csharp
var person = new Person();
person.SetName("John");
var name = person.GetName(); // "John"
```
We have added a field called `_name` to our class. Since it is marked as `private`, no one outside our class is allowed to see it. Therefore we have created 2 `public` methods - one for getting the name and one for setting it. In fact, these methods are called `getters` and `setters`. It seems like a lot of code for such a small thing. Lucky for us, with C# this can be simplified:
```csharp
class Person
{
    public string Name { get; set; }
}
```
```csharp
var person = new Person();
person.Name = "John";
var name = person.Name; // "John"
```
We are getting good at this! Yet we missed one important thing. Does it make sense for a person to not have a name? It probably doesn't (at least in our context). This definition of a person, however, allows that. Let's fix it by adding a constructor:
```csharp
class Person
{
    public Person(string name)
    {
        Name = name;    
    }
    
    public string Name { get; set; }
}
```
A constructor is a method that is used to create an object from a class. Now if you want to create a new person you will have to provide a name:
```csharp
var person = new Person("John");
var name = person.Name; // "John"
```
Of course, there is a lot more to classes than that however knowing what you know now is a good starting point and it should prepare you for the following exercises.

## Exercise 6.n: create a class for animal. It should contain animal name, age, weight and registration date as properties. Add it to Data folder.

<details>
<summary>Solution</summary>

### Step 1

Create a file `Animal.cs` under Data folder.

### Step 2

Create a class in the file:

```csharp
using System;

namespace AnimalShelter.Data
{
    public class Animal
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public int Age { get; set; }

        public DateTime DateRegistered { get; set; }
    }
}
```

</details>

## Exercise 6.n: instead of accepting only name in animal registration page accept age and weight too. Use Animal class for it. Change ShelterAnimalService to work with the new setup. Make animals page display animal details in the table.

Let's do some preparations before the exercise. First of all, we need to collect input from the user. Last time we were able to bind string variable to the text field. You can also bind an object the same way to the input form.

In the animal registration page in `@code` block add a variable which will hold entered animal data:

```csharp
private Animal _currentAnimal = new Animal();
```

Then add form to the page and bind it to the variable:

```cshtml
<EditForm Model="@_currentAnimal">
    <p>Name:<br/><InputText id="name" @bind-Value="_currentAnimal.Name" /></p>
    <p>Age:<br/><InputNumber id="age" @bind-Value="_currentAnimal.Age" /></p>
    <p>Weight:<br/><InputNumber id="weight" @bind-Value="_currentAnimal.Weight" /></p>

    <button class="btn btn-primary" @onclick="AddAnimal">Add animal</button>
</EditForm>
```

Now you have `_currentAnimal` bound to the form and you're ready to proceed with the exercise on your own.

You need to change `ShelterAnimalService` to support the new way of storing animal information. Update animal registration page to work with new version of `ShelterAnimalService`. Change animals page to display full information on animals.

<details>
<summary>Solution</summary>

### Step 1

Now instead of strings we should accept `Animal` instance in the `ShelterAnimalService` and change the logic there. First our collection of animals and how we store it:

```csharp
private List<Animal> _animals = new List<Animal>();

public Animal[] Animals { get { return _animals.ToArray(); }}
```

And then animal addition logic:

```csharp
public void AddAnimal(Animal animal)
{
    if (!_calendarService.IsShelterOpen())
        return;

    if (_animals.Count == AnimalCapacity)
        return;

    if (_animals.Where(x => x.Name == animal.Name).Any())
        return;

    animal.DateRegistered = DateTime.Now;
            
    _animals.Add(animal);
}
```

Note how we check if we already have this animal. We use LINQ (Language Integrated Query). It's possibilities are really big and it has a lot of applications in C# programming. Also, note that we have a `List` of `Animal` and we just directly add the animal instance provided by the user to the list. Stop for a minute and think what kind of problems it might cause.

### Step 2

Change `AddAnimal` method in animal registration page:

```csharp
private void AddAnimal()
{
    AnimalService.AddAnimal(_currentAnimal);
    _currentAnimal = new Animal();
}
```

Why do we need to create a new instance of animal every time we add it? Well, one of the obvious purposes would be to clear fields of our form. But the most important reason is to have new animal every time we add it. Previously when editing `AddAnimal` method from `ShelterAnimalService` we have created logic that simply adds the animal instance provided by the user to the list. So if we don't create a new instance in the animal registration page we will be editing the same animal every time.

### Step 3

Change animals page to display full animal details. First of all we change the code block. Instead of getting string collection we get animals:

```cshtml
@code {
    private Animal[] animals;

    protected override async Task OnInitializedAsync()
    {
        animals = AnimalService.Animals;
    }
} 
```

Then we change the page contents:

```cshtml
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
                <th>Age</th>
                <th>Weight</th>
                <th>Registration Date</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var animal in animals)
            {
                <tr>
                    <td>@animal.Name</td>
                    <td>@animal.Age</td>
                    <td>@animal.Weight</td>
                    <td>@animal.DateRegistered</td>
                </tr>
            }
        </tbody>
    </table>
}
```

### Step 4

Run the application.

</details>
