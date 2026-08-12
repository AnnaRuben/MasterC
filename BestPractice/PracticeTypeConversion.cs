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
// string? userValueInput = Console.ReadLine();
//
// bool isConversionSuccessful = int.TryParse(userValueInput, out int value);
//
// Console.WriteLine($"Was the conversion successful? {isConversionSuccessful}");
// Console.WriteLine($"The resulting numeric value was: {value}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 10 — Number Validation
//Write a program that asks the user to enter a number.

//At the end of the program, the following will be printed:
//The original value the user entered.
//Is it a valid Integer?
//The value of the numeric variable after the conversion attempt.


// Console.Write("Hello User! Please enter a number: ");
// string? userInput = Console.ReadLine();
//
// bool isValidInt = int.TryParse(userInput, out int number);
//
// Console.WriteLine($"The original value was: {userInput}");
// Console.WriteLine($"Is it a valid Integer? {isValidInt}");
// Console.WriteLine($"The numeric value after the conversion attempt is: {number}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 11 — Age Validation
//Write a program that prompts the user for an age.

//The program should:
//Attempt to convert the input to an Integer.
//Store the success or failure of the conversion.
//Display the test result.

//Display the resulting numeric value.

//Test the program yourself with several different types of input.


// Console.Write("Hello User! How old are you? ");
// string? ageAsText = Console.ReadLine();
//
// bool isValidAge = int.TryParse(ageAsText, out int age);
//
// Console.WriteLine($"Was the age conversion successful? {isValidAge}");
// Console.WriteLine($"The resulting numeric age is: {age}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 4 — out
//The file shows two ways to work with the variable that receives the result of TryParse:
//declaring it inside the function and declaring it in advance.
//Exercise 12 — Inline Declaration

//Write a program that:
//Accepts a number from the user.
//Attempts to convert to an Integer.
//Declare the variable that receives the number as part of the conversion operation.
//Prints the result of the conversion and the number.


// Console.Write("Hello User! Please write a number: ");
// string? userInput = Console.ReadLine();
//
// bool isConversionSuccessful = int.TryParse(userInput, out int number);
//
// Console.WriteLine($"Was the conversion successful? {isConversionSuccessful}");
// Console.WriteLine($"The number is: {number}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 13 — Separate Declaration
//Rewrite Exercise 12.
//This time:
//The numeric variable must be declared on a separate line.

//Only then should the conversion attempt be performed.

//Finally, the conversion result and the number should be printed.


// Console.Write("Hello User! Please write a number: ");
// string? userInput = Console.ReadLine();
//
// int number;
//
// bool isConversionSuccessful = int.TryParse(userInput, out number);
//
// Console.WriteLine($"Was the conversion successful? {isConversionSuccessful}");
// Console.WriteLine($"The number is: {number}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 14 — Compare the Two Forms
//Create two separate examples in the same file:
//Example A
//Declaring the numeric variable while attempting the conversion.

//Example B
//Declaring the numeric variable before attempting the conversion.

//Each example should receive its own input and display its own results.


// Console.Write("Example A - Please write a number: ");
// string? firstUserInput = Console.ReadLine();
//
// bool isFirstConversionSuccessful = int.TryParse(firstUserInput, out int firstNumber);
//
// Console.WriteLine($"Was the conversion successful? {isFirstConversionSuccessful}");
// Console.WriteLine($"The number is: {firstNumber}");

// Console.Write("Example B - Please write a number: ");
// string? secondUserInput = Console.ReadLine();
//
// int secondNumber;
//
// bool isSecondConversionSuccessful = int.TryParse(secondUserInput, out secondNumber);
//
// Console.WriteLine($"Was the conversion successful? {isSecondConversionSuccessful}");
// Console.WriteLine($"The number is: {secondNumber}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 5 — Numeric Type Conversions
//Exercise 15 — Integer to Double
//Create an Integer variable with a numeric value of your choice.

//Then:
//Create a Double variable.
//Pass the value of the Integer to it.
//Print both variables.


