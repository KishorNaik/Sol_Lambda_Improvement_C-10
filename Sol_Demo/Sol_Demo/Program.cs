// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//C# 9
Func<string, int> toInt1 = (string value) => int.Parse(value);
Console.WriteLine(toInt1("1"));

// C#10
var toInt2 = (string value) => int.Parse(value);
Console.WriteLine(toInt2("1"));

// Explicit Return Type
var toInt3 = int (string value) => int.Parse(value);
Console.WriteLine(toInt3("1"));