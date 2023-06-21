// See https://aka.ms/new-console-template for more information
using Help;

Console.WriteLine("Hello, World!");

var inputValidator = new InputValidator();

string number = "12345";
Console.WriteLine($"{number} is a number: {inputValidator.IsNumber(number)}");

string ipAddress = "192.168.0.1";
Console.WriteLine($"{ipAddress} is an IP address: {inputValidator.IsIPAddress(ipAddress)}");

string date = "2023-06-20";
Console.WriteLine($"{date} is a valid date: {inputValidator.IsDate(date)}");

string text = "Hello, World!";
Console.WriteLine($"{text} is a text: {inputValidator.IsText(text)}");

string invalidInput = "Invalid";
Console.WriteLine($"{invalidInput} is a text: {inputValidator.IsText(invalidInput)}");
