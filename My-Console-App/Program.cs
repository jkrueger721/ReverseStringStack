// See https://aka.ms/new-console-template for more information

using System;
using My_Console_App;
Console.WriteLine("What string would you like to reverse? : ");
string? word = Console.ReadLine();

Console.WriteLine($"The word you want to reverse is: {word}");

var wordReversed = Reverse.ReverseMyString(word);
Console.WriteLine($"the result is: {wordReversed}");