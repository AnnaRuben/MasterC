//* `string`
//* Variables
//* Assignment
//* `Console.WriteLine`
//* String Concatenation (`+`)
//* String Interpolation (`$""`)
//* Escape Characters
//* Verbatim Strings (`@`)
//* `$@`
//* Naming Convention (Camel Case)
//* `string.Empty`

//Exercise 1 - Creating Variables
//Task
//Create the following variables.

//They should all be of type `string`.

//* firstName
//* lastName
//* favoriteColor
//* city
//* country

//They should all start with:
//string.Empty

//For example:
//string firstName = string.Empty;

string firstName = string.Empty;
string favoriteColor  = string.Empty;
string city = string.Empty;
string country  = string.Empty;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2 - Assign Values

//After you have created the variables, give each one a value.
//For example:
//firstName = "Tim";

firstName = "Tim";
favoriteColor = "Pink";
city = "Tel Aviv";
country  = "Israel";

//When finished, print each variable on a separate line.

Console.WriteLine = $@("firstName /n favoriteColor /n city /n country");

// Sample output:
//
// ```
// Tim
// Corey
// Blue
// Boise
// USA
// ```
//
// ---
//
// # Exercise 3 - Overwriting Variables
//
// Create a variable:
//
// ```csharp
// string favoriteFood = string.Empty;
// ```
//
// Give it three different values ​​one after the other.
//
// For example:
//
// ```csharp
// favoriteFood = "Pizza";
//
// favoriteFood = "Burger";
//
// favoriteFood = "Pasta";
// ```
//
// Print it.
//
// ### Question
//
// What value will be printed?
//
// ---
//
// # Exercise 4 - Numbers Inside Strings
//
// Create variables:
//
// ```csharp
// string age = string.Empty;
//
// string zipCode = string.Empty;
// ```
//
// Put them in:
//
// ```
// 25
//
// 90210
// ```
//
// Print them.
//
// Question:
//
// Are these numbers or Strings?
//
// Why?
//
// ---
//
// # Exercise 5 - Concatenation
//
// Create:
//
// ```csharp
// string firstName
//
// string lastName
// ```
//
// Print:
//
// ```
// John Smith
// ```
//
// using:
//
// ```csharp
// +
// ```
//
// only.
//
// Hint:
//
// ```
// " "
// ```
//
// is a String.
//
// ---
//
// # Exercise 6 - Greeting
//
// Using Concatenation only, print:
//
// ```
// Hello John Smith
// ```
//
// ---
//
// # Exercise 7 - String Interpolation
//
// Print the exact same sentence:
//
// ```
// Hello John Smith
// ```
//
// But this time using:
//
// ```csharp
// $""
// ```
//
// instead of `+`.
//
// ---
//
// # Exercise 8 - More Interpolation
//
// Create:
//
// ```csharp
// firstName
//
// lastName
//
// city
// ```
//
// Print:
//
// ```
// John Smith lives in New York.
// ```
//
// Using String Interpolation.
//
// ---
//
// # Exercise 9 - Empty String
//
// Create two variables:
//
// ```csharp
// string firstName = string.Empty;
//
// string lastName = "";
// ```
//
// Print both.
//
// ### Questions
//
// Is there a difference in the output?
//
// Which style does Tim Corey prefer to use?
//
// ---
//
// # Exercise 10 - Escape Characters
//
// Print:
//
// ```
// Hello
// World
// ```
//
// Using only one String.
//
// Hint:
//
// ```
// \n
// ```
//
// ---
//
// # Exercise 11 - Quotes
//
// Print:
//
// ```
// My name is "Tim".
// ```
//
// Using only one String.
//
// Hint:
//
// There is an Escape Character for quotes as well.
//
// ---
//
// # Exercise 12 - File Path
//
// Save in variable:
//
// ```
// C:\Temp\Demo
// ```
//
// Without using `@`.
//
// ---
//
// # Exercise 13 - Verbatim String
//
// Now do exactly the same thing,
//
// but this time use:
//
// ```csharp
// @
//
// ```
//
// ---
//
// # Exercise 14 - Mixed Verbatim + Interpolation
//
// Create:
//
// ```csharp
// string firstName = "John";
// ```
//
// Print:
//
// ```
// The file for John is at C:\SampleFile
// ```
//
// Using:
//
// ```csharp
// $@
//
// ```
//
// ---
//
// # Exercise 15 - Variable Names
//
// Mark which variable names are correct and which are not.
//
// ```
// string firstName
//
// string FirstName
//
// string myFirstName
//
// string first_name
//
// string strFirstName
//
// string fName
//
// string a
//
// string employeeFirstName
//
// string employeeLastName
// ```
//
// And next to each one write:
//
// ```
// Good
//
// or
//
// Bad
// ```
//
// And explain why.
//
// ---
//
// # Exercise 16 - Fix the Code
//
// Fix the following code according to Tim Corey's rules:
//
// ```csharp
// string a = "";
// string b = "";
// string c = "";
//
// a = "John";
// b = "Smith";
// c = "Blue";
//
// Console.WriteLine(a + " " + b + " likes " + c);
// ```
//
// ---
//
// # Exercise 17 - Find the Mistakes
//
// Find at least **8 mistakes** in the code.
//
// ```csharp
// string StrFirstName = "";
//
// string lastname = "";
//
// string fName = "";
//
// StrFirstName = "Tim";
//
// lastname = "Corey";
//
// Console.WriteLine(StrFirstName+lastname);
//
// Console.WriteLine($"Hello"+StrFirstName);
//
// string file = "C:\Temp\Test";
//
// Console.WriteLine(file);
//
// ```
//
// Don't correct.
//
// Just write down all the mistakes.
//
// ---
//
// # Exercise 18 - Final Challenge
//
// Write a program that creates the variables:
//
// * firstName
// * lastName
// * favoriteColor
// * favoriteFood
// * city
//
// and prints exactly the following output:
//
// ```
// Hello John Smith!
//
// Your favorite color is Blue.
//
// Your favorite food is Pizza.
//
// You live in New York.
//
// Your file is stored at:
//
// C:\Users\John\Documents
// ```
//
// Requirements:
//
// * Use `string.Empty`
// * Assign to each variable
// * Use String Interpolation
// * Use `\n`
// * Use `$@`
// * Use Camel Case variable names
// * Do not use single letter variables (`a`, `b`, `c`)
// * Do not use Hungarian Notation
// * Use `Console.WriteLine`
//
// ---
//
// ## Bonus Challenge (Tim Corey style)
//
// Write a program that displays a business card:
//
// ```
// --------------------------------
//
// Name: John Smith
//
// City: New York
//
// Favorite Color: Blue
//
// Favorite Food: Pizza
//
// Email: john.smith@gmail.com
//
// --------------------------------
// ```
//
// Use:
//
// * `string.Empty`
// * String Interpolation
// * `\n`
// * At least once In `$@`
//
// If you solve all these exercises without the help of a solution, you will have an excellent understanding of the whole **string** topic at the level that Tim Corey teaches at the beginning of his C# course.