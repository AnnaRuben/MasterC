//#Exercise — `Do_While_Loops`
//#Write a Console program that does the following:
//~1. Ask the user to enter **their age**.
//~2. If the user entered something that is not a valid number, display:
//~`Invalid age`
//~3. In that case, ask them to enter an age again.

//#4. When the user enters a valid age:
//~If the age is less than 18, display:
//~`You are a minor`
//* If the age is 18 or older, display:
//~`You are an adult`

//#5. Then ask:
//~`Do you want to check another age?`
//~6. If the user writes `yes` — the process starts over.
//~7. If the user writes `no` — the program ends.


// string userChoice;
//
// do
// {
//     bool isAgeValid;
//     int age;
//
//     do
//     {
//         Console.Write("Hello User! Please enter your age: ");
//         string userAgeText = Console.ReadLine();
//
//         isAgeValid = int.TryParse(userAgeText, out age);
//
//         if (isAgeValid == false)
//         {
//             Console.WriteLine("Invalid age");
//         }
//
//     } while (isAgeValid == false);
//
//     if (age < 18)
//     {
//         Console.WriteLine("You are a minor");
//     }
//     else if (age >= 18)
//     {
//         Console.WriteLine("You are an adult");
//     }
//
//     Console.Write("Do you want to check another age? Please choose yes or no: ");
//     userChoice = Console.ReadLine();
//
// } while (userChoice.ToLower() == "yes");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//# Additional Practice — Do_While_Loops 
//#Write a Console program to register guests for a party.

//#Requirements:
//~ 1. Ask the user to enter the guest's name.
//~ 2.Ask the user to enter the guest's age.
//3. If the age entered is not a valid number:
//a. Show:
//Invalid age
//b. Ask the user to enter the age again.
//4. When a valid age is entered:
//a. If the age is less than 18, show:
//Minor guest
//b. If the age is 18 or older, show:
//Adult guest
//5. After you are done with that guest, ask:
//Is there another guest coming?

//6. If the user writes yes — start the guest registration process again.
//7. If the user writes no — end the program.
//8. The program should also accept YES, Yes, NO, No, and so on.


bool isValidAge;

do
{
    Console.Write("Enter the guest's name: ");
    string guestName = Console.ReadLine();

    Console.Write("Enter the guest's age: ");
    string guestAgeText = Console.ReadLine();

    int age = 0;

    isValidAge =  int.TryParse(guestAgeText, out age);
    
        if (isValidAge == false)
        {
            Console.WriteLine("Invalid age");
        }
    
} while (isValidAge ==  false);