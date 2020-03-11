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