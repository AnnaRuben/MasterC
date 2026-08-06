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
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 1
//Part A — Defining, Assigning and Using a Variable
//Exercise 1 — The First Variable

//Create a `string` variable called `firstName`.
// First define it using:
//string.Empty
// Then enter your name into it and print it.
//Example Result
//Anna

// string firstName = string.Empty;
// firstName = "Anna";
// Console.WriteLine(firstName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2 — Value at the time of definition
//Create a variable called `lastName`.
//Don't use two lines this time.
//Enter the last name directly at the time of variable definition.
//Print it.

// string lastName = "Rubenchik";
// Console.WriteLine(lastName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 3 — Two Variables

//Create the following variables:
//`firstName`
// `lastName`
//Insert values ​​into them and print each on a separate line.
//Sample Result
//Tim
//Corey

// string firstName = string.Empty;
// string lastName = string.Empty;

// firstName = "Tim";
// lastName = "Corey";

// Console.WriteLine($"{firstName}\n" +
//                   $"{lastName}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 4 — A number that is actually a string
//Create a `string` variable called `employeeNumber`.
//Enter into it:
//12345
// Make sure the value is in quotes.
//Print it.
//> Goal: To understand that `"12345"` is a `string`, even though it looks like a number.>

// string employeeNumber = string.Empty;
// employeeNumber = "12345";
// Console.WriteLine(employeeNumber);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 5 — Overriding a Value

//Create a variable called `favoriteFood`.
//First enter:
//Pizza
//Then, before printing, change the value to:
//Pasta
//Print the variable.

//Thinking Question
//Which value will be printed — `Pizza` or `Pasta`?
//Write the answer as a comment above `Console.WriteLine`.

// string favoriteFood = string.Empty;
// favoriteFood = "Pizza";

// //The value will be printed is `Pasta`.
// favoriteFood = "Pasta";
// Console.WriteLine(favoriteFood);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 2 — Correct Variable Names
//Exercise 6 — Correcting Names
// The following code works in terms of data types, but the variable names are unclear:
// string a = "Anna";
// string b = "Rubenchik";
// string c = "Blue";
// string d = "Pizza";
// Rewrite the code with clear variable names.
//Finally, print each variable on a separate line.
//> This exercise checks only the variable names, not the code structure.>

// string firstName = "Anna";
// string lastName = "Rubenchik";
// string favoriteColor = "Blue";
// string favoriteFood = "Pizza";
//
// Console.WriteLine($"{firstName} \n" +
//     $"{lastName} \n" +
//     $"{favoriteColor} \n" +
//     $"{favoriteFood}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 7 — Fixing `camelCase`

//Fix the variable names to follow the `camelCase` rules:
// string FirstName = "John";
// string lastname = "Smith";
// string FAVORITECOLOR = "Green";
// string Favoritefood = "Hamburger";

// string firstName = "John";
// string lastName = "Smith";
// string favoriteColor = "Green";
// string favoriteFood = "Hamburger";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 8 — Names that are too long

//Replace the long names with clear but shorter names:
//string firstNameForTheUserWhoIsUsingOurApplication = "Sarah";
//string favoriteColorForTheUserWhoIsUsingOurApplication = "Purple";
//Print a sentence that includes both values.

// string firstName = "Sarah";
// string favoriteColor = "Purple";

// Console.WriteLine($"Hey! My name is {firstName} and my favorite color is {favoriteColor}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 9 — Removing Hungarian Notation and Abbreviations

//Fix the variable names:
//string strFirstName = "Tim";
//string strLastName = "Corey";
//string fColor = "Blue";
// The new names must not include the variable type or unclear abbreviations.

// string firstName = "Tim";
// string lastName = "Corey";
// string favoriteColor = "Blue";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 3 — String Concatenation

//Exercise 10 — Concatenating with `+`
//Create:
//string firstName
//string lastName
//Print the full name by concatenating strings with `+`.
//Desired Result
//Tim Corey
//Note that you must add a space between the names using a String Literal:
//" "

