//C# Practice — Basic If Statements
//Part 1 — Basic bool + if
//Exercise 1 — Is Complete
//Create a variable named:
//isComplete

//It should represent whether a task is complete.

//If the task is complete, the program should display:
//The task is complete.


// bool isComplete =  false;
//
// if (isComplete)
// {
//     Console.WriteLine("The task is complete.");
// }
// else
// {
//     Console.WriteLine("The task is not complete.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — Is Logged In
//Create a variable named:
//isLoggedIn

//If the user is logged in, display:
//Welcome back.

//At the end of the program, regardless of the user's state, display:
//End of program.


// bool isLoggedIn = true;
//
// if (isLoggedIn)
// {
//     Console.WriteLine("Welcome back.");
// }
// else
// {
//     Console.WriteLine("You are not logged in.");
// }
//
// Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 3 — Door Status
//Create a variable named:
//isDoorOpen

//If the door is open, display:
// The door is open.


// bool isDoorOpen = true;
//
// if (isDoorOpen)
// {
//     Console.WriteLine("The door is open.");
// }
// else
// {
//     Console.WriteLine("The door is close.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 4 — Download
//Create a variable named:
//isDownloadComplete

//If the download is complete, display:
//Download complete.

//At the end of the program, always display:
//Program finished.


// bool isDownloadComplete = true;
//
// if (isDownloadComplete)
// {
//     Console.WriteLine("Download complete.");
// }
// else
// {
//     Console.WriteLine("Download failed.");
// }
//
// Console.WriteLine("Program finished.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 2 — if + else
//Exercise 5 — Light
//Create a variable named:
//isLightOn

//The program should display one of two messages:
//The light is on.
//Or:
//The light is off.


// bool isLightOn = false;
//
// if (isLightOn)
// {
//     Console.WriteLine("The light is on.");
// }
// else
// {
//     Console.WriteLine("The light is off.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 6 — File Status
//Create a variable named:
//isFileSaved

//If the file was saved:
//The file was saved.

//Else:
//The file was not saved.

//At the end:
//End of program.


// bool isFileSaved = true;
//
// if (isFileSaved)
// {
//     Console.WriteLine("The file was saved.");  
// }
// else
// {
//     Console.WriteLine("The file was not saved.");
// }
//
// Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 7 — Test Result
//Create a variable named:
//isTestPassed

//The program should display:
//The test passed.
//Or:
//The test failed.


// bool isTestPassed = true;
//
// if (isTestPassed)
// {
//     Console.WriteLine("The test passed.");
// }
// else
// {
//     Console.WriteLine("The test failed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 8 — Server Status
//Create a variable named:
//isServerOnline
//If the server is online.

//Else:
//Server is offline.


// bool isServerOnline = false;
//
// if (isServerOnline)
// {
//     Console.WriteLine("Server is Online");
// }
// else
// {
//     Console.WriteLine("Server is offline.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 3 — String Comparison
//Exercise 9 — First Name
//Ask the user to enter their first name.

//If the name is:
//Anna
//Display:
//Hello Anna.

//Else display:
//Hello guest.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// if (firstName.ToLower() == "anna")
// {
//     Console.WriteLine("Hello Anna.");
// }
// else
// {
//     Console.WriteLine("Hello guest.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 10 — Username
//Ask the user:
//Enter your username:

//If the user entered:
//admin

//Display:
//Welcome administrator.

//Else display:
//Welcome user.


// Console.Write("Hello User! Please  enter your username:");
// string? username = Console.ReadLine();
//
// if (username.ToLower() == "admin")
// {
//     Console.WriteLine("Welcome administrator.");
// }
// else
// {
//     Console.WriteLine("Welcome user.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 11 — Favorite Language
//Ask the user to enter their favorite programming language.

//If they entered:
//C#
//Display:
//Great choice!

//Else display:
//Interesting choice.


// Console.Write("Hello User! Please enter your favorite programming language: ");
// string? favoriteProgrammingLanguage = Console.ReadLine();
//
// if (favoriteProgrammingLanguage.ToLower() == "c#")
// {
//     Console.WriteLine("Great choice!");
// }
// else
// {
//     Console.WriteLine("Interesting choice.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 4 — Case Sensitivity + .ToLower()
//Exercise 12 — Name Comparison
//Ask the user to enter their name.

//The program should recognize the name:
//anna
//even if the user has written it in different combinations of uppercase and lowercase letters.

//When the name is correct, display:
//Welcome Anna.

//Else display:
//Welcome guest.


