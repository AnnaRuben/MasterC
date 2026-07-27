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

Console.WriteLine(today.ToString("HH:m:s zzz", CultureInfo.InvariantCulture));
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2.3
Console.WriteLine(today.ToString("MMMM dd, yyyy HH:mm zz", CultureInfo.InvariantCulture));
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//3-3.1
DateTime lastMonth = DateTime.Parse("15/06/1998");
Console.WriteLine(lastMonth);

Console.ReadLine();

















//Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));

//DateTime today = DateTime.UtcNow;

// DateTime birthday = DateTime.Parse("15/06/1998");
//
// DateTime birthday = DateTime.ParseExact("11/15/1998", "M/d/yyyy", CultureInfo.InvariantCulture);
//
// DateTime birthday = DateTime.ParseExact("06/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);
//
// Console.WriteLine(birthday.ToString());
//
// Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));


