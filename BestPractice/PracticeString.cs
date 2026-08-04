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

//string firstName = string.Empty;
//string lastName = string.Empty;
// string favoriteColor  = string.Empty;
// string city = string.Empty;
// string country  = string.Empty;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2 - Assign Values

//After you have created the variables, give each one a value.
//For example:
//firstName = "Tim";

//firstName = "Tim";
//lastName = "Corey";
//favoriteColor = "Blue";
//city = "Boise";
//country  = "USA";

//When finished, print each variable on a separate line.

//Console.WriteLine($"{firstName} \n{lastName} \n{favoriteColor} \n{city} \n{country}");

//Sample output:
//Tim
//Corey
//Blue
//Boise
//USA
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 3 - Overwriting Variables
//Create a variable:
//string favoriteFood = string.Empty;

//Give it three different values ​​one after the other.
//For example:
//favoriteFood = "Pizza"; 
//favoriteFood = "Burger";
//favoriteFood = "Pasta";

//Print it.
//Console.WriteLine(favoriteFood);
//Question
//What value will be printed?
//the value will be Pasta. 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 4 - Numbers Inside Strings
//Create variables:
//string age = string.Empty;
//string zipCode = string.Empty;

//Put them in:
//25
//90210
//age = "25";
//zipCode = "90210";

//Print them.

// string age = string.Empty;
// string zipCode = string.Empty;
//
// age = "25";
// zipCode = "90210";
//
// Console.WriteLine($"{age} {zipCode}");

//Question:
//Are these numbers or Strings?
//Why?
//The variables have been defined as string.
//The values ​​are in quotes: "25" and "90210".
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 5 - Concatenation
//Create:
//string firstName
//string lastName

// string firstName = string.Empty;
// string lastName =  string.Empty;
// firstName = "John";
// lastName = "Smith";

//Print:
//John Smith
//using:
//+
//only.

//Hint:
//" "
//is a String.
//Console.WriteLine(firstName + " " + lastName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 6 - Greeting
//Using Concatenation only, print:
//Hello John Smith
// string firstName = string.Empty;
// string lastName = string.Empty; 

// firstName = "John";
// lastName = "Smith";
// Console.WriteLine("Hello " + firstName + " " + lastName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 7 - String Interpolation
//Print the exact same sentence:
//Hello John Smith
//But this time using:
//$""
//instead of `+`.
// string firstName = string.Empty;
// string lastName = string.Empty; 

// firstName = "John";
// lastName = "Smith";
// Console.WriteLine($"Hello {firstName} {lastName}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 8 - More Interpolation
//Create:
//firstName
//lastName
//city

// string firstName = string.Empty;
// string lastName = string.Empty;
// string city = string.Empty;
//
// firstName = "John";
// lastName = "Smith";
// city = "New York";

//Print:
//John Smith lives in New York.
//Using String Interpolation.
//Console.WriteLine($"{firstName} {lastName} lives in {city}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 9 - Empty String
//Create two variables:
//string firstName = string.Empty;
//string lastName = "";

// string firstName = string.Empty;
// string lastName = "";

//Print both.

// Console.WriteLine(firstName);
// Console.WriteLine(lastName);

//Questions
//Is there a difference in the output?
//No, both are empty.

// Which style does Tim Corey prefer to use?
//string firstName = string.Empty;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 10 - Escape Characters
//Print:
//Hello
//World
//Using only one String.

//Hint:
//\n
//Console.WriteLine("Hello \nWorld");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 11 - Quotes
//Print:
//My name is "Tim".
//Using only one String.
//Hint:
//There is an Escape Character for quotes as well.
//Console.WriteLine("My name is \"Tim\".");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 12 - File Path
//Save in variable:
//C:\Temp\Demo
//Without using `@`.

// string saveToFilePath = string.Empty;

// saveToFilePath = "C:\\Temp\\Demo";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 13 - Verbatim String
//Now do exactly the same thing,
//but this time use:
//@

// string saveToFilePath = string.Empty;

// saveToFilePath = @"C:\Temp\Demo";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 14 - Mixed Verbatim + Interpolation
//Create:
//string firstName = "John";

// string firstName = string.Empty;
// firstName = "John";

//Print:
//The file for John is at C:\SampleFile
//Using:
//$@
//Console.WriteLine($@"The file for {firstName} is at C:\SampleFile");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 15 - Variable Names
//Mark which variable names are correct and which are not.
// string firstName
// string FirstName
// string myFirstName
// string first_name
// string strFirstName
// string fName
// string a
// string employeeFirstName
// string employeeLastName

//And next to each one write:
//Good
//or
//Bad
//And explain why.

//string firstName - Good - This is the correct way to define a variable according to the rules of Casing in C# language, Camel Case.

//string FirstName - Bad - This is against the rules of Casing, C# language, Camel Case. 

