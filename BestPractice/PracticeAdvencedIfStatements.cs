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


// bool hasAccess = false;
//
// if (hasAccess)
// {
//     Console.WriteLine("Access granted");
// }
// else
// {
//     Console.WriteLine("Access denied");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 5 — Exact Age
//Create:
//int age

//If the age is exactly `25`:
//Perfect age

//Otherwise:
//Different age


// int age = 25;
//
// if (age == 25)
// {
//     Console.WriteLine("Perfect age");
// }
// else
// {
//     Console.WriteLine("Different age");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 6 — Not This Age
//Create:
//int age

//If the age is anything except `30`:
//Age is not 30

//If the age is `30`:
//Age is 30


// int age = 30;
//
// if (age != 30)
// {
//     Console.WriteLine("YAge is not 30");
// }
// else
// {
//     Console.WriteLine("Age is 30");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 7 — Minimum Age
//Create:
//int age
//Rules:
//Age `18` or higher:
//Allowed

//Anything below `18`:
//Not allowed


// int age = 18;
//
// if (age >= 18)
// {
//     Console.WriteLine("Allowed");
// }
// else
// {
//     Console.WriteLine("Not allowed");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 8 — Maximum Age
//Create:
//int age
//Rules:
//Age `65` or lower:
//Standard group

//Anything above `65`:
//Senior group


// int age = 65;
//
// if (age <= 65)
// {
//     Console.WriteLine("Standard group");
// }
// else
// {
//     Console.WriteLine("Senior group");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 9 — Number Range
//Create:
//int number

//Print:
//Inside range

//only when the number is between `20` and `29`, inclusive `20` but not including `30`.
//For every other value:
//Outside range


// int number = 30;
//
// if (number >= 20 && number < 30)
// {
//     Console.WriteLine("Inside range");
// }
// else
// {
//     Console.WriteLine("Outside range");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 10 — Age Groups
//Create:
//int age

//Rules:
//From `10` up to but not including `20`:
//Teen range

//From `20` up to but not including `30`:
//Twenties

//From `30` up to but not including `40`:
//Thirties

//Anything else:
//Another age


// int age = 30;
//
// if (age >= 10 && age < 20)
// {
//     Console.WriteLine("Teen range");
// }
// else if (age >= 20 && age < 30)
// {
//     Console.WriteLine("Twenties");
// }
// else if (age >= 30 && age < 40)
// {
//     Console.WriteLine("Thirties");
// }
// else
// {
//     Console.WriteLine("Another age");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 11 — Special Name
//Ask for:
//First name
//Last name

//Print:
//Special user
//when at least one of these is true:
//First name is `anna`
//Last name is ``stone''

//Otherwise:
//Regular user

//Uppercase and lowercase letters should not matter.


// Console.Write("What is your First name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your Last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "anna" || lastName.ToLower() == "stone")
// {
//     Console.WriteLine("Special user");
// }
// else
// {
//     Console.WriteLine("Regular user");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 12 — Exact Person
//Ask for:
//First name
//Last name
//Only the exact combination:
//michael
//Jones
//should print:
//Exact person found

//Any other combination should print:
//Different person

//Uppercase and lowercase letters should not matter.


// Console.Write("What is your First name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your Last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "michael" &&
//     lastName.ToLower() == "jones")
// {
//     Console.WriteLine("Exact person found");
// }
// else
// {
//     Console.WriteLine("Different person");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 13 — Login Classification
//Ask for:
//First name
//Last name

//Rules:
//`alex` + `king`
//Full match

//Only `alex`
//First name match

//Only `king`
//Last name match

//Neither:
//No match

//Uppercase and lowercase letters should not matter.


// Console.Write("What is your First name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your Last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "alex" && lastName.ToLower() == "king")
// {
//     Console.WriteLine("Full match");
// }
// else if (firstName.ToLower() == "alex")
// {
//     Console.WriteLine("First name match");
// }
// else if (lastName.ToLower() == "king")
// {
//     Console.WriteLine("Last name match");
// }
// else
// {
//     Console.WriteLine("No match");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 14 — Two Valid Age Ranges
//Create:
//int age

//The valid age groups are:
//`20` through `29`
//`60` through `69`

//If the age belongs to either group:
//Accepted age group

//Otherwise:
//Age group not accepted

//Pay attention to the exact beginning and end of each range.


// int age = 50;
//
// if ((age >= 20 && age < 30) ||
//     (age >= 60 && age < 70))
// {
//     Console.WriteLine("Accepted age group");
// }
// else
// {
//     Console.WriteLine("Age group not accepted");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 15 — Three Valid Age Ranges
//Create:
//int age

//The following age ranges are accepted:
//`10` through `19`
//`30` through `39`
//`70` through `79`

//If the age belongs to one of them:
//Special age range

//Otherwise:
//Regular age range


int age = 10;

