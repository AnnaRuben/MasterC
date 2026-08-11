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
// int userNumber = int.Parse(userInput);

// bool isValidInt = int.TryParse(userInput, out int number);
// Console.WriteLine($"Is it a valid Integer? {isValidInt}. The original value the user entered: {number}.");
// Console.Write(userNumber);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 11 — Age Validation
//Write a program that prompts the user for an age.

//The program should:
//Attempt to convert the input to an Integer.
//Store the success or failure of the conversion.
//Display the test result.

//Display the resulting numeric value.

//Test the program yourself with several different types of input.


// Console.Write("Hello User! How old are you?");
// string? ageAsText = Console.ReadLine();
// int userAge = int.Parse(ageAsText);

// bool isValidAge = int.TryParse(ageAsText, out int age);
// Console.WriteLine($"Is valid age: {isValidAge}. The user's age is {age}");
// Console.WriteLine(userAge);
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
// int number = int.Parse(userInput);
// Console.WriteLine(number);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 13 — Separate Declaration
//Rewrite Exercise 12.
//This time:
//The numeric variable must be declared on a separate line.

//Only then should the conversion attempt be performed.

//Finally, the conversion result and the number should be printed.


// Console.Write("Hello User! Please write a number: ");
// string? userInput = Console.ReadLine();
// int number = int.Parse(userInput);
// Console.WriteLine(number);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 14 — Compare the Two Forms
//Create two separate examples in the same file:
//Example A
//Declaring the numeric variable while attempting the conversion.

//Example B
//Declaring the numeric variable before attempting the conversion.

//Each example should receive its own input and display its own results.


// Console.Write("Hello User! Please write a number");
// string? userInput = Console.ReadLine();
// int number = int.Parse(userInput);
// Console.WriteLine(number);
//
// Console.Write("Hello User! Please write a number");
// string? secondUserInput = Console.ReadLine();
// int secondNumber = int.Parse(secondUserInput);
// Console.WriteLine(secondNumber);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 5 — Numeric Type Conversions
//Exercise 15 — Integer to Double
//Create an Integer variable with a numeric value of your choice.

//Then:
//Create a Double variable.
//Pass the value of the Integer to it.
//Print both variables.


// Console.Write("My Integer variable with a numeric value of my choice is: ");
// string myInput = Console.ReadLine();
// int myNumber = int.Parse(myInput);
// Console.WriteLine(myNumber);
//
// double valueOfInteger = 5;
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
// int userAge = int.Parse(userAgeInText);
// Console.WriteLine(userAge);
//
// double userAgeInDouble = double.Parse(userAgeInText);
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
// string? userAgeAsAText = Console.ReadLine();
// int age = int.Parse(userAgeAsAText);
// Console.WriteLine($"Your age in 15 years will be: {age + 15}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 21 — Shopping Cart
//The price of one product is:
//25

//The user enters the number of products they want to buy.

//Write a program that will handle the input conversion and display:
//Whether the input can be converted to an integer.
//The quantity received.
//The total price.


// Console.WriteLine("Welcome to my Input Conversion App!");
//
// double price = 25;
//
// Console.Write("Hey girl :) ! How many products do you have there? ..... ");
// string peacesAsText = Console.ReadLine();
// int productsCount = int.Parse(peacesAsText);
// Console.WriteLine(productsCount * price);
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


// Console.Write("Hello User! Please enter a number: ");
// string firstNumberAsText = Console.ReadLine();
// int firstNumber = int.Parse(firstNumberAsText);
// Console.WriteLine(firstNumber);
//
// Console.Write("Give me a second number: ");
// string secondNumberAsText = Console.ReadLine();
// int secondNumber = int.Parse(secondNumberAsText);
// Console.WriteLine(secondNumber);
//
// Console.Write("And now the last but not least ;).... give me a third number: ");
// string thirdNumberAsText = Console.ReadLine();
// int thirdNumber = int.Parse(thirdNumberAsText);
// Console.WriteLine(thirdNumber);
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
// Console.Write("Hello User! How old are you? ");
// string? userInput = Console.ReadLine();
// int age = int.Parse(userInput);
// Console.WriteLine($"Your age in 10 years will be: {age + 10}");
//
// Console.Write("How many years of experience do you have? ");
// string? experienceInput = Console.ReadLine();
// int userExperience = int.Parse(experienceInput);
// Console.WriteLine($"Your number of years of experience in 5 years will be: {userExperience + 5}");
//
// Console.Write("Please write the number of projects completed by you: ");
// string? projectInput = Console.ReadLine();
// int userProject = int.Parse(projectInput);
// Console.WriteLine($"Your number of projects after adding 3 projects will be: {userProject + 3}");
//
// double ageFromIntToDouble = age;
// Console.WriteLine(ageFromIntToDouble);
//
// decimal ageFromIntToDecimal = (decimal)ageFromIntToDouble;
// Console.WriteLine(ageFromIntToDecimal);