//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BestPractice
//{
//    internal class PracticeDateOnly
//    {
//    }
//}
using System.Globalization;

////1.1 + 1.2
//DateOnly evenDate = DateOnly.Parse("15/08/2025");
//Console.WriteLine(evenDate.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////1.3
//string? eventDateText = Console.ReadLine();
//DateOnly eventDate = DateOnly.Parse(eventDateText);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////2-2.1
//Console.WriteLine(evenDate.ToString("yyyy", CultureInfo.InvariantCulture));
//Console.WriteLine(evenDate.ToString("MM", CultureInfo.InvariantCulture));
//Console.WriteLine(evenDate.ToString("dd", CultureInfo.InvariantCulture));
//Console.WriteLine(eventDate.ToString("dddd", CultureInfo.InvariantCulture));
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////2.2
//if (eventDate)
//{
//    Console.WriteLine("It is weekend.");
//}
//else
//{
//    Console.WriteLine("It is one of the regular week days.");
//}
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////3-3.1
//DateOnly deadLine = DateOnly.FromDateTime(DateTime.Now).AddDays(30);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1
DateTime loginTime = DateTime.Now;
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2
DateOnly employeeStartDate = DateOnly.Parse("9/15/2023");
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//3
Console.WriteLine(employeeStartDate.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//4.1
Console.WriteLine($"Login time and date: {loginTime}");
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//4.2
Console.WriteLine($"Login just date: {loginTime.Date}");
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//4.3
Console.WriteLine($"The employee start date was: {employeeStartDate}");



//Console.WriteLine($"The employee start date was: {employeeStartDate}");

//DateTime today = DateTime.UtcNow;

//DateTime birthday = DateTime.Parse("15/06/1998");

//DateTime birthday = DateTime.ParseExact("11/15/1998", "M/d/yyyy", CultureInfo.InvariantCulture);

//DateTime birthday = DateTime.ParseExact("06/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

//Console.WriteLine(birthday.ToString());

//Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));