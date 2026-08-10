// C# Master Course — Type Conversions Practice
//Part 1 — String to Integer
//Exercise 1 — Your Age
//Write a program that:
//Asks the user to enter their age.
//Gets the value from the Console.

//Converts the received value to an integer.

//Prints the age after the conversion.


//  Console.Write("Hello, User! How old are you?");
//  string? ageAsText = Console.ReadLine();
//
// int age = int.Parse(ageAsText);
//
// Console.WriteLine(age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — Age Next Year
//Write a program that:
//Asks the user to enter an age.
//Gets the value as text.

//Converts it to an integer.

//Calculates the age in a year.
//Prints the result.


// Console.Write("Hello User! How old are you?");
// string? ageAsText = Console.ReadLine();

//int ageAsInt = int.Parse(ageAsText);

//Console.WriteLine($"Your age will be in a year: {ageAsInt + 1}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 3 — Age in Five Years
//Write a program that:
//Asks the user to enter an age.

//Performs the necessary conversion.

//Calculates the age in 5 years.
//Prints a complete sentence with the result.


//Console.Write("Hello User! How old are you? ");

// string? ageAsText = Console.ReadLine();
// int ageAsInt = int.Parse(ageAsText);

//Console.WriteLine($"Your age in 5 years will be: {ageAsInt + 5}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 4 — Two Numbers
//Write a program that:
//Asks the user for a first number.

//Prompts the user for a second number.
//Converts the two values ​​to integers.
//Adds them.
//Prints the result.


// Console.Write("Hello User! write me a first number that comes to your mind: ");
// string? userFirstInput = Console.ReadLine(); 
//
// Console.Write("Great! Now write me a second number that comes to your mind: ");
// string? userSecondInput = Console.ReadLine();
//
// int firstNumber = int.Parse(userFirstInput);
// int secondNumber = int.Parse(userSecondInput);
//
// Console.WriteLine(firstNumber + secondNumber);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 5 — Simple Calculator
//Write a program that accepts two numbers from the user and displays:

//Sum
//Difference
//Product

//All values ​​coming from the user must undergo the appropriate conversion before performing the calculations.


// Console.Write("Hello User! write the first number that comes in your mind: ");
// string? userInput = Console.ReadLine();
//
// Console.Write("Great ! Now write a second number that comes in your mind: ");
// string? secondUserInput = Console.ReadLine();
//
// int firstNumber = int.Parse(userInput);
// int secondNumber = int.Parse(secondUserInput);
//
// Console.WriteLine(firstNumber + secondNumber);
// Console.WriteLine(firstNumber - secondNumber);
// Console.WriteLine(firstNumber * secondNumber);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 2 — Parse
//Exercise 6 — Birth Year Calculation
//Write a program that:
//Asks the user to enter an age.

//Converts the input to an integer.

//Stores the current year in a variable.

//Calculates an estimated year of birth.
//Prints the result.

//For the purpose of this exercise, use the year:
// 2026


// Console.Write("Hello User! How old are you? ");
// string? ageAsText = Console.ReadLine();
// int ageAsInt = int.Parse(ageAsText);
//
// int currentYear = 2026;
//
// Console.WriteLine(currentYear - ageAsInt);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 7 — Product Quantity
//A store asks the user to enter how many products they want to buy.
//The price of each product is:
//12

//Write a program that:
//Receives the quantity.
//Converts it to an integer.
//Calculates the total price.
//Prints the total price.


// Console.Write("Hey girl! So how many products do we have here? ");
// string? userInput = Console.ReadLine();
// int productCount = int.Parse(userInput);
//
// decimal price = 12;
//
// Console.WriteLine(price * productCount);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 8 — Minutes
//Write a program that asks the user to enter a number of hours.

//The program should convert the input to an integer.
//and calculate how many minutes are in the number of hours entered.


// Console.Write("Hello User! Enter a number of hours: ");
// string? userInput = Console.ReadLine();
// int hours = int.Parse(userInput);
//
// int minutes = 60;
//
// Console.WriteLine(minutes * hours);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 3 — TryParse
//This topic appears in your file as part of the way to check whether the text entered can actually be converted to an int.
//Exercise 9 — Is It an Integer?
//Write a program that:
//Asks the user to enter a value.

//Attempts to convert it to an Integer.

//Stores the result of the conversion attempt in a Boolean.

//Prints:
//Was the conversion successful?
//What is the resulting numeric value?