if ((age >= 10 && age < 20) ||
    (age >= 30 && age < 40) ||
    (age >= 70 && age < 80))
{
    Console.WriteLine("Special age range");
}
else
{
    Console.WriteLine("Regular age range");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 16 — Boundary Test
//Create:
//int score

//Rules:
//`score` from `50` through `59`:
//Level A

//`score` from `60` through `69`:
//Level B

//`score` from `70` through `79`:
//Level C

//Anything else:
//No level

//Test your program yourself with values ​​that are exactly on the boundaries.


// int score = 71;
//
// if (score >= 50 && score < 60)
// {
//     Console.WriteLine("Level A");
// }
// else if (score >= 60 && score < 70)
// {
//     Console.WriteLine("Level B");
// }
// else if (score >= 70 && score < 80)
// {
//     Console.WriteLine("Level C");
// }
// else
// {
//     Console.WriteLine("No level");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 17 — Name And Age
//Ask for:
//First name
//Last name

//Also create:
//int age

//Rules:
//If:
//First name is Tom
// Last name is white
//Age is between 20 and 29
//printing:
//Complete match

//If the name matches but the age does not:
//Name matched

//Otherwise:
//No complete match

//Uppercase and lowercase letters in the names should not matter.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "tim" &&
//     lastName.ToLower() == "white")
// {
//     Console.WriteLine("Complete match");
// }
// else
// {
//     Console.WriteLine("Name matched");
// }
//
// int age = 25;
//
// if (age >= 20 && age < 29)
// {
//     Console.WriteLine("Complete match");
// }
// else
// {
//     Console.WriteLine("No complete match");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 18 — Multiple Independent Results
//Ask for:
//First name
//Last name

//Also create:
//int age

//The following checks must work independently:
//If the first name is mark:
//Special first name

//If the last name is black:
//Special last name

//If the age is between 40 and 49:
//Special age

//It must be possible for all three messages to appear during one execution.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "mark")
// {
//     Console.WriteLine("Special first name");
// }
//
// if (lastName.ToLower() == "black")
// {
//     Console.WriteLine("Special last name");
// }
//
// int age = 35;
//
// if (age >= 40 && age < 50)
// {
//     Console.WriteLine("Special age");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 19 — Customer Classification
//Ask for:
//First name
//Last name

//Create:
//int age

//Rules:
//First name Emma, ​​last name Wood, and age between 30 and 39
//VIP customer

//First name Emma or last name Wood
//Known customer

//Age between 60 and 69
//Senior customer

//Everything else
//Standard customer

//Uppercase and lowercase letters in names should not matter.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "emma" && lastName.ToLower() == "wood")
// {
//     Console.WriteLine("VIP customer");
// }
// else if (firstName.ToLower() == "emma" || lastName.ToLower() == "wood")
// {
//     Console.WriteLine("Known customer");
// }
// else
// {
//     Console.WriteLine("Standard customer");
// }
//
// int age = 40;
//
// if (age >= 30 && age < 39)
// {
//     Console.WriteLine("VIP customer");
// }
// else
// {
//     Console.WriteLine("Senior customer");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 20 — Complex Range Check
//Create:
//int age

//A person is accepted if their age belongs to either:
//40–49
//or:
//70–79
//Print:
//Accepted

//Otherwise:
//Rejected

//Your program must correctly handle at least these values ​​when you test it:
//39
//40
//49
//50
//69
//70
//79
//80


// int age = 50;
//
// if (age >= 40 && age < 49 ||  age >= 70 && age < 79)
// {
//     Console.WriteLine("Accepted");
// }
// else
// {
//     Console.WriteLine("Rejected");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Final Challenge — Advanced User Classification
//Ask the user for:
//First name
//Last name
//Create:
//int age
//Your program must classify the user according to these rules:
//Exact special person
//First name:
//Tim
//Last name:
//Corey
//Age belongs to either:
//40–49
//or:
//70–79
//Print:
//Special professor
//Name matches, but the complete special-person rule above does not
//Print:
//Special name
//Only part of the name matches
//If either the first name is Tim or the last name is Corey:
//Partial name match
//No name match, but age belongs to one of the two special age ranges
//Print:
//Special age
//Nothing matches
//Regular user
//Uppercase and lowercase letters in the names should not matter.


// Console.Write("What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write("What is your last name? ");
// string? lastName = Console.ReadLine();
//
// if (firstName.ToLower() == "tim" && lastName.ToLower() == "corey")
// {
//     Console.WriteLine("Special name");
// }
// else if (firstName.ToLower() == "tim" || lastName.ToLower() == "corey")
// {
//     Console.WriteLine("Partial name match");
// }
// else
// {
//     Console.WriteLine("Regular user");
// }
//
// int age = 43;
//
// if (age >= 40 &&  age < 49 || age >= 70 && age < 79)
// {
//     Console.WriteLine("Special professor");
// }
// else
// {
//     Console.WriteLine("Special age");
// }
