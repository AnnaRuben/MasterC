//Practice Scenario: Player Registration System

//You are building a system to capture new player data.
//Initially, when the form is created in memory, we have no information about the player.

//Task 1: Defining Lack of Values ​​Variables
//Create the following variables.
//You must define them all to be nullable (since we haven't asked the user yet), and initialize them to null:
//1. Player's age (integer).

//int? playerAge = null;

//2. Is his birthday today (boolean).

//bool? playerHasBirthday = null;

//3. Batting average (double).

//double? battingAverage = null;    

//4. Account balance (exact financial number).

//decimal? accountBalance = null;

//5. First name (string).
//Note: Define the string in the modern, precise way we learned, which tells Visual Studio that we expect it to be null.

//string? firstName = null;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 2: Putting real values ​​against nullity
//The user (in this case, a parent registering their baby) has started filling out the form:
//1. Update the age variable to 0 (because the baby has just been born, and 0 is a valid age, as opposed to null, which is a lack of information).

//int? babyAge = 0;

//2. Update the first name to a name of your choice.

//string? babyFirstName = "Anna";

//3. Leave the other variables unchanged (they are still null).
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 3: Dealing with C#'s Nullable Reference Types warning mechanism
//Now we want to see the compiler's protection in action:
//1. Create a new variable called `lastName` of type string, but this time DO NOT mark it as Nullable (without the question mark).
//2. Try initializing it to `null`.
//3. Below this line, Write me a comment in the code:
//- Why does Visual Studio highlight this line with a warning?

//Because we gave it the value null without declaring it to be null with the question mark.

//string lastName = null;

//- What is the line in the project file (`.csproj`) that causes the system to check us and display this warning?

//<Nullable>enable</Nullable>
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~







//Exercise 2 – Employee Management System

//Background
//You're building an employee management system for a company.
//Sometimes information is not yet known, so it will be `null`.
//
//Task 1 – What values ​​are missing?
//Create the following variables.
//Note:
//If the information is not yet known – it must be `null`.

//1. Employee ID (`int`)

int? employeeId = null;

//2. Years of experience (`int`)

int? yearsOfExperience = null;

//3. Monthly bonus (`decimal`)

decimal? monthlyBonus = null;

//4. Performance score (`double`)

double? performanceScore = null;

// 5. Is manager (`bool`)

bool? isManager = null;

// 6. Phone number (`string`)

string? phoneNumber = null;

// 7. Email (`string`)

string? email = null;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 2 – Some information has arrived
//Now some information has been received.
//Update only the following variables:
//
//Employee ID → 1045

employeeId = 1045;

//Years of experience → 8

yearsOfExperience = 8;

//Email → any address

email = "shaked12072014@gmail.com";

//All other variables should remain `null`.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 3 – Check if information exists
//Write a condition (`if`) for each of the following variables:
//Example:
//If the bonus exists


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (monthlyBonus != null)
//{
//Console.WriteLine("Bonus exists.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//Now write similar conditions for:
//phoneNumber


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (phoneNumber != null)
{
    Console.WriteLine("The phone number is correct.");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//performanceScore


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (performanceScore != null)
{
    Console.WriteLine("Your performance score is amazing!");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//isManager


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (isManager != null)
{
    Console.WriteLine("You are the manager!");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 4 – Is information missing?
//Now write conditions that specifically check if the value does not exist.
//For example:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// if (phoneNumber == null)
// {
// Console.WriteLine("Phone number is missing.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//Write conditions for:
//email


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (email == null)
{
    Console.WriteLine("Your email address doesn't exist!");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//yearsOfExperience


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (yearsOfExperience == null)
{
    Console.WriteLine("You don't have any experience!");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//employeeId


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
if (employeeId == null)
{
    Console.WriteLine("You don't work here!");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 5 – Replace null with real value
//You have the following variables:
//int? vacationDays = null;
//decimal? salary = null;
//bool? passedTraining = null;

//Update them to real values ​​of your choice.

int? vacationDays = 14;

decimal? salary = 30000;

bool? isPassedTraining = true; 

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 6 – Return value to null
//Now that the employee has left the company:
//Return the following variables to `null`.
//
//phoneNumber

phoneNumber = null;

//email

email = null;

//salary

salary = null;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Task 7 – Finding the variables with missing information
//Look at the following list:
//
//int? departmentNumber = null;
//bool? hasParkingSpot = true;
//double? productivityScore = null;
//string? officeLocation = "Building A";
//decimal? yearlyBonus = null;

//Without running the program, write in the comment:
//Which variables contain `null`.

int? departmentNumber = null;
double? productivityScore = null;
decimal? yearlyBonus = null;

//Which variables already contain a real value.

bool? hasParkingSpot = true;
string? officeLocation = "Building A";

//Small challenge

//For each of the following variables, write next to it whether you think it should be Nullable or not.
//int employeeNumber - Not
//int age - Not
//bool hasDrivingLicense - Not
//decimal salary - Not
//string firstName - Not
//string country - Not

//Briefly explain why you chose this.
//Because an employeeNumber, an age, hasDrivingLicense,  salary, firstName, country, aren't Nullable.  
//meaning, they don't have the capacity to store a lack of value.   
//so we use this question mark at the end of the variables. 

//Brainstorming Challenge (no code)
//In each of the following cases, write whether you think it is better to use `null` or another value:
//Explain why in each section.
//1. A test score that has not yet been entered. - better to use `null`, because it'll in the Future.
//2. The number of children of a person for whom there is no information yet. - better to use `null`
//3. A bank account balance that is truly zero. - better to use `null`
//4. The height of a person who has not yet been measured. - better to use `null`
//5. An email address that the user has not yet entered. - better to use `null`
// ---
//
// This exercise covers new things that did not appear in your first exercise:
//
// * `== null` and `!= null` tests.
// * Updating a value from `null` to a true value.
// * Reverting a value back to `null`.
// * Identifying variables that are missing information.
// * Thinking about when it is appropriate to use `null` and when not.
// * Reinforcing the understanding that `null` is **lack of information**, and not a value like `0`, `false`, or an empty string.