// string firstName = string.Empty;
// string lastName =  string.Empty;
//
// firstName = "Tim";
// lastName = "Corey";
//
// Console.WriteLine(firstName + " " + lastName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 11 — Constructing a Statement with Chaining

//Create the variables:
//`firstName`
//`favoriteColor`
//Print using `+` only:
//Tim's favorite color is Blue.
//The values ​​`Tim` and `Blue` should come from the variables.

// string firstName = string.Empty;
// string favoriteColor = string.Empty;

// firstName = "Tim";
// favoriteColor = "Blue";

// Console.WriteLine(firstName + "'s favorite color is " + favoriteColor + ".");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 12 — String Interpolation

//Rewrite Exercise 11, but this time use String Interpolation:
//$"..."
//You must not use `+` in this exercise.

// string firstName = string.Empty; 
// string favoriteColor =  string.Empty;

// firstName = "Tim";
// favoriteColor = "Blue";

// Console.WriteLine($"{firstName}'s favorite color is {favoriteColor}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 13 — Three Variables in a Sentence

//Create the variables:
//`firstName`
//`city`
//`favoriteFood`
//Print using String Interpolation:
//Anna lives in Tel Aviv and likes Pizza.
//All variable information must come from the variables and not be written directly into the sentence.
    
// string firstName =  string.Empty;
// string city =   string.Empty;
// string favoriteFood = string.Empty;

// firstName = "Anna";
// city = "Tel Aviv";
// favoriteFood = "Pizza";

// Console.WriteLine($"{firstName} lives in {city} and likes {favoriteFood}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 14 — Storing the Sentence in a Variable
//Create:
//`firstName`
//`lastName`
//`fullName`
//The value of `fullName` should be created using String Interpolation and the first two variables.
//Then print only `fullName`.

// string firstName = string.Empty;
// string lastName = string.Empty;
// string fullName = string.Empty;

// firstName = "Anna";
// lastName = "Rubenchik";

// fullName = $"{firstName} {lastName}";

// Console.WriteLine(fullName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 4 — Newlines and Escape Characters

//Exercise 15 — Line feed with `\n`
//Create the variables:
//`firstName`
//`lastName`
//`favoriteColor`
//Use only one `Console.WriteLine` and display:
//First name: Anna
//Last name: Rubenchik
//Favorite color: Blue
//Use `\n` to feed a line.

// string firstName = string.Empty;
// string lastName =  string.Empty;
// string favoriteColor =  string.Empty;
//
// firstName = "Anna";
// lastName =  "Rubenchik";
// favoriteColor = "Blue";
//
// Console.WriteLine($"First name: {firstName} \n" +
//                   $"Last name: {lastName} \n" +
//                   $"Favorite color: {favoriteColor} \n");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 16 — Fixing a file path using `\\`
//The following code causes errors because of the `\`:
//string filePath = "C:\Users\Anna\Documents";
//Fix it using **Escape Characters Only**.
//In this exercise, `@` is not allowed.
//Print the path.
//Desired Output
//C:\Users\Anna\Documents

// string filePath = "C:\\Users\\Anna\\Documents";
// Console.WriteLine(filePath);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 17 — Fixing a Path Using `@`
//Rewrite Exercise 16, but this time use a Verbatim String:
//@"..."
//In this exercise, you must not use `\\`.

// string filePath = @"C:\Users\Anna\Documents";
// Console.WriteLine(filePath);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 18 — A path containing a variable
//Create:
//string firstName="Anna";
//Then create a variable called `message` to hold the statement:
//The file for Anna is at C:\Users\Anna\Documents
//Use a combination of:
//$@"..."
//The name `Anna` must come from the variable in both places in the statement.

// string firstName="Anna";
// string message = $@"The file for {firstName} is at C:\Users\{firstName}\Documents";
// Console.WriteLine(message);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 5 — Finding and Fixing Errors
//Exercise 19 — Fix the Code
//The following code has some style and path errors:
//string strName = "";
//string FColor = "";
//string p = "";
//strName = "John";
//FColor = "Blue";
//p = "C:\Temp\John";
//Console.WriteLine("Hello " + strName);
//Console.WriteLine("Your favorite color is " + FColor);
//Console.WriteLine(p);
//Fix the code according to the rules you learned:
//Clear variable names.
//`camelCase`.
//No Hungarian Notation.
//No single letter names.
//Initialization using `string.Empty`.
//Valid path.
//Use String Interpolation in printing.
//Do not change the content of the output.