//string myFirstName - Good - This is the correct way to define a variable according to the rules of Casing in C# language, Camel Case.

//string first_name - Bad - This is against the rules of Casing, C# language, Camel Case. 

//string strFirstName - Bad - This is Hungarian notation ,and we don't use it anymore in C# language. 

//string fName - Bad - We won't write it like this because we need anyone who reads our code after us to immediately understand what it is about ,and we need to find each piece of code easily if we need to change something in it.
//And if we write it like this, we might not understand ourselves what we meant here and change something incorrectly and create a bug.

//string a - Bad - We won't write it like this because we need anyone who reads our code after us to immediately understand what it is about ,and we need to find each piece of code easily if we need to change something in it.
//And if we write it like this, we might not understand ourselves what we meant here and change something incorrectly and create a bug.

//string employeeFirstName- Good - This is the correct way to define a variable according to the rules of Casing in C# language, Camel Case.

//string employeeLastName- Good - This is the correct way to define a variable according to the rules of Casing in C# language, Camel Case.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 16 - Fix the Code
//Fix the following code according to Tim Corey's rules:
//string a = "";
//string b = "";
//string c = "";

//a = "John";
//b = "Smith";
//c = "Blue";

//Console.WriteLine(a + " " + b + " likes " + c);

// string firstName = string.Empty;
// string lastName = string.Empty; 
// string myFavoriteColor = string.Empty;
//
// firstName = "John";
// lastName = "Smith";
// myFavoriteColor = "Blue";
//
// Console.WriteLine(firstName + " " + lastName + " likes " + myFavoriteColor);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 17 - Find the Mistakes
//Find at least **8 mistakes** in the code.
//string StrFirstName = "";
//string lastname = "";
//string fName = "";
//StrFirstName = "Tim";
//lastname = "Corey";

// Console.WriteLine(StrFirstName+lastname);
// Console.WriteLine($"Hello"+StrFirstName);
//
// string file = "C:\Temp\Test";
// Console.WriteLine(file);

//Don't correct.
//Just write down all the mistakes.

// string StrFirstName = "";
// string lastname = "";
// string fName = "";
// StrFirstName = "Tim";
// lastname = "Corey";
//
// Console.WriteLine(StrFirstName+lastname);
// Console.WriteLine($"Hello"+StrFirstName);
//
// string file = "C:\Temp\Test";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 18 - Final Challenge
//Write a program that creates the variables:
//* firstName
//* lastName
//* favoriteColor
//* favoriteFood
//* city

//and prints exactly the following output:
//Hello John Smith!
//Your favorite color is Blue.
//Your favorite food is Pizza.
//You live in New York.
//Your file is stored at:
//C:\Users\John\Documents

//Requirements:
//* Use `string.Empty`
//* Assign to each variable
//* Use String Interpolation
//* Use `\n`
//* Use `$@`
//* Use Camel Case variable names
//* Do not use single letter variables (`a`, `b`, `c`)
//* Do not use Hungarian Notation
//* Use `Console.WriteLine`

// string firstName = string.Empty;
// string lastName = string.Empty;
// string favoriteColor = string.Empty;
// string favoriteFood = string.Empty;
// string city = string.Empty;
// string filePath = string.Empty;

// firstName = "John";
// lastName = "Smith";
// favoriteColor = "Blue";
// favoriteFood = "Pizza";
// city = "New York";
// filePath = $@"C:\Users\{firstName}\Documents";
//
// Console.WriteLine(
//     $"Hello {firstName} {lastName}!\n" +
//     $"Your favorite color is {favoriteColor}.\n" +
//     $"Your favorite food is {favoriteFood}.\n" +
//     $"You live in {city}.\n" +
//     $"Your file is stored at:\n" +
//     $"{filePath}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Bonus Challenge (Tim Corey style)
//Write a program that displays a business card:
//--------------------------------
//Name: John Smith
//City: New York
//Favorite Color: Blue
//Favorite Food: Pizza
//Email: john.smith@gmail.com
//--------------------------------
//Use:
//*`string.Empty`
//*String Interpolation
//*`\n`
//*At least once In `$@`
//If you solve all these exercises without the help of a solution, you will have an excellent understanding of the whole string topic at the level that Tim Corey teaches at the beginning of his C# course.

// string name = string.Empty;
// string favoriteColor =  string.Empty;
// string favoriteFood =   string.Empty;
// string city =  string.Empty;
// string email = string.Empty;

// name = "John Smith"; 
// favoriteFood = "Blue";
// favoriteColor = "Pizza";
// city = "New York";
// email = @"john.smith@gmail.com";

// Console.WriteLine($"Name: {name} \nCity: {city} \nFavorite Color: {favoriteColor} \nFavorite Food: {favoriteFood} \nEmail: {email}");

