//C# — Advanced If Statements Practice
//Exercise 1 — Full Name Check
//Ask the user for:
//First name
//Last name

//The program should behave as follows:
//If the first name is `john` and the last name is `smith`:
//Welcome John Smith

//If only one of the two names matches:
//Part of your name matched

//If neither matches:
//Name not recognized

//Uppercase and lowercase letters should not matter.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "john" && lastName.ToLower() == "smith")
// {
//     Console.WriteLine("Welcome John Smith");
// }
// else if  (firstName.ToLower() == "john" || lastName.ToLower() == "smith")
// {
//     Console.WriteLine("Part of your name matched");
// }
// else
// {
//     Console.WriteLine("Name not recognized");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — Employee Name
//Ask the user for:
//First name
//Last name

//Rules:
//First name `sarah` and last name `brown`:
//Employee found

//First name `sarah`, but a different last name:
//First name found

//Last name `brown`, but a different first name:
//Last name found

//Anything else:
//Employee not found

//Uppercase and lowercase letters should not matter.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What  is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "sarah" && lastName.ToLower() == "brown")
// {
//     Console.WriteLine("Employee found");
// }
// else if (firstName.ToLower() == "sarah")
// {
//     Console.WriteLine("First name found");
// }
// else if (lastName.ToLower() == "brown")
// {
//     Console.WriteLine("Last name found");
// }
// else
// {
//     Console.WriteLine("Employee not found");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 3 — Two Separate Checks
//Ask the user for:
//First name
//Last name

//If the first name is:
//David
//printing:
//Special first name

//If the last name is:
//green
//printing:
//Special last name

//Both messages must be able to appear during the same program execution.

//If the last name is not `green`, print:
//Regular last name

//Uppercase and lowercase letters should not matter.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "david")
// {
//     Console.WriteLine("Special first name");
// }
//
// if (lastName.ToLower() == "green")
// {
//     Console.WriteLine("Special last name");
// }
// else
// {
//     Console.WriteLine("Regular last name");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 4 — Access Status
//Create:
//bool hasAccess

//Set its value yourself to either `true` or `false`.

//If access is available:
//Access granted

//Otherwise:
//Access denied



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// ## Exercise 5 — Exact Age
// Create:
// int age
// If the age is exactly `25`:
// Perfect age
// Otherwise:
// Different age
// ## Exercise 6 — Not This Age
// Create:
// int age
// If the age is anything except `30`:
// Age is not 30
// If the age is `30`:
// Age is 30
// ## Exercise 7 — Minimum Age
// Create:
// int age
// Rules:
// * Age `18` or higher:
// Allowed
// * Anything below `18`:
// Not allowed
// ## Exercise 8 — Maximum Age
// Create:
// int age
// Rules:
// * Age `65` or lower:
// Standard group
// * Anything above `65`:
// Senior group
// ## Exercise 9 — Number Range
// Create:
// int number
// Print:
// Inside range
// only when the number is between `20` and `29`, inclusive `20` but not including `30`.
// For every other value:
// Outside range
// ## Exercise 10 — Age Groups
// Create:
// int age
// Rules:
// * From `10` up to but not including `20`:
// Teen range
// * From `20` up to but not including `30`:
// Twenties
// * From `30` up to but not including `40`:
// Thirties
// * Anything else:
// Another age
// ## Exercise 11 — Special Name
// Ask for:
// * First name
// * Last name
// Print:
// Special user
// when **at least one** of these is true:
// * First name is `anna`
// * Last name is ``stone''
// Otherwise:
// Regular user
// Uppercase and lowercase letters should not matter.
// ## Exercise 12 — Exact Person
// Ask for:
// * First name
// * Last name
// Only the exact combination:
// michael
// Jones
// should print:
// Exact person found
// Any other combination should print:
// Different person
// Uppercase and lowercase letters should not matter.
// ## Exercise 13 — Login Classification
// Ask for:
// * First name
// * Last name
// Rules:
// ### `alex` + `king`
// Full match
// ### Only `alex`
// First name match
// ### Only `king`
// Last name match
// ### Neither
// No match
// Uppercase and lowercase letters should not matter.
// ## Exercise 14 — Two Valid Age Ranges
// Create:
// int age
// The valid age groups are:
// * `20` through `29`
// * `60` through `69`
// If the age belongs to either group:
// Accepted age group
// Otherwise:
// Age group not accepted
// Pay attention to the exact beginning and end of each range.
// ## Exercise 15 — Three Valid Age Ranges
// Create:
// int age
// The following age ranges are accepted:
// * `10` through `19`
// * `30` through `39`
// * `70` through `79`
// If the age belongs to one of them:
// Special age range
// Otherwise:
// Regular age range
// # Exercise 16 — Boundary Test
// Create:
// int score
// Rules:
// * `score` from `50` through `59`:
// Level A
// * `score` from `60` through `69`:
// Level B
// * `score` from `70` through `79`:
// Level C
// * Anything else:
// No level
// Test your program yourself with values ​​that are exactly on the boundaries.
// Exercise 17 — Name And Age
// Ask for:
// First name
// Last name
// Also create:
// int age
// Rules:
// If:
// First name is Tom
// Last name is white
// Age is between 20 and 29
// printing:
// Complete match
// If the name matches but the age does not:
// Name matched
// Otherwise:
// No complete match
// Uppercase and lowercase letters in the names should not matter.
// Exercise 18 — Multiple Independent Results
// Ask for:
// First name
// Last name
// Also create:
// int age
// The following checks must work independently:
// If the first name is marked:
// Special first name
// If the last name is black:
// Special last name
// If the age is between 40 and 49:
// Special age
// It must be possible for all three messages to appear during one execution.
// Exercise 19 — Customer Classification
// Ask for:
// First name
// Last name
// Create:
// int age
// Rules:
// First name Emma, ​​last name Wood, and age between 30 and 39
// VIP customer
// First name Emma or last name Wood
// Known customer
// Age between 60 and 69
// Senior customer
// Everything else
// Standard customer
// Uppercase and lowercase letters in names should not matter.
// Exercise 20 — Complex Range Check
// Create:
// int age
// A person is accepted if their age belongs to either:
// 40–49
// or:
// 70–79
// Print:
// Accepted
// Otherwise:
// Rejected
// Your program must correctly handle at least these values ​​when you test it:
// 39
// 40
// 49
// 50
// 69
// 70
// 79
// 80
// 🔥 Final C