// int myNumber = 5;
//
// double valueOfInteger = myNumber;
//
// Console.WriteLine(myNumber);
// Console.WriteLine(valueOfInteger);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 16 — Age as Double
//Write a program that:
//Gets an age from the user.
//Converts it to an Integer.

//Passes the value to a Double variable.
//Prints both values.


// Console.Write("Hello User! How old are you? ");
// string? userAgeInText = Console.ReadLine();
//
// int userAge = int.Parse(userAgeInText);
//
// double userAgeInDouble = userAge;
//
// Console.WriteLine(userAge);
// Console.WriteLine(userAgeInDouble);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 6 — Casting
//The file also explains conversion from double to decimal using an explicit cast.
//Exercise 17 — Double to Decimal
//Create a double variable with the value:
//42.75

//Then:

//Create a decimal variable.

//Pass the value from the double to it using the required conversion.

//Print both values.


// double value = 42.75;
// Console.WriteLine(value);
//
// decimal convertDouble = (decimal)value;
// Console.WriteLine(convertDouble);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 18 — Price Conversion
//Create a double variable that represents a price.

//The value will be:
//199.99

//Convert it to a decimal value and then print both variables.


// double price = 199.99;
// Console.WriteLine(price);
//
// decimal fromDouble = (decimal)price;
// Console.WriteLine(fromDouble);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 19 — Conversion Chain
//Write a program that starts with an Integer.

//Then:
//Casts it to a Double.
//Converts the Double value to a Decimal.
//Prints the three variables.


// Console.WriteLine("Welcome  to my Integer App!");
//
// Console.Write("Hello User! Please write a number: ");
// string? numberAsAText = Console.ReadLine();
// int number = int.Parse(numberAsAText);
// Console.WriteLine(number);
//
// double numberToDouble = number;
// Console.WriteLine(numberToDouble);
//
// decimal numberToDecimal = (decimal)numberToDouble;
// Console.WriteLine(numberToDecimal);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 7 — Mixed Practice
//Exercise 20 — Future Age Validator
//Write a program that asks the user for their age.

//The program should:
//Check if the input can be converted to an Integer.
//Save the test result.
//Display the received age.
//Calculate and display the age in 15 years.


// Console.WriteLine("Welcome to my User Age App");
//
// Console.Write("Hello User! How old are you? ");
// string? userAgeAsText = Console.ReadLine();
//
// bool isValidAge = int.TryParse(userAgeAsText, out int age);
//
// Console.WriteLine($"Was the conversion successful? {isValidAge}");
//
// if (isValidAge)
// {
//     Console.WriteLine($"Your age is: {age}");
//     Console.WriteLine($"Your age in 15 years will be: {age + 15}");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 21 — Shopping Cart
//The price of one product is:
//25

//The user enters the number of products they want to buy.

//Write a program that will handle the input conversion and display:
//Whether the input can be converted to an integer.
//The quantity received.
//The total price.


// Console.WriteLine("Welcome to my Shopping Cart App!");
//
// double price = 25;
//
// Console.Write("How many products would you like to buy? ");
// string? piecesAsText = Console.ReadLine();
//
// bool isValidQuantity = int.TryParse(piecesAsText, out int productsCount);
//
// Console.WriteLine($"Was the quantity conversion successful? {isValidQuantity}");
//
// if (isValidQuantity)
// {
//     Console.WriteLine($"Quantity: {productsCount}");
//     Console.WriteLine($"Total price: {productsCount * price}");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 22 — Three Inputs
//Ask the user to enter three different numbers.

//For each number:
//Capture it from the Console.
//Do a conversion attempt.
//Save the result of the conversion attempt.

//At the end, print out for each of the three values:
//Whether it is correct.
//What is the numerical value obtained.


