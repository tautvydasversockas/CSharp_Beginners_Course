# 3. Conditional statements

## Exercise 3.1: prevent animal removal when there is no animals and animal addition when there are 20 animals

<details>
<summary>Solution</summary>

### Step 1

Add constant variable to hold animal capacity.

```csharp
private const int AnimalCapacity = 20;
```

We will use this variable in our comparison.
Constant variables are variables that don't change.

### Step 2

Add `if` statement to `AddAnimal` method.

```csharp
private void AddAnimal()
{
    if (animalCount < AnimalCapacity)
    {
        animalCount++;
    }
}
```

`if` statement is used to execute code inside the code block only if condition is satisfied.

Code block is defined by using curly backets `{***code goes here***}`.

`(animalCount < AnimalCapacity)` is condition. Code inside the `if` block will get executed only if animal count is less than animal capacity.

### Step 3

Add `if` statement to `RemoveAnimal` method.

```csharp
private void RemoveAnimal()
{
    if (animalCount > 0)
    {
        animalCount--;
    }
}
```

Here `(animalCount > 0)` is a condition. Animal count will get decremented only if animal count is more than 0.

### Step 4

Run the application and test if it works as expected. Check if animal count will not exceed 20 and will not drop below 0.

</details>

## Exercise 3.2: display `no animals` when there is no animals and `20 (full capacity)` when we reach 20 animals in the shelter

If there are no animals your page should look like this

`At 2020-02-09 we have no animals`

If there are 20 animals your page should look like this

`At 2020-02-09 we have 20 (full capacity) animals`

Otherwise it should stay the same as it was before

`At 2020-02-09 we have 5 animals`

<details>
<summary>Solution</summary>

### Step 1
Define a method that would return string representation of animal count.

```csharp
private string PrintAnimalCount()
{
    
}
```

This method will return part of the text where number of animals is defined.

```cshtml
<p>At @DateTime.Today.ToShortDateString() we have @PrintAnimalCount() animals.</p>
```

### Step 2
Add if statement to the method and handle the case when there is no animals.

```csharp
private string PrintAnimalCount()
{
    if (animalCount == 0)
    {
        return "no";
    }
}
```

This code will return `no` when animal count is 0.

### Step 3

Add else if part to handle full capacity case.

```csharp
private string PrintAnimalCount()
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

Here we will return animal count with message stating that we are at full capacity when animal count is equal to animal capacity.

### Step 4

Add else part to handle other cases.

```csharp
private string PrintAnimalCount()
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

Here we just return animalCount in string representation.

### Step 5

Run the application and test if it works as expected. Check if text displayed on the screen is correct in all cases.

</details>