// Console.Write("Hello User! Please enter your name: ");
// string name = Console.ReadLine();
//
// if (name.ToLower() == "anna")
// {
//     Console.WriteLine("Welcome Anna.");
// }
// else
// {
//     Console.WriteLine("Welcome guest.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 13 — Answer Yes
//Ask the user to enter:
//yes
//The program should also accept different uppercase and lowercase letters.

//If the value is correct:
//You selected yes.

//Else:
//You did not select yes.


// Console.Write("Hello User! Please write the word : yes");
// string? userInput = Console.ReadLine();
//
// if (userInput.ToLower() == "yes")
// {
//     Console.WriteLine("You selected yes.");
// }
// else
// {
//     Console.WriteLine("You did not select yes.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 14 — Programming Language
//Ask:
//What programming language are you learning?

//If the user entered c#, regardless of case, display:
//You are learning C#.

//Else:
//You entered another language.


// Console.Write("Hello User! What programming language are you learning? ");
// string? userInput = Console.ReadLine();
//
// if (userInput.ToLower() == "c#")
// {
//     Console.WriteLine("You are learning C#.");
// }
// else
// {
//     Console.WriteLine("You entered another language.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 5 — Variables + Scope
//Exercise 15 — Last Name
//Ask the user to enter a first name.

//Also create a variable named:
//lastName

//If the first name is:
//tim
//The value of lastName should be:
//Corey

//Otherwise the value should be:
//Smith

//After the condition ends, display the value of:
//lastName


// Console.Write("Hello User! Please enter your first name: ");
// string? firstName = Console.ReadLine();
//
// string lastName;
//
// if (firstName.ToLower() == "tim")
// {
//     lastName = "Corey";
// }
// else
// {
//     lastName = "Smith";
// }
//
// Console.WriteLine(lastName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 16 — User Role
//Ask the user to enter a username.

//Create a variable named:
//userRole

//If the username is:
//anna
//The value of userRole will be:
//Tester

//Otherwise:
//Guest

//After the condition ends, display:
//Role: [userRole]


// Console.Write("Hello User! Please enter a user name: ");
// string? userName = Console.ReadLine();
//
// string userRole;
//
// if (userName.ToLower() == "anna")
// {
//     userRole = "Tester";
// }
// else
// {
//     userRole = "Guest";
// }
//
// Console.WriteLine($"Role: {userRole}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 17 — Environment
//Ask the user to enter:
//qa
//Or another value.

//Create a variable named:
//environmentName

//If the user entered qa, the value should be:
//QA Environment

//Otherwise:
//Production Environment

//Only display the variable after the if/else statement has finished.


// Console.Write("Hello User! Please enter the word: qa ,or another value of your choice: ");
// string? userInput = Console.ReadLine();
//
// string environmentName;
//
// if (userInput.ToLower() == "qa")
// {
//     environmentName = "QA Environment";
// }
// else
// {
//     environmentName = "Production Environment";
// }
//
// Console.WriteLine(environmentName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 6 — Nested if
//Exercise 18 — Special User
//Ask the user to enter a first name.

//If the name is:
//anna
//Display:
//Hello Anna.

//When it comes to Anna, you also need to check a variable:
//isAdmin

//If the variable corresponds to the administrator status, additionally display:
//Administrator access.

//If the name is not Anna:
//Hello guest.


// bool isAdmin = true;
//
// Console.Write("Hello User! Please enter your first name: ");
// string? firstName = Console.ReadLine();
//
// if (firstName.ToLower() == "anna")
// {
//     Console.WriteLine("Hello Anna.");
//
//     if (isAdmin)
//     {
//         Console.WriteLine("Administrator access.");
//     }
// }
// else
// {
//     Console.WriteLine("Hello guest.");
// }
 //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 19 — Logged In User
//Create:
//isLoggedIn
//And ask the user to enter their name.

//When the user is logged in:
//User is logged in.
//And in that state, check whether their name is:
//anna
//If so:
//Welcome Anna.

//If the user is not logged in:
//User is not logged in.


 // bool isLoggedIn = true;
 //
 // Console.Write("Hello User! Please enter your name: ");
 // string? firstName = Console.ReadLine();
 //
 // if (isLoggedIn)
 // {
 //     Console.WriteLine("User is logged in.");
 //
 //     if (firstName.ToLower() == "anna")
 //     {
 //         Console.WriteLine("Welcome Anna.");
 //     }
 // }
 // else
 // {
 //     Console.WriteLine("User is not logged in.");
 // }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 20 — QA System
//Create a variable:
//isSystemOnline

//Ask the user to enter a username.

