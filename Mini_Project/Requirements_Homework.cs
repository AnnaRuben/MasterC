// HOME_WORK
//
//     Plan and build a Console application that asks a user for their name 
// and 
//     their age. 
//
//     If 
//     their name is Bob 
//     or 
//     Sue, 
// address them 
//     as 
//     Professor. 
//
//     If 
// the person is under 21, 
// recommend they wait X years to start this class.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Console.Write("Hello User! What is your first name? ");
// string? firstName = Console.ReadLine();
//
// Console.Write($"Hey {firstName}, How old are you ? ");
// string? ageText = Console.ReadLine();
// int  age = int.Parse(ageText);
//
// if (firstName.ToLower() == "bob" ||
//       firstName.ToLower() == "sue")
// {
//       Console.WriteLine("Hello Professor!");
// }
// else
// {
//       Console.WriteLine("Welcome Student!");
// }
// if (age < 21)
// {
//       Console.WriteLine($"Hello {firstName}! we recommend you to wait {21 -  age}");
// }
// else
// {
//       Console.WriteLine("Hello Student!");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Console.Write("Hello User! What is your first name? ");
// string firstName = Console.ReadLine();
//
// Console.Write($"Hey {firstName}, How old are you ? ");
// string ageText = Console.ReadLine();
//
// string formattedName;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if it's false, the age isn't valid
//if it's true ,this age variable will hold our age.

//bool isValidAge = int.TryParse(ageText, out int age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we don't have to create a bool variable and then just check the bool 
//because what's happening here, remember that TryParse returns a bool .
//we can check the bool right inline .
//so if it's true, it's valid (we can use this age) run this if code, if it's false (age isn't valid) we could have an else statement and say "You didn't provide a valid age." and the program will exit. 
//so now we have nested if statement : (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
//we wouldn't want to use nested if statements because they take a lot of space 

// if (int.TryParse(ageText, out int age))
// {
//     if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
//     {
//         formattedName = $"Professor {firstName}";
//     }
//     else
//     {
//         formattedName = firstName;
//     }
//     
//     if (age < 21)
//     {
//       Console.WriteLine($"I recommend you wait {21 -  age} years, {formattedName}");
//     }
//     else
//     {
//         Console.WriteLine($"Welcome to class {formattedName}");
//     }
// }
// else
// {
//     Console.WriteLine("You didn't provide a valid age.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we wouldn't want to use nested if statements because they take a lot of space

Console.Write("Hello User! What is your first name? ");
string firstName = Console.ReadLine();

Console.Write($"Hey {firstName}, How old are you ? ");
string ageText = Console.ReadLine();

string formattedName;

//we can write it with !
//if (!int.TryParse(ageText, out int age))
    
//but i recommend write it with == false because it's easy to understand  
if (int.TryParse(ageText, out int age) == false)
{
    Console.WriteLine("You didn't provide a valid age.");
    return;
}
    //and we write a return statement 
    //the return exits out of the current method.
    //the current method is the static void main, we can't see it ,but it's there.
    //it means that what we return in the static void main method ,we end the program.
    //it means we are not going further.
    //it means that we don't need to have a nested if statements, because this return statements say end the program here ,it means we aren't coming down to:
    
    // if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
    // { 
    //     formattedName = $"Professor {firstName}";
    // }

    //the nested and the regular code will run the same, both work.
    //we can use both 
    //se return is a nice feature to know about ,to say hey i'm done early. 

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{ 
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}

if (age < 21)
{
    Console.WriteLine($"I recommend you wait {21 - age} years, {formattedName}");
}
else
{
        Console.WriteLine($"Welcome to class {formattedName}");
}


