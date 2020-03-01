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
