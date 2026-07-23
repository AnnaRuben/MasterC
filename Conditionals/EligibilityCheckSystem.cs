//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class EligibilityCheckSystem
//    {
//    }
//}
using System.Globalization;

Console.Write("Hello User! ,What is your first name: ");
string? firstName = Console.ReadLine();

Console.Write($"Hello {firstName}! ,What is your last name: ");
string? lastName = Console.ReadLine();

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

string? filePath = @"C:\Students\Grants";
Console.WriteLine($"Save file to {filePath} ,based on your name: {firstName} {lastName}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Write($"{firstName} ,What's your age: ");
string? ageText = Console.ReadLine();

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");


if (!isValidInt)
{
    age = 0;
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

DateOnly birthday = DateOnly.Parse("23/06/1983");

Console.WriteLine(birthday.ToString("dd, MMMM, yyyy", CultureInfo.InvariantCulture));
Console.WriteLine($"Birthday full format: {birthday}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Write($"Hey {firstName}, What is your grade point average: ");
double? gradePointAverage = Console.ReadLine();
Console.WriteLine(gradePointAverage = 85.5);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Write($"Hey {firstName}, What is your monthly income: ");
decimal? monthlyIncome = Console.ReadLine();
Console.WriteLine(monthlyIncome - 6000);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

bool? hasMilitaryService = null;
bool? hasMilitaryService = true;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (firstName.ToLower() == "bob" && 
    firstName.ToLower() == "sue")
{
    Console.WriteLine($" Hello Professor {firstName}");
}
else if (firstName.ToLower() == "bob" ||
         firstName.ToLower() == "sue")
{
    Console.WriteLine("You have a great part in your name.");
}
else
{
    Console.WriteLine("Hello Student");
}

if (age >= 40 && age < 50 ||
    age >= 70 && age < 80)
{
    Console.WriteLine("You are in your 40's");
}


switch (age)
{
    case >= 0 and < 17:
        Console.WriteLine("You are a minor.");
        break;
    case >= 18 and < 65:
        Console.WriteLine("You are a fit for checkup.");
        break;
    case > 65:
        Console.WriteLine("Wish you a Happy Retirement.");
        break;
    default:
        Console.WriteLine("Undefined.");
        break;
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
bool? isComplete = true;

if (gradePointAverage == 85.5 &&
    monthlyIncome < 6000)
{
    Console.WriteLine("Congrats! Registration process was completed successfully");
}
else
{
    Console.WriteLine("Sorry, try next year.");
}


switch (gradePointAverage)
{
    case >= 0 and < 85.5:
        Console.WriteLine("Congrats! You are a candidate for Eligibility Program.");
        break;
    case >= 0 and < 6000:
        Console.WriteLine("Congrats! You are a candidate for Eligibility Program.");
        break;
    default:

        break;
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
TimeOnly  
Console.WriteLine($"Hello {firstName} {lastName}!,Your file was saved successfully to {filePath} ,based on your name: {firstName} {lastName}. we saved your Birthday: {birthday}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


































