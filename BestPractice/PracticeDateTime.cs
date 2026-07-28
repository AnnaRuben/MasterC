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


//1-1.1
DateTime today = DateTime.Now;
Console.WriteLine(today);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.2
DateTime myCurrentTimeUtc = DateTime.UtcNow;
Console.WriteLine(myCurrentTimeUtc);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.3
//Yes, there is a difference in Israel time.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//1.4
//Yes, the seconds and the minutes are changing.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2-2.1 + 2.2
Console.WriteLine(today.ToString("dd/MM/yy", CultureInfo.InvariantCulture));
Console.WriteLine(today.ToString("HH:mm:ss", CultureInfo.InvariantCulture));

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2.3
// hh = 12-hour clock, tt = AM/PM, zzz = full timezone offset (+03:00)
Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//3-3.1
DateTime lastMonth = DateTime.Parse("15/06/1998");
Console.WriteLine(lastMonth);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//3-3.2
// DateTime monthDayYear = DateTime.Parse("06/15/1998"); // This will throw an exception in IL culture.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//4-4.1
// The format string MUST match the input string exactly, including the '|' character.
DateTime dayMonthYear = DateTime.ParseExact("1998|06|15", "yyyy|MM|dd", CultureInfo.InvariantCulture);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//4-4.2
DateTime monthInWords = DateTime.ParseExact("06/11/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(monthInWords.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//5-5.1
// Match the exact input format, including hyphens '-' and 24-hour time 'HH'.
DateTime parseDateAndTime = DateTime.ParseExact("2026-12-31 23:59" , "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//5-5.2
// String Interpolation extracting specific formats directly from the variable.
Console.WriteLine($"The error occurred on {parseDateAndTime:dd} of {parseDateAndTime.ToString("MMMM", CultureInfo.InvariantCulture)}, exactly at {parseDateAndTime:hh:mm tt}"); 

Console.ReadLine();