// Console.Write("Hello User! Please enter the first number: ");
// string? firstNumberAsText = Console.ReadLine();
//
// bool isFirstNumberValid = int.TryParse(firstNumberAsText, out int firstNumber);
//
//
// Console.Write("Please enter the second number: ");
// string? secondNumberAsText = Console.ReadLine();
//
// bool isSecondNumberValid = int.TryParse(secondNumberAsText, out int secondNumber);
//
//
// Console.Write("Please enter the third number: ");
// string? thirdNumberAsText = Console.ReadLine();
//
// bool isThirdNumberValid = int.TryParse(thirdNumberAsText, out int thirdNumber);
//
//
// Console.WriteLine($"First value is valid: {isFirstNumberValid}. Numeric value: {firstNumber}");
// Console.WriteLine($"Second value is valid: {isSecondNumberValid}. Numeric value: {secondNumber}");
// Console.WriteLine($"Third value is valid: {isThirdNumberValid}. Numeric value: {thirdNumber}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Final Challenge — Type Conversion Center
//Write a program called:
//Type Conversion Center

//The program should ask the user:
//Age
//Number of years of experience
//Number of projects completed

//All data comes from the Console.

//The program should perform the appropriate conversions and checks and finally display:
//Could each of the three values ​​be converted to an Integer?
//The resulting numeric value for each.
//Age in 10 years.
//Number of years of experience in 5 years.
//Number of projects after adding 3 projects.
//Converting the age from Integer to Double.
//Another conversion of the Double value to Decimal.


// Console.WriteLine("Welcome to my Type Conversion Center App!");
//
// // Age
// Console.Write("Hello User! How old are you? ");
// string? ageInput = Console.ReadLine();
//
// bool isAgeValid = int.TryParse(ageInput, out int age);
//
// // Experience
// Console.Write("How many years of experience do you have? ");
// string? experienceInput = Console.ReadLine();
//
// bool isExperienceValid = int.TryParse(experienceInput, out int userExperience);
//
// // Projects
// Console.Write("Please write the number of projects completed by you: ");
// string? projectInput = Console.ReadLine();
//
// bool isProjectCountValid = int.TryParse(projectInput, out int userProjects);
//
// // Conversion results
// Console.WriteLine($"Was age converted successfully? {isAgeValid}. Numeric value: {age}");
// Console.WriteLine($"Was experience converted successfully? {isExperienceValid}. Numeric value: {userExperience}");
// Console.WriteLine($"Was project count converted successfully? {isProjectCountValid}. Numeric value: {userProjects}");
//
// // Age calculations and conversions
// if (isAgeValid)
// {
//     Console.WriteLine($"Your age in 10 years will be: {age + 10}");
//
//     double ageAsDouble = age;
//     Console.WriteLine($"Age as Double: {ageAsDouble}");
//
//     decimal ageAsDecimal = (decimal)ageAsDouble;
//     Console.WriteLine($"Age as Decimal: {ageAsDecimal}");
// }
//
// // Experience calculation
// if (isExperienceValid)
// {
//     Console.WriteLine($"Your number of years of experience in 5 years will be: {userExperience + 5}");
// }
//
// // Projects calculation
// if (isProjectCountValid)
// {
//     Console.WriteLine($"Your number of projects after adding 3 projects will be: {userProjects + 3}");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Weakness Practice — Type Conversions
//Part 1 — Conversion Validation
//Exercise 1 — Favorite Number
//Write a program that:

//1. Asks the user to enter a favorite number.

//2. Checks whether the entered value can be converted to an Integer.

//3. Saves the test result.

//4. Displays whether the conversion was successful.

//5. Displays the resulting numeric value.


//Console.WriteLine("Hello User! Please insert your favorite number: ");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


