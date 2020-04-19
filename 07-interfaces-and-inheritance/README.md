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
