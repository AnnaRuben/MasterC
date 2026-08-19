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
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//C# — Basic If Statements
//Weak Points Practice

//Exercise 1 — Answer Check
//Ask the user to answer:
//yes

//The system should also accept the answer in forms like:
//YES
//Yes
//yEs

//If the answer is correct:
//Accepted

//Otherwise:
//Rejected


// Console.Write("Hello User! Please enter the word: yes ");
// string? userAnswer = Console.ReadLine();
//
// if (userAnswer.ToLower() == "yes")
// {
//     Console.WriteLine("Accepted");
// }
// else
// {
//     Console.WriteLine("Rejected");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — User Role
//Ask the user:
//Enter role:
//The valid options are:
//admin
//user

//It does not matter how the user wrote uppercase or lowercase letters.

//For Admin:
//Administrator access

//For User:
//User access

//For any other value:
//Unknown role


// Console.Write("Hello User! Please enter role: ");
// string? userRole = Console.ReadLine();
//
// if (userRole.ToLower() == "admin")
// {
//     Console.WriteLine("Administrator access");
// }
// else
// {
//     if (userRole.ToLower() == "user")
//     {
//         Console.WriteLine("User access");
//     }
//     else
//     {
//         Console.WriteLine("Unknown role");
//     }
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 3 — Membership
//Ask:
//Are you a member?

//If the answer is `yes`, case-insensitive:
//Member access

//Otherwise:
//Guest access


// Console.Write("Hello User! Are you a member? ");
// string? userAnswer = Console.ReadLine();
//
// if (userAnswer.ToLower() == "yes")
// {
//     Console.WriteLine("Member access");
// }
// else
// {
//     Console.WriteLine("Guest access");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Scope
//Exercise 4 — Selected Department
//Ask the user to select:
//qa
//development

//For `qa`, the selected value for the department name would be:
//Quality Assurance

//Otherwise:
//Development

//After the decision is complete, display:
//Department: ...


// Console.Write("Hello User! Please select: qa or development: ");
// string? userSelection = Console.ReadLine();
//
// string department;
//
// if (userSelection.ToLower() == "qa")
// {
//     department = "Quality Assurance";
// }
// else
// {
//     department = "Development";
// }
//
// Console.WriteLine($"Department: {department}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 5 — Selected Status
//Ask:
//Is the task complete?

//If the answer is `yes`, the status is:
//Completed

//Otherwise:
//Not Completed

//After the decision is complete, display:
//Task status: ...


// Console.Write("Hello User! Is the task complete? ");
// string? taskStatus = Console.ReadLine();
//
// bool isComplete = false;
//
// if (taskStatus.ToLower() == "yes")
// {
//     isComplete = true;
// }
//
// string status;
//
// if (isComplete)
// {
//     status = "Completed";
// }
// else
// {
//     status = "Not Completed";
// }
//
// Console.WriteLine($"Task status: {status}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 6 — Greeting
//Ask the user to select:
//morning
//evening

//For `morning`, the greeting is:
//Good morning

//Otherwise:
//Good evening

//After the decision is complete, display:
//Selected greeting: ...


// Console.Write("Hello User! Please select: morning or evening ");
// string userSelection = Console.ReadLine();
//
// string greeting;
//
// if (userSelection.ToLower() == "morning")
// {
//     greeting = "Good morning";
// }
// else
// {
//     greeting = "Good evening";
// }
//
// Console.WriteLine($"Selected greeting: {greeting}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Nested Decisions
//Exercise 7 — Login
//Ask:
//Username:

//If the username is:
//admin
//Ask:
//Password:

//If the password is:
//1234
//Show:
//Login successful

//Other:
//Wrong password

//If the username is not `admin`:
//Unknown user


// Console.Write("Hello User! Please enter your user name: ");
// string? userName = Console.ReadLine();
//
// if (userName.ToLower() == "admin")
// {
//     Console.Write("Please enter your password: ");
//     string? password = Console.ReadLine();
//
//     if (password.ToLower() == "1234")
//     {
//         Console.WriteLine("Login successful");
//     }
//     else
//     {
//         Console.WriteLine("Wrong password");
//     }
// }
// else
// {
//     Console.WriteLine("Unknown user");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 8 — Department Access
//Request:
//Department:

