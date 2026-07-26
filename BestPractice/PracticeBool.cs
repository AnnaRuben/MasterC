//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BestPractice
//{
//    internal class PracticeBool
//    {
//    }
//}

////1.1
//bool isLoggedIn = false;
//Console.WriteLine(isLoggedIn);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////1.2 - תוקן: bool רגיל בלי ערך התחלתי, בלי nullable
//bool hasPermission;
//Console.WriteLine(hasPermission); // שימי לב: זה לא יתקמפל! שגיאה: Use of unassigned local variable 'hasPermission'
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////1.3
//bool isRaining = true;
//bool isCold = true;
//Console.WriteLine(isRaining);
//Console.WriteLine(isCold);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////2-2.1
//bool isAcive = true;
//Console.WriteLine(isAcive);
//Console.WriteLine(!isAcive);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////2.2
//bool isFinished = false;
//Console.WriteLine(isFinished);

//isFinished = !isFinished;
//Console.WriteLine(isFinished);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////2.3 - תוקן: שתי הפיכות נפרדות ברצף, בלי &&
//bool isOnline = true;
//isOnline = !isOnline;
//isOnline = !isOnline;
//Console.WriteLine(isOnline);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////3-3.1
//bool canVote = true;

//if (canVote)
//{
//    Console.WriteLine("You can Vote!");
//}
//else
//{
//    Console.WriteLine("You can't Vote.");
//}
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
////3.2 - תוקן: הודעות ברורות יותר
//bool isMember = false;

//if (!isMember)
//{
//    Console.WriteLine("Sorry, you are not a member.");
//}
//else
//{
//    Console.WriteLine("Congrats! You are a member.");
//}
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////3.3
//bool hasAccess = false;

//if (hasAccess)
//{
//    Console.WriteLine("Welcome to my App.");
//}
//else
//{
//    Console.WriteLine("Sorry ,you aren't authorized");
//}
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////4.1
//bool isValid = true;

////4.2
//isValid = !isValid;

////4.3
//Console.WriteLine(isValid);

////4.4 - תוקן: הודעות ברורות ותואמות למצב בפועל
//if (isValid)
//{
//    Console.WriteLine("isValid is true.");
//}
//else
//{
//    Console.WriteLine("isValid is false.");
//}

////4.5
//bool imTheBestInBoolVariables = false;
//Console.WriteLine(!imTheBestInBoolVariables);
//Console.WriteLine(imTheBestInBoolVariables);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////5.1 - תוקן: הוספת הבדיקה עם if וההדפסה על סמך התוצאה
//int wholeNumber = 11;
//bool biggerThanEleven;

//if (wholeNumber > 10)
//{
//    biggerThanEleven = true;
//}
//else
//{
//    biggerThanEleven = false;
//}

//Console.WriteLine(biggerThanEleven);
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

////5.2
//bool isWeekend = true;

//if (!isWeekend)
//{
//    Console.WriteLine("Time to rest.");
//}
//else
//{
//    Console.WriteLine("Time to work.");
//}