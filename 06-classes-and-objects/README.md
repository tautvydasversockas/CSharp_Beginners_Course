# 6. Classes and objects

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