//If the user wrote:
//qa
//Ask:
//Are you a manager?

//If the answer is `yes`:
//QA Manager access

//Other:
//QA Employee access

//If the department is not `qa`:
//Other department

//The textual answers are not case-sensitive.


// Console.Write("Hello User! What is your department? ");
// string? department = Console.ReadLine();
//
// if (department.ToLower() == "qa")
// {
//     Console.Write("Are you a Manager? ");
//     string? userAnswer = Console.ReadLine();
//
//     if (userAnswer.ToLower() == "yes")
//     {
//         Console.WriteLine("QA Manager access");
//     }
//     else
//     {
//         Console.WriteLine("QA Employee access");
//     }
// }
// else
// {
//     Console.WriteLine("Other department");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 9 — Account
//Request:
//Account type:

// If the user wrote:
//premium
//Ask:
//Is the account active?

//If the answer is `yes`:
//Premium account active

// Otherwise:
//Premium account inactive

//If the account type is not Premium:
//Standard account

//Case is not important.


// Console.Write("Hello User! What is your account type? ");
// string? accountType = Console.ReadLine();
//
// if (accountType.ToLower() == "premium")
// {
//     Console.Write("Is the account active? ");
//     string? accountActive = Console.ReadLine();
//
//     if (accountActive.ToLower() == "yes")
//     {
//         Console.WriteLine("Premium account active");
//     }
//     else
//     {
//         Console.WriteLine("Premium account inactive");
//     }
// }
// else
// {
//     Console.WriteLine("Standard account");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 10 — Employee System
//Ask:
//Employee type:

//Options are:
//manager
//employee

//If Manager, ask:
//Security code:

//If the code is:
//5555
//Show:
//Manager access granted

//Otherwise:
//Invalid security code

//If Employee:
//Employee access granted

//For any other type:
//Unknown employee type


// Console.Write("What is your employee type? ");
// string? employeeType = Console.ReadLine();
//
// if (employeeType.ToLower() == "manager")
// {
//     Console.Write("What is your security code? ");
//     string? securityCode = Console.ReadLine();
//
//     if (securityCode == "5555")
//     {
//         Console.WriteLine("Manager access granted");
//     }
//     else
//     {
//         Console.WriteLine("Invalid security code");
//     }
// }
// else
// {
//     if (employeeType.ToLower() == "employee")
//     {
//         Console.WriteLine("Employee access granted");
//     }
//     else
//     {
//         Console.WriteLine("Unknown employee type");
//     }
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Combined Practice
//Exercise 11
//Ask:
//System:

//Options are:
//test
//production


//If the user selected `test`, ask:
//Are you QA?

//If the answer is `yes`, the final value will be:
//QA Test Access

//Otherwise:
//Test Access

// If the user chose something else, the final value will be:
//Production Access

//After all decisions are made, display:
//Access: ...

//Textual comparisons are case-insensitive.


// Console.Write("What is your system? ");
// string? system = Console.ReadLine();
//
// string access;
//
// if (system.ToLower() == "test")
// {
//     Console.Write("Are you QA? ");
//     string? role = Console.ReadLine();
//
//     if (role.ToLower() == "yes")
//     {
//         access = "QA Test Access";
//     }
//     else
//     {
//         access = "Test Access";
//     }
// }
// else
// {
//     access = "Production Access";
// }
//
// Console.WriteLine($"Access: {access}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Final Challenge 
//Request:
//Enter user type:

//The options are:
//admin
//employee

//Case is not important.

//If the user is `admin`, ask:
//Enter access code:

//If the code is:
//ABC
//The final value is:
//Full Access

//Otherwise:
//Restricted Access

//If the user is `employee`, the final value is:
//Employee Access

//If the user entered another user type:
//Unknown Access `

//After all the tests are complete, display:
//Final access: ...


