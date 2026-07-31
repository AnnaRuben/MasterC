//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BestPractice
//{
//    internal class PracticeDateTime
//    {
//    }
//}

using System.Globalization;

// //1
// DateTime thisMomentUtc = DateTime.UtcNow;
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //2
// DateTime eropeanDataBase = DateTime.ParseExact("28/04/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //3
// Console.WriteLine(eropeanDataBase.ToString("MMMM, dd,yyyy h:mm:ss tt zzz", CultureInfo.InvariantCulture));
// Console.ReadLine();
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// //1-1.1
// DateTime today = DateTime.Now;
// Console.WriteLine(today);
// //
// // //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// //
// //1.2
// DateTime myCurrentTimeUtc = DateTime.UtcNow;
// Console.WriteLine(myCurrentTimeUtc);
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //1.3
// //Yes, there is a difference in Israel time.
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //1.4
// //Yes, the seconds and the minutes are changing.
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //2-2.1 + 2.2
// Console.WriteLine(today.ToString("dd/MM/yy", CultureInfo.InvariantCulture));
// Console.WriteLine(today.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //2.3
// // hh = 12-hour clock, tt = AM/PM, zzz = full timezone offset (+03:00)
// Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //3-3.1
// DateTime lastMonth = DateTime.Parse("15/06/1998");
// Console.WriteLine(lastMonth);
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //3-3.2
// // DateTime monthDayYear = DateTime.Parse("06/15/1998"); // This will throw an exception in IL culture.
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //4-4.1
// // The format string MUST match the input string exactly, including the '|' character.
// DateTime dayMonthYear = DateTime.ParseExact("1998|06|15", "yyyy|MM|dd", CultureInfo.InvariantCulture);
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //4-4.2
// DateTime monthInWords = DateTime.ParseExact("06/11/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture);
// Console.WriteLine(monthInWords.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //5-5.1
// // Match the exact input format, including hyphens '-' and 24-hour time 'HH'.
// DateTime parseDateAndTime = DateTime.ParseExact("2026-12-31 23:59" , "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
//
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //5-5.2
// // String Interpolation extracting specific formats directly from the variable.
// Console.WriteLine($"The error occurred on {parseDateAndTime:dd} of {parseDateAndTime.ToString("MMMM", CultureInfo.InvariantCulture)}, exactly at {parseDateAndTime:hh:mm tt}"); 
//
// Console.ReadLine();

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// // 1.1
// //Create a variable called currentLocalTime that contains the current local time, and print it to the screen in the default format.
// DateTime currentLocalTime =  DateTime.Now;
// Console.WriteLine(currentLocalTime);
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 1.2
// //Now do the same thing but with UTC time, save it in a variable called currentUtcTime and print it. Look closely -
// //is there an hour difference between the two?
// //How much?
// DateTime currentUtcTime =  DateTime.UtcNow;
// Console.WriteLine(currentUtcTime);
//
// //Yes, this is the difference:
// //28/07/2026 05:12:29 - Local
// //28/07/2026 02:12:29 - UTC 
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 1.3
// //Print a sentence (with string interpolation) that says: "The local time is X and the UTC time is Y" using the two variables you created.
// Console.WriteLine($"The local time is {currentLocalTime} and the UTC time is {currentUtcTime}");
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 2-2.1
// //Take currentLocalTime and print it in short date format only (without time).
// Console.WriteLine(currentLocalTime.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 2.2
// //Print the same variable in time format only, once without seconds and once with seconds.
// Console.WriteLine(currentLocalTime.ToString("hh:mm", CultureInfo.CurrentCulture));
// Console.WriteLine(currentLocalTime.ToString("hh:mm:ss", CultureInfo.CurrentCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 2.3
// //Create a custom format string that prints a date and time in the following format:
// //July 26, 2026 03:45 PM +03:00
// //That is: full month in English, 2-digit day, 4-digit year, 2-digit 12-hour hour, 2-digit minutes, full AM/PM, and timezone offset. Don't forget the `CultureInfo.InvariantCulture`.
// Console.WriteLine(currentLocalTime.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 2.4
// //Now change the previous format so that the month is displayed as a number only (not letters), with 2 digits.
// Console.WriteLine(currentLocalTime.ToString("MM/dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 3-3.1
// //Create a variable graduationDate and get it from the string "22/07/2015" using DateTime.Parse (without CultureInfo).
// //What happens?
// //Does it work?
// //Why (think about the locale of the computer)?
// DateTime graduationDate = DateTime.Parse("22/07/2015");
// Console.WriteLine(graduationDate.ToString("dd/MM/yyyy"));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// // 3-3.2
// //Try parsing the string "13/07/2015" (note - 13!) with regular DateTime.Parse without CultureInfo.
// //What happens now and why is this different from the previous exercise?
// DateTime regularDateTime = DateTime.Parse("13/07/2015");
// Console.WriteLine(regularDateTime.ToString("dd/MM/yyyy"));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// //4-4.1
// //    Create a variable `hireDate` and get it from the string "03-15-2020" using `DateTime.ParseExact`, with the format being month-day-year (as is customary in the US). Remember the using for System.Globalization and CultureInfo.InvariantCulture.
// DateTime hireDate =  DateTime.ParseExact("03-15-2020", "MM-dd-yyyy", CultureInfo.InvariantCulture);
// Console.WriteLine(hireDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// //4.2
// // Create a variable `meetingDate` and get it from the string "2026.07.26" (yes, with periods as separators!) using ParseExact. Hint: You can also put unusual characters like a period inside the format string.
// DateTime meetingDate = DateTime.ParseExact("2026.07.26", "yyyy.MM.dd", CultureInfo.InvariantCulture);
// Console.WriteLine(meetingDate.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// //4.3
// // Create a variable `eventDateTime` and get it from the string "26/07/2026 14:30" (both date and time in the same string!) using ParseExact.
// // You will need to build a format that combines both date and time. Time.
// DateTime eventDateTime = DateTime.ParseExact("26/07/2026 14:30", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
// Console.WriteLine(eventDateTime.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// //5 - Putting it all together (like a mini-project)
// //5.1
// //Write a small program that prompts the user (with `Console.ReadLine()`) for a date of birth in the format "dd/MM/yyyy".
// //Use ParseExact to read it, then print it back in the format "MMMM dd, yyyy" (e.g. "July 26, 1998").
// Console.Write("Hello User! Please insert your birthday date in this exact format: dd/MM/yyyy : ");
// string userInput = Console.ReadLine();
//
// DateTime birthdayDate = DateTime.ParseExact(userInput, "dd/MM/yyyy", CultureInfo.InvariantCulture);
// Console.WriteLine(birthdayDate.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));
// //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// //5.2
// // Write a program that prints the current time (Now), followed by the same time in UTC, and calculates (without using built-in time zone difference functions - just for practice) the difference in hours between the two by printing them side by side.
// DateTime currentTime =  DateTime.Now;
// DateTime currentTimeInUtc =  DateTime.UtcNow;
// Console.WriteLine(currentTimeInUtc);
// Console.WriteLine(currentTime);