// ### Exercise 2 — Number Plus Ten
//
// Write a program that:
//
// 1. Accepts a value from the user.
//
// 2. Checks whether it can be converted to an Integer.
//
// 3. Only if the conversion is successful — adds 10 to the number.
//
// 4. Displays the result.
//
// ---
//
// ### Exercise 3 — Birth Year Validator
//
// The year is:
//
// ```csharp
// **2026**
//
// ```
//
// Write a program that:
//
// 1. Asks for age.
// 2. Checks whether the age can be converted to an integer.
// 3. Saves the test result.
// 4. Only when the input is valid, calculates an estimated year of birth.
//
// ---
//
// # 🔵 Part 2 — `out`
//
// ### Exercise 4 — Inline Number
//
// Write a program that accepts a value from the user and attempts to convert it to an Integer.
//
// The variable that receives the number must be declared **on the same line as the conversion attempt**.
//
// When finished, display:
//
// - Was the conversion successful.
//
// - The number received.
//
// ---
//
// ### Exercise 5 — Separate Number
//
// Rewrite the same program.
//
// This time the numeric variable must be declared **on a separate line before the conversion attempt**.
//
// ---
//
// ### Exercise 6 — Two Styles
//
// Write a program that asks for two different numbers.
//
// For the first number, use the first declaration form you learned.
//
// For the second number, use the second declaration form.
//
// Finally, display the results of both conversions.
//
// ---
//
// # 🟣 Part 3 — Do Not Parse Twice
//
// ### Exercise 7 — Score to Double
//
// Write a program that:
//
// 1. Gets a score from the user.
//
// 2. Converts it to an Integer.
//
// 3. Creates a Double from it.
//
// 4. Displays the Integer.
//
// 5. Displays the Double.
//
// **Do not read the input from the Console again.**
//
// ---
//
// ### Exercise 8 — Number Conversion Chain
//
// Write a program that:
//
// 1. Gets a number from the user.
//
// 2. Converts it to an Integer.
//
// 3. Casts the Integer to a Double.
//
// 4. Casts the Double to a Decimal.
//
// 5. Displays all three values.
//
// ---
//
// ### Exercise 9 — Years of Experience
//
// Write a program that:
//
// 1. Gets the number of years of experience from the user.
//
// 2. Converts it to an Integer.
//
// 3. Uses the Integer that has already been created to create a Double.
//
// 4. Displays both variables.
//
// ---
//
// # 🟠 Part 4 — Failed Conversion Must Not Continue
//
// ### Exercise 10 — Ticket Quantity
//
// The ticket price is:
//
// ```
// 40
// ```
//
// The program receives a number of tickets from the user.
//
// It should:
//
// 1. Check if the input can be converted to an Integer.
//
// 2. Display if the conversion was successful.
//
// 3. Only if successful, calculate the total price.
//
// ---
//
// ### Exercise 11 — Exam Points
//
// Write a program that asks the user to enter a number of points.
//
// If the input is valid:
//
// - Display the number.
//
// - Add 5 points to it.
// - Display the new result.
//
// If the input is invalid, the calculation is not allowed.
//
// ---
//
// ### Exercise 12 — Three Validations
//
// Ask the user to enter:
//
// - Age
//
// - Number of courses completed
//
// - Number of projects completed
//
// Each of the three data items must pass a **separate conversion test**.
//
// For each, display:
//
// - Is the input valid?
//
// - The resulting numeric value.
//
// A calculation with any value is only allowed if its conversion was successful.
//
// ---
//
// # 🏆 Weakness Final Challenge — Developer Profile Validator
//
// Write a program called:
//
// **Developer Profile Validator**
//
// The program asks the user:
//
// - Age
//
// - Number of years of experience
//
// - Number of projects
//
// - Number of courses completed
//
// For **each of the four values**:
//
// 1. Attempt conversion to Integer.
//
// 2. Save separately whether the conversion was successful.
// 3. Save the resulting numeric value.
// 4. Display the test result.
//
// Then:
//
// - If the age is correct — display the age in 5 years.
// - If the years of experience are correct — display them after adding 2.
// - If the number of projects is correct — display it after adding 4.
// - If the number of courses is correct — display it after adding 1.
// - From the Integer of the age, create a Double.
// - From that Double, create a Decimal.
//
// ## 🚫 New practice rules
//
// - Do not use `Parse` in exercises that require a validity check.
// - Do not perform a re-conversion from the string if you have already created a suitable numeric variable from it.
// - Do not perform a calculation with the result of a failed conversion attempt.
// - Do not copy the solutions I wrote above.
// - All exercises are written from scratch by hand. 💪🔥