// Console.Write("Enter user type: ");
// string? userType = Console.ReadLine();
//
// string finalAccess;
//
// if (userType.ToLower() == "admin")
// {
//     Console.Write("Enter access code: ");
//     string? accessCode = Console.ReadLine();
//
//     if (accessCode.ToLower() == "abc")
//     {
//         finalAccess = "Full Access";
//     }
//     else
//     {
//         finalAccess = "Restricted Access";
//     }
// }
// else
// {
//     if (userType.ToLower() == "employee")
//     {
//         finalAccess = "Employee Access";
//     }
//     else
//     {
//         finalAccess = "Unknown Access";
//     }
// }
//
// Console.WriteLine($"Final access: {finalAccess}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//C# — Basic If Statements Practice
//Exercise 1 — Task Status
//Create a variable named:
//isFinished

//The variable should be of type `bool`.
//If its value is `true`, print:
//Task completed

//else print:
//Task not completed


// bool isFinished = false;
//
// if (isFinished)
// {
//  Console.WriteLine("Task completed");
// }
// else
// {
//   Console.WriteLine("Task not completed");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — Door Status
//Create a `bool` variable named:
//isDoorOpen

//If the door is open, print:
//The door is open

//else:
//The door is closed


// bool isDoorOpen = false;
//
// if (isDoorOpen)
// {
//  Console.WriteLine("The door is open");
// }
// else
// {
//  Console.WriteLine("The door is closed");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 3 — Connection
//Create a variable:
//isConnected

//If the user is connected, print:
//Connected

//If not:
//Disconnected


// bool isConnected = false;
//
// if (isConnected)
// {
//  Console.WriteLine("Connected");
// }
// else
// {
//   Console.WriteLine("Disconnected");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 4 — Correct Name
//Ask the user:
//Enter your name:

//If the user Enter:
//Anna

//Print:
//Hello Anna

//Otherwise print:
//Unknown user


// Console.Write("Hello User! Please enter your name: ");
// string? firstName = Console.ReadLine();
//
// if (firstName.ToLower() == "anna")
// {
//  Console.WriteLine("Hello Anna");
// }
// else
// {
//  Console.WriteLine("Unknown user");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 5 — Case Insensitive Name
//Ask the user:
//Enter your name:

//The system should recognize the name:
//Anna

//even if the user writes it in different uppercase and lowercase forms.

//For example, all of these should be considered the same name:
//anna
//ANNA
//Anna
//aNnA

//If the name matches:
//Welcome Anna

//Otherwise:
//Welcome guest


// Console.Write("Hello User! Please enter your name: ");
// string? firstName = Console.ReadLine();
//
// if (firstName.ToLower() == "anna")
// {
//  Console.WriteLine("Welcome Anna");
// }
// else
// {
//  Console.WriteLine("Welcome guest");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 6 — Answer Check
//Ask the user:
//Do you like C#?

//The system should receive the answer:
//yes
//Regardless of case.

//If the answer is correct:
//Great!

//else:
//Maybe later


// Console.Write("Hello User! Do you like C#?");
// string? userInput = Console.ReadLine();
//
// if (userInput.ToLower() == "yes")
// {
//  Console.WriteLine("Great!");
// }
// else
// {
//  Console.WriteLine("Maybe later");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 7 — User Role
//Ask:
//Enter role:

//If the user enters:
//admin
//Regardless of case, print:
//Administrator

//Otherwise:
//Regular user


// Console.Write("Hello User! Please enter role:");
// string? userRole = Console.ReadLine();
//
// if (userRole.ToLower() == "admin")
// {
//  Console.WriteLine("Administrator");
// }
// else
// {
//  Console.WriteLine("Regular user");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 8 — Favorite Language
//Ask the user:
//Enter your favorite programming language:

//If they type:
//c#

//Print:
//Good choice

//else:
//Different choice


// Console.Write("Hello User! Please enter your favorite programming language: ");
// string? userInput = Console.ReadLine();
//
// if (userInput.ToLower() == "c#")
// {
//     Console.WriteLine("Good choice");
// }
// else
// {
//     Console.WriteLine("Different choice");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Nested If Statements
//Exercise 9 — Member Check
//Ask the user:
//Enter your name:

//If the name is:
//anna

//Check within the same path a `bool` variable condition called:
//isMember

//If `isMember` is `true`:
//Welcome Anna
//Member access granted

//If `isMember` is `false`:
//Welcome Anna
//Member access denied

//If the name is not Anna at all:
//Unknown user

