//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class CandidateSystem
//    {
//    }
//}
using System.ComponentModel.Design;
using System.Globalization;

Console.Write("Hello Candidate! What is your first name? ");
string? firstName = Console.ReadLine();

Console.Write($"Hello {firstName}! What is your last name? ");
string? lastName = Console.ReadLine();



if (firstName.ToLower() == "tim" ||
    firstName.ToLower() == "sue" ||
    firstName.ToLower() == "bob")
{
    Console.WriteLine($"Hello dear candidate {firstName}");
}
else
{
    Console.WriteLine($"Hello Mr./Ms. {firstName}");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~




Console.Write($"{firstName}, Please write your birth date in the exact format: (dd/MM/yyyy) ");
string? birthDateText = Console.ReadLine();
DateOnly birthday = DateOnly.ParseExact(birthDateText, "dd/MM/yyyy", CultureInfo.InvariantCulture);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



Console.Write($"{firstName}, Please insert your age in digits: ");
string? ageText = Console.ReadLine();

bool isValidage = int.TryParse(ageText, out int age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


Console.WriteLine($"{firstName}, What is your salary expectations? ");
string? salaryExpectationsText = Console.ReadLine();
decimal salaryAmount = decimal.Parse(salaryExpectationsText);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



bool isHired = false;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine($"{firstName}, you are a minor, please wait {18 - age} years.");
        break;
    case >= 18 and <= 67:
        if (salaryAmount <= 30000.5M)
        {
            isHired = true;
            Console.WriteLine($"Congrats {firstName}, You are hired");
        }
        else
        { 
            Console.WriteLine($"Thank you dear {firstName}, we decided to move forward with another candidate.");
        }
        break;
    case > 67:
        Console.WriteLine($"Dear {firstName}, we wish you a Happy retirement.");
        break;
    default:
        Console.WriteLine("Undefined");
        break;
}










