// Console.Write("Hello User! Please enter a value: ");
// string userValueInput = Console.ReadLine();
// int userValueInt = int.Parse(userValueInput);
//
// bool wasConversionSuccessful = true;
//
// Console.WriteLine(userValueInt);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Exercise 10 — Number Validation
//
// Write a program that asks the user to enter a number.
//
// At the end of the program, the following will be printed:
//
// The original value the user entered.
//
// Is it a valid Integer?
// The value of the numeric variable after the conversion attempt.
// Exercise 11 — Age Validation
//
// Write a program that prompts the user for an age.
//
// The program should:
//
// Attempt to convert the input to an Integer.
//
// Store the success or failure of the conversion.
//
// Display the test result.
//
// Display the resulting numeric value.
//
// Test the program yourself with several different types of input.
//
// 🔵 Part 4 — out
//
// The file shows two ways to work with the variable that receives the result of TryParse: declaring it inside the function and declaring it in advance.
//
// Exercise 12 — Inline Declaration
//
// Write a program that:
//
// Accepts a number from the user.
// Attempts to convert to an Integer.
// Declare the variable that receives the number as part of the conversion operation.
// Prints the result of the conversion and the number.
// Exercise 13 — Separate Declaration
//
// Rewrite Exercise 12.
//
// This time:
//
// The numeric variable must be declared on a separate line.
//
// Only then should the conversion attempt be performed.
//
// Finally, the conversion result and the number should be printed.
//
// Exercise 14 — Compare the Two Forms
//
// Create two separate examples in the same file:
//
// Example A
//
// Declaring the numeric variable while attempting the conversion.
//
// Example B
//
// Declaring the numeric variable before attempting the conversion.
//
// Each example should receive its own input and display its own results.
//
// 🟣 Part 5 — Numeric Type Conversions
// Exercise 15 — Integer to Double
//
// Create an Integer variable with a numeric value of your choice.
//
// Then:
//
// Create a Double variable.
//
// Pass the value of the Integer to it.
//
// Print both variables.
// Exercise 16 — Age as Double
//
// Write a program that:
//
// Gets an age from the user.
//
// Converts it to an Integer.
//
// Passes the value to a Double variable.
//
// Prints both values.
// 🔴 Part 6 — Casting
//
// The file also explains conversion from double to decimal using an explicit cast.
//
// Exercise 17 — Double to Decimal
//
// Create a double variable with the value:
//
// 42.75
//
// Then:
//
// Create a decimal variable.
//
// Pass the value from the double to it using the required conversion.
//
// Print both values.
// Exercise 18 — Price Conversion
//
// Create a double variable that represents a price.
//
// The value will be:
//
// 199.99
//
// Convert it to a decimal value and then print both variables.
//
// Exercise 19 — Conversion Chain
//
// Write a program that starts with an Integer.
//
// Then:
//
// Casts it to a Double.
// Converts the Double value to a Decimal.
// Prints the three variables.
// 🧠 Part 7 — Mixed Practice
//
// This is where the real coding muscle begins. There are no instructions that break down every little operation for you.
//
// Exercise 20 — Future Age Validator
//
// Write a program that asks the user for their age.
//
// The program should:
//
// Check if the input can be converted to an Integer.
//
// Save the test result.
//
// Display the received age.
//
// Calculate and display the age in 15 years.
// Exercise 21 — Shopping Cart
//
// The price of one product is:
//
// 25
//
// The user enters the number of products they want to buy.
//
// Write a program that will handle the input conversion and display:
//
// Whether the input can be converted to an integer.
//
// The quantity received.
//
// The total price.
// Exercise 22 — Three Inputs
//
// Ask the user to enter three different numbers.
//
// For each number:
//
// Capture it from the Console.
// Do a conversion attempt.
// Save the result of the conversion attempt.
//
// At the end, print out for each of the three values:
//
// Whether it is correct.
// What is the numerical value obtained.
// 🏆 Final Challenge — Type Conversion Center
//
// Write a program called:
//
// Type Conversion Center
//
// The program should ask the user:
//
// Age
//
// Number of years of experience
//
// Number of projects completed
//
// All data comes from the Console.
//
// The program should perform the appropriate conversions and checks and finally display:
//
// Whether each of the three values ​​could be converted to Integer.
// The numerical value obtained for each.
// Age in 10 years.
// Number of years of experience in 5 years.
// Number of projects after adding