//The name comparison should work regardless of uppercase or lowercase letters.


// Console.WriteLine("Hello User! Please enter your name:");
// string? firstName = Console.ReadLine();
//
// bool isMember = false;
//
// if (firstName.ToLower() == "anna")
// {
//     if (isMember)
//     {
//         Console.WriteLine("Welcome Anna");
//         Console.WriteLine("Member access granted");
//     }
//     else
//     {
//         Console.WriteLine("Welcome Anna");
//         Console.WriteLine("Member access denied");
//     }
// }
// else
// {
//     Console.WriteLine("Unknown user");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 10 — Admin Permission
//Ask the user:
//Enter role:

//If the role is:
//admin

//Check a `bool` variable named:
//hasPermission

//If permission is granted:
//Admin recognized
//Permission granted

//If no permission is granted:
//Admin recognized
//Permission denied

//If the role is not `admin`:
//Not an administrator

//Again, uppercase and lowercase letters are not important here.


// Console.Write("Hello User! Please enter role: ");
// string? userRole = Console.ReadLine();
//
// bool hasPermission = false;
//
// if (userRole.ToLower() == "admin")
// {
//     if (hasPermission)
//     {
//         Console.WriteLine("Admin recognized");
//         Console.WriteLine("Permission granted");
//     }
//     else
//     {
//         Console.WriteLine("Admin recognized");
//         Console.WriteLine("Permission denied");
//     }
// }
// else
// {
//     Console.WriteLine("Not an administrator");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// ## Exercise 11 — Registered Student
//
// Request:
//
// ```text
// Enter student name:
// ```
//
// If the name is:
//
// ```text
// dan
// ```
//
// Check variable:
//
// ```csharp
// isRegistered
// ```
//
// If it is `true`:
//
// ```text
// Student found
// Registration confirmed
// ```
//
// If it is `false`:
//
// ```text
// Student found
// Not registered
// ```
//
// If the name is different:
//
// ```text
// Student not found
// ```
//
// ---
//
// # 🔹 Variable Scope Practice
//
// ## Exercise 12 — Last Name
//
// Request:
//
// ```text
// Enter first name:
// ```
//
// Create a variable named:
//
// ```csharp
// lastName
// ```
//
// If the first name is:
//
// ```text
// tim
// ```
//
// The value of `lastName` should be:
//
// ```text
// Corey
// ```
//
// Otherwise it should be For:
//
// ```text
// Smith
// ```
//
// **After all the conditions have been met**, print `lastName`.
//
// ---
//
// ## Exercise 13 — Access Message
//
// Prompt:
//
// ```text
// Enter username:
// ```
//
// Create a variable named:
//
// ```csharp
// message
// ```
//
// If the username is:
//
// ```text
// admin
// ```
//
// Enter `message`:
//
// ```text
// Administrator access
// ```
//
// Otherwise enter:
//
// ```text
// User access
// ```
//
// After the conditions have been met, print `message`.
//
// ---
//
// ## Exercise 14 — Department
//
// Prompt:
//
// ```text
// Enter employee name:
//
// ```
//
// Create a variable:
//
// ```csharp
// department
// ```
//
// If the name is:
//
// ```text
// david
// ```
//
// The value will be:
//
// ```text
// Development
// ```
//
// Otherwise:
//
// ```text
// General
// ```
//
// After the condition print:
//
// ```text
// Department: [department]
//
// ```
//
// ---
//
// # 🔥 Final Challenge — Basic Login System
//
// Create a program that prompts:
//
// ```text
// Enter username:
//
// ```
//
// The special user in the system is:
//
// ```text
// anna
// ```
//
// The name should be case-insensitive.
//
// If it is Anna, check a `bool` variable named:
//
// ```csharp
// isActive
// ```
//
// If the user is active, the program should set the variable named:
//
// ```csharp
// accessMessage
// ```
//
// to the value:
//
// ```text
// Active user
// ```
//
// If the user is inactive, the value should be:
//
// ```text
// Inactive user
// ```
//
// If the username is not Anna:
//
// ```text
// Unknown user
// ```
//
// At the end of the program, in the case that the user is Anna, print the value found in `accessMessage`.