// string name = string.Empty;
// string favoriteColor = string.Empty;
// string filePath = string.Empty;

// name = "John";
// favoriteColor = "Blue";
// filePath = @"C:\Temp\John";
// Console.WriteLine($"Hello {name}");
// Console.WriteLine($"Your favorite color is {favoriteColor}");
// Console.WriteLine(filePath);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 20 — What will be printed?

//Without running it first, write as a comment what you think will be printed:
// string firstName = string.Empty;
// firstName = "Tim";
// firstName = "John";
// firstName = "Sarah";
// Console.WriteLine(firstName);
//Then run it and check the answer.

//What will be printed is the name Sarah.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 21 — Find the Problem

//The following code does not display the value of the variable:
//string firstName = "Tim";
//Console.WriteLine("Hello {firstName}");
//Fix it using String Interpolation.

// string firstName = "Tim";
// Console.WriteLine($"Hello {firstName}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 22 — Valid, but Poor Code
// The following code compiles:
//string a = "Anna";
// string b = "Blue";
// string c = "Pizza";
// Console.WriteLine($"{a} likes {b} and {c}");
// Rewrite it so that another developer can immediately understand what each variable represents.
//> There is no need to change the statement or add functionality.
//Just improve the variable names.>

// string firstName = "Anna";
//  string favoriteColor = "Blue";
//  string favoriteFood = "Pizza";
//  Console.WriteLine($"{firstName} likes {favoriteColor} and {favoriteFood}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 6 — Final Challenge 🏆
//Exercise 23 — User Card
//Create the following variables:
//firstName
//lastName
//favoriteColor
//favoriteFood
//city
//filePath
//Requirements:
// - All variables will be of type `string`.
// - All will be initialized first with `string.Empty`.
// - Then values ​​will be applied to them.
// - `filePath` will contain a valid Windows path.
// - Use String Interpolation.
// - Use `\n` to print everything in one `Console.WriteLine`.
// - Do not use `+`.
// - Variable names will be in `camelCase`.
// - The path must appear as is, with a single `\` in the output.
//Sample Output
//User: Anna Rubenchik
//Favorite color: Blue
//Favorite food: Pizza
//City: Tel Aviv
//File location: C:\Users\Anna\Documents

// string firstName = string.Empty;
// string lastName = string.Empty;
// string favoriteColor = string.Empty;
// string favoriteFood = string.Empty;
// string city = string.Empty;
// string filePath = string.Empty;

// firstName = "Anna";
// lastName = "Rubenchik";
// favoriteColor = "Blue";
// favoriteFood = "Pizza";
// city = "Tel Aviv";
// filePath = @"C:\Users\Anna\Documents";

// Console.WriteLine($"User: {firstName} {lastName}\nFavorite color: {favoriteColor}\nFavorite food: {favoriteFood}\nCity: {city}\nFile location: {filePath}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Bonus Exercise — Building a Complex Sentence
// Create the variables:
//studentName
//courseName
//lessonName
//projectPath
//Display:
//Anna is studying C# Master Course.
//The current lesson is Common Variables: string.
//The project is stored at C:\CSharpMasterCourse\VariablesPractice.
//You must use:
// - String Interpolation.
// - Verbatim string.
// - Clear variables.
// - `camelCase`.
// - Only one `Console.WriteLine`.

// string studentName = string.Empty;
// string courseName = string.Empty;
// string lessonName = string.Empty;
// string projectPath = string.Empty;

// studentName = "Anna";
// courseName = "C# Master Course";
// lessonName = "Common Variables: string";
// projectPath = @"C:\CSharpMasterCourse\VariablesPractice";

// Console.WriteLine($@"{studentName} is studying {courseName}. 
// The current lesson is {lessonName}. 
// The project is stored at {projectPath}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
