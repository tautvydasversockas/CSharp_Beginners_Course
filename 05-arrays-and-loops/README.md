# 5. Arrays and loops

Imagine that you have to store 2 values. That doesn't sound like a big problem - you can define 2 variables. But what if the number of values that you have to store is 100 or even 1000? Luckily there is a thing called array which is used to store multiple variables into a single one. Here's how it looks:
```csharp
var fruits = new string[10];
```
Do you see a number 10? It is the size of the fruits array. You have to provide a number of elements you would like to store in the array (array size) in order to initialize it. Well... Unless you know the values - then it can be initialized like this:
```csharp
var fruits = new []{"Mango", "Apple", "Banana...nana...nana...BATMAN!", "Orange"};
```
In this case the size of the array is 4. This is important since you cannot change the size after initializing the array. Notice the silly joke with Batman - arrays are restricted by the type which means you can put any values in the fruits array as long as they are of type `string`.


Do you remember the task where you had to select a second letter from a given word? You were able to do that by using `givenString[1]` syntax because `string` is actually an array of `char` type values. You can select values in the same way from any array (just remember that values are counted starting from 0 and the number is called index):
```csharp
var fruits = new []{"Mango", "Apple", "Banana...nana...nana...BATMAN!", "Orange"};
var secondFruit = fruits[1];
```
For a minute imagine if you did not find my joke about batman funny... How could you.... You can ovveride array values if you know their index:
```csharp
var fruits = new []{"Mango", "Apple", "Banana...nana...nana...BATMAN!", "Orange"};
fruits[2] = "Banana";
```
