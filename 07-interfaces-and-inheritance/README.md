# 7. Interfaces and inheritance

Arguably the most important concepts of OOP (object-oriented programming) is inheritance. It allows inheriting fields and methods from one class to another. Inheritance is not very difficult to understand as soon as you see it implemented in code. Let's look at the `Animal`  class example:
```csharp
class Animal
{
    public string Name { get; }
    
    public Animal(string name)
    {
        Name = name;
    }
    
    public void Pet()
    {
        Console.WriteLine(Name + " is getting petted!");
    }
}
```
There might be more concrete types of pets that have names and can be petted. We can get all of the features defined in the `Animal` class by inheriting from it:
```csharp
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
}
```
Let's try to understand what we did. We created a class `Dog` and by using `:` symbol we inherited from class `Animal`. That means our class `Dog` has a property `Name` as well as a `Pet` method. Therefore we can now write a code like this:
```csharp
var dog = new Dog("Rex");
dog.Pet(); // Rex is getting petted!
```
We refer to classes that are being inherited from as `base` and to classes that inherit from other classes as `derived`. If you recall from the previous chapter, to create a class we must call its constructor (if it exists). By using the keyword `base` we call a constructor of a base, in this case, the `Animal` class. We use the `string` parameter `name` provided to the constructor of the `Dog` class and pass it to the constructor of its base class - `Animal`. 

Dogs can have other features that make them different from other animals. Let's improve the `Dog` class:  
```csharp
class Dog : Animal
{
    public bool IsLeashed { get; }
    
    public Dog(string name) : base(name)
    {
    }
    
    public void Leash()
    {
        IsLeashed = true;
    }
    
    public void Unleash()
    {
        IsLeashed = false;
    }
}
```
In the meantime, we can create a `Fox` class that has a name and can be petted (do not try this at home). Unlike the `Dog`, the `Fox` doesn't have a leash: 
```csharp
class Fox : Animal
{
    public Fox(string name) : base(name)
    {
    }
}
```
Now let's say that we want to reflect how animals speak in our code. We know that all animals speak (as far as this example is concerned). We know, that dogs say  "Woof woof", cats say "Meow". But what does the fox say (I bet you didn't see this joke coming)? Let's add a method to the `Animal` class:
```csharp
class Animal
{
    public string Name { get; }
    
    public Animal(string name)
    {
        Name = name;
    }
    
    public void Pet()
    {
        Console.WriteLine(Name + " is getting petted!");
    }
    
    public void Speak()
    {
        Console.WriteLine("Unknown sounds...");
    }
}
```
Now all derived classes that inherit from the `Animal` will be able to speak. Let's mark the `Speak` method with the `virtual` keyword: 
```csharp
class Animal
{
    public string Name { get; }
    
    public Animal(string name)
    {
        Name = name;
    }
    
    public void Pet()
    {
        Console.WriteLine(Name + " is getting petted!");
    }
    
    public virtual void Speak()
    {
        Console.WriteLine("Unknown sounds...");
    }
}
```
If we want we can override the method `Speak` in derived classes like this:
```csharp
class Dog : Animal
{
    public bool IsLeashed { get; }
    
    public Dog(string name) : base(name)
    {
    }
    
    public void Leash()
    {
        IsLeashed = true;
    }
    
    public void Unleash()
    {
        IsLeashed = false;
    }
    
    public override void Speak()
    {
        Console.WriteLine("Woof woof");
    }
}
```
```csharp
class Fox : Animal
{
    public Fox(string name) : base(name)
    {
    }
    
    public override void Speak()
    {
        Console.WriteLine("Ring-ding-ding-ding-dingeringeding");
    }
}
```
It is not required to override virtual methods. If we do not override virtual methods we will be using the ones that are defined in base classes:
```csharp
class ImaginaryAnimal : Animal
{
    public Fox(string name) : base(name)
    {
    }
}
```

Another way to achieve abstraction is interfaces. Implementing interfaces is similar to inheriting classes:
```csharp
interface ILeashed
{
    void Leash();
    void Unleash();
}
```
```csharp
class Dog : Animal, ILeashed
{
    public bool IsLeashed { get; }
    
    public Dog(string name) : base(name)
    {
    }
    
    public void Leash()
    {
        IsLeashed = true;
    }
    
    public void Unleash()
    {
        IsLeashed = false;
    }
    
    public override void Speak()
    {
        Console.WriteLine("Woof woof");
    }
}
```
There are some differences: you can implement many interfaces while you can inherit only a single class, you can implement methods in base classes while you can't do that in interfaces, etc. 

It is more important to understand the conceptual differences and when to use each. Here's an answer from the `StackOverflow`:

*When we talk about abstract classes we are defining characteristics of an object type; specifying what an object is.*

*When we talk about an interface and define capabilities that we promise to provide, we are talking about establishing a contract about what the object can do.*

There are some more nitty-gritty details related to inheriting classes and implementing interfaces but this should be a good starting point for the exercises.

