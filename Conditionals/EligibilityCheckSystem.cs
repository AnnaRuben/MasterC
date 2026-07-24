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

Console.WriteLine(birthday.ToString("MMMM, dd, yyyy", CultureInfo.InvariantCulture));
Console.WriteLine($"Birthday full format: {birthday}");

Console.Write("Enter your birthdate (dd/MM/yyyy): ");
string? birthDateText = Console.ReadLine();

// המרה לפי הפורמט המבוקש עם DateTime.ParseExact
DateTime birthday = DateTime.ParseExact(birthDateText!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Write($"Hey {firstName}, What is your grade point average: ");
string? gradePointText = Console.ReadLine();
double gradePointAverage = double.Parse(gradePointText!);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Write($"Hey {firstName}, What is your monthly income: ");
string? incomeText = Console.ReadLine();
decimal monthlyIncome = decimal.Parse(incomeText!);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

bool? hasMilitaryService = null;
hasMilitaryService = true;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (firstName.ToLower() == "bob" || 
    firstName.ToLower() == "sue")
{
    Console.WriteLine($" Hello Professor {firstName}");
}
else
{
    Console.WriteLine("Hello Student");
}

if ((age >= 40 && age < 50) ||
    (age >= 70 && age < 80))
{
    Console.WriteLine("You are in your 40's or 70's");
}


switch (age)
{
    case >= 0 and <= 17:
        Console.WriteLine($"You are a minor. You need to wait {18 - age} years.");
        break;
    case >= 18 and <= 65:
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
bool isComplete = true;
bool isEligible = false;

if (gradePointAverage >= 85.5 &&
    monthlyIncome < 6000M &&
    isComplete)
{
    isEligible = true;
    Console.WriteLine("Congrats! Registration process was completed successfully");
}
else
{
    Console.WriteLine("Sorry, try next year.");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

TimeOnly scholarship = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine($"\n--- FINAL REPORT ---");
Console.WriteLine($"Name: {firstName} {lastName}");
Console.WriteLine($"File Path: {filePath}");
Console.WriteLine($"Birthday: {birthday.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Check Time: {scholarship}");
// הדפסה של הסטטוס הסופי
Console.WriteLine($"Is Eligible for Scholarship? {isEligible}");
