//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BestPractice
//{
//    internal class OnboardingSystem
//    {
//    }
//}
using System.Globalization;
//1.1
bool isRaining = true;

Console.WriteLine(isRaining);

isRaining = !isRaining;

Console.WriteLine(isRaining);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.2
double averageGrade = 87.5;
int studentCount = 24;
decimal classBudget = 1500.75M;

Console.WriteLine($"{averageGrade}, {studentCount}, {classBudget}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.3
Console.WriteLine("Hello User! Please write 2 numbers.");
string? numberOneText = Console.ReadLine();
string? numberTwoText = Console.ReadLine();

bool isNumberOneValid = int.TryParse(numberOneText, out int numberOne);
bool isNumberTwoValid = int.TryParse(numberTwoText, out int numberTwo);

Console.WriteLine($"This is valid: {isNumberOneValid}, the number was {numberOne} and this is valid: {isNumberTwoValid}, the number was {numberTwo}");

if (isNumberOneValid && isNumberTwoValid)
{
    int sum = numberOne + numberTwo;
    int difference = numberOne - numberTwo;
    double average = (double)numberOne / numberTwo;

    Console.WriteLine($"Sum: {sum}, Difference: {difference}, Average: {average}");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.4
string? middleName = null;
Console.WriteLine(middleName);

middleName = "anna";
Console.WriteLine(middleName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.5
string? filePathOne = "C:\\Projects\\Demo\\file.txt";

string? filePathTwo = @"C:\Projects\Demo\file.txt";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2-2.1
DateTime meetingTime = DateTime.Now;
Console.WriteLine(meetingTime.ToString("dddd, MMMM, dd, yyyy, hh:mm tt", CultureInfo.InvariantCulture));
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2.2
Console.Write("Hey User! Please inert your birthday in this exact format: (dd/MM/yyyy)");
string? birthdayDateText = Console.ReadLine();
DateOnly birthday = DateOnly.Parse(birthdayDateText);
Console.WriteLine("Your age is 37.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2.3
TimeOnly openingTime = TimeOnly.Parse(birthdayDateText);








//Console.WriteLine(meetingTime.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));






















//using System.Globalization;

//Console.Write("Hello, What is your first name? ");
//string? firstName = Console.ReadLine();

//Console.Write($"Hello {firstName}, What is your last name? ");
//string? lastNmae = Console.ReadLine();

//Console.WriteLine($"Hello {firstName}, Please write your birthday date in this exact format: dd/mm/yy.: ");
//string? birthdayDateText = Console.ReadLine();
////DateTime birthday = DateTime.ParseExact(birthdayDateText, "");
////DateOnly birthday = DateOnly.ParseExact(birthdayDateText,"dd/")
//DateOnly birthday = DateOnly.ParseExact(birthdayDateText, "dd/mm/yyyy", CultureInfo.InvariantCulture);































