## Exercise 7.1: create classes for a motorcycle and a car with a removable roof. Both types of vehicles can honk. A car with a removable roof can get its roof removed. Use inheritance.

<details>
<summary>Solution</summary>

### Step 1

Create a class for a vehicle:

```csharp
class Vehicle
{
    public void Honk()
    {
        Console.WriteLine("Honk");
    }
}
```

### Step 2

Create a class for a motorcycle:

```csharp
class Motorcycle : Vehicle
{
}
```

### Step 3

Create a class for a car:

```csharp
class Car : Vehicle
{
    public bool IsRoofRemoved { get; }
    
    public void RemoveRoof()
    {
        IsRoofRemoved = true;
    }
    
    public void AddRoof()
    {
        IsRoofRemoved = false;
    }
}
```

### Step 4

Try it out:

```csharp
using System;

namespace MyApp
{
    class Vehicle
    {
        public void Honk()
        {
            Console.WriteLine("Honk");
        }
    }

    class Motorcycle : Vehicle
    {
    }
    
    class Car : Vehicle
    {
        public bool IsRoofRemoved { get; }

        public void RemoveRoof()
        {
            IsRoofRemoved = true;
        }

        public void AddRoof()
        {
            IsRoofRemoved = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var motorcycle = new MotorCycle();
            motorcycle.Honk(); // "Honk"
            
            var car = new Car(); 
            car.Honk(); // "Honk"
            
            car.RemoveRoof();
            Console.WriteLine(car.IsRoofRemoved); // true
            
            car.AddRoof();
            Console.WriteLine(car.IsRoofRemoved); // false
        }
    }
}
```
</details>

## Exercise 7.2: motorcycles and cars from the exercise 7.1 are taxed. Motorcycles are taxed 5 % while cars - 6 %. Modify vehicles to have a monetary value. Create an interface for getting taxes.

<details>
<summary>Solution</summary>

### Step 1

Modify classes from the previous exercise to have a monetary value:

```csharp
class Vehicle
{
    public decimal Value { get; }
    
    public Vehicle(decimal value)
    {
        Value = value;  
    }
    
    public void Honk()
    {
        Console.WriteLine("Honk");
    }
}
```
```csharp
class Motorcycle : Vehicle
{
    public Motorcycle(decimal value) : base(value)
    {
    }
}
```
```csharp
class Car : Vehicle
{
    public Car(decimal value) : base(value)
    {
    }
    
    public bool IsRoofRemoved { get; }
    
    public void RemoveRoof()
    {
        IsRoofRemoved = true;
    }
    
    public void AddRoof()
    {
        IsRoofRemoved = false;
    }
}
```
Notice the type `decimal`. It is recommended to use `decimal` instead of `double` for monetary calculations.

### Step 2

Create an interface for taxes:

```csharp
interface ITaxable
{
    decimal GetTaxes();
}
```
Notice the `I` before `Taxable`. It is a common practice in C# to prefix interfaces with an `I`.

### Step 3

Implement the `ITaxable` interface:

```csharp
class Motorcycle : Vehicle, ITaxable
{
    public Motorcycle(decimal value) : base(value)
    {
    }
    
    public decimal GetTaxes()
    {
        return Value * 0.05;
    }
}
```
```csharp
class Car : Vehicle, ITaxable
{
    public Car(decimal value) : base(value)
    {
    }
    
    public bool IsRoofRemoved { get; }
    
    public void RemoveRoof()
    {
        IsRoofRemoved = true;
    }
    
    public void AddRoof()
    {
        IsRoofRemoved = false;
    }
    
    public decimal GetTaxes()
    {
        return Value * 0.06;
    }
}
```

### Step 4

Try it out:

```csharp
using System;

namespace MyApp
{
    class Vehicle
    {
        public decimal Value { get; }

        public Vehicle(decimal value)
        {
            Value = value;  
        }

        public void Honk()
        {
            Console.WriteLine("Honk");
        }
    }

    interface ITaxable
    {
        decimal GetTaxes();
    }

    class Motorcycle : Vehicle, ITaxable
    {
        public Motorcycle(decimal value) : base(value)
        {
        }

        public decimal GetTaxes()
        {
            return Value * 0.05;
        }
    }
    
    class Car : Vehicle, ITaxable
    {
        public Car(decimal value) : base(value)
        {
        }

        public bool IsRoofRemoved { get; }

        public void RemoveRoof()
        {
            IsRoofRemoved = true;
        }

        public void AddRoof()
        {
            IsRoofRemoved = false;
        }

        public decimal GetTaxes()
        {
            return Value * 0.06;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ITaxable taxable = new Motorcycle(100);
            Console.WriteLine(taxable.GetTaxes()); // 5
            
            taxable = new Car(100);
            Console.WriteLine(taxable.GetTaxes()); // 6
        }
    }
}
```
Notice that we use the same `ITaxable` type variable for a car and a motorcycle. We don't really care if it's a motorcycle or a car. As long as it is `ITaxable` we know that we can get taxes from it.

</details>