//If the system is online:
//System online.

//If in this state the username is:
//tester
//Also display:
//QA user detected.

//If the system is offline:
//System offline.


 // Console.Write("Hello User! Please enter your username: ");
 // string? username = Console.ReadLine();
 //
 // bool isSystemOnline = false;
 //
 // if (isSystemOnline)
 // {
 //     Console.WriteLine("System online.");
 //
 //     if (username.ToLower() == "tester")
 //     {
 //         Console.WriteLine("QA user detected.");
 //     }
 // }
 // else
 // {
 //     Console.WriteLine("System offline.");
 // }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 7 — Code Muscle
//Exercise 21 — Coffee Shop
//Create a program with:
//bool that represents whether the coffee shop is open.

//One message when it is open.

//Another message when it is closed.

//Another message that will always appear at the end of the program.


// bool isCoffeeShopOpen = true;
//
// if (isCoffeeShopOpen)
// {
//     Console.WriteLine("Coffee Shop is open");
// }
// else
// {
//     Console.WriteLine("Coffee Shop is closed");
// }
//
// string openingHours = string.Empty;
// openingHours = "Welcome to \"Anna\" Cafe\nOpening hours:\nSunday - Thursday between the hours: 10:00 - 22:00\nFriday - Saturday between the hours: 10:00 - 23:59\nHoliday evenings, Chol Hamoed, holidays between the hours: 11:00 - 23:00";
// Console.WriteLine(openingHours);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 22 — Known User
//Prompt the user for a name.

//If the name is tim, case-insensitive:
//Hello Mr. Corey.

//otherwise display a greeting with the name the user actually entered.


// Console.Write("Hello User! Please enter your name: ");
// string? userName = Console.ReadLine();
//
// if (userName.ToLower() == "tim")
// {
//     Console.WriteLine("Hello Mr. Corey.");
// }
// else
// {
//     Console.Write($"Hello {userName}!");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 23 — Employee Department
//Prompt the user for a name.

//Create a variable:
//department

//If the name is:
//anna

//The department will be:
//QA

//Otherwise:
//General

//At the end of the condition, display the name of the department.


// Console.Write("Hello User! Please enter your first name: ");
// string? firstName = Console.ReadLine();
//
// string department;
//
// if (firstName.ToLower( ) == "anna")
// {
//     department = "QA";
// }
// else
// {
//     department = "General";
// }
//
// Console.WriteLine(department);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 24 — Access Check
//Create:
//hasAccess

//If there is access, ask for a username.

//If the username is:
//admin
//Display:
//Administrator.

//If there is access ,but it is a different name:
//Standard user.

//If there is no access:
//Access denied.


 // bool hasAccess = true;
 //
 // if (hasAccess)
 // {
 //     Console.Write("Hello User! Please enter your user name: ");
 //     string? userName = Console.ReadLine();
 //
 //     if (userName.ToLower() == "admin")
 //     {
 //         Console.WriteLine("Administrator.");
 //     }
 //     else
 //     {
 //         Console.WriteLine("Standard user.");
 //     }
 // }
 // else
 // {
 //     Console.WriteLine("Access denied.");
 // }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Final Challenge — Basic If Statements Center
//Write a single program that combines all the material from the file.

//The program should:
//Prompt the user for their first name.

//Contain a bool variable named:
//isSystemOnline

//When the system is offline, display:
//System is offline.

//When the system is online, display:
//System is online.

//When the system is online, also check the username.
//If the name is:
//anna
//Regardless of case, display:
// Welcome Anna.

// For another name:
// Welcome [name].

// Create a variable named:
// userType

// For Anna its value will be:
// QA Tester

// For another user:
// Standard User

// After all conditions are met, display:
// User type: [userType]
// And the last line always:
// End of program.


 // Console.Write("Hello User! Please enter your first name: ");
 // string? firstName = Console.ReadLine();
 //
 // bool isSystemOnline = true;
 //
 // string userType;
 //
 // if (isSystemOnline)
 // {
 //     Console.WriteLine("System is online.");
 //
 //     if (firstName.ToLower() == "anna")
 //     {
 //         Console.WriteLine("Welcome Anna.");
 //         userType = "QA Tester";
 //     }
 //     else
 //     {
 //         Console.WriteLine($"Welcome {firstName}.");
 //         userType = "Standard User";
 //     }
 //
 //     Console.WriteLine($"User type: {userType}");
 // }
 // else
 // {
 //     Console.WriteLine("System is offline.");
 // }
 //
 // Console.WriteLine("End of program.");
