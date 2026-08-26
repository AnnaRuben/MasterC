bool isValidAge;

do
{
    Console.Write("How old are you? ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out int age);
    
    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");
    }
} while (isValidAge);



// do
// {
//     
// } while (true);
//
// while (true)
// {

// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



//do loop and while loop are practically the same .
//but there is an important difference .
//do and while loops will run continually until this becomes false : while (true);


//~~~~~~~~~~~~~~
// do
// {
//     
// } while (true);
//~~~~~~~~~~~~~~


//right now both of them set to true because that is the placeholder value that puts in there when we created the snippet:


//~~~~~~~~~~~~~~
// do
// {
//     
// } while (true);

// while (true)
// {

// }
//~~~~~~~~~~~~~~


//so this is kinda like an if statement, where everything inside the parentheses () has to evaluate to true or false, a bool. 
//but what is going to happen is with both of these that we are going to run code inside the curly braces {} until while (true); becomes false .


//~~~~~~~~~~~~~~
// do
// {
//     
// } while (true);
//~~~~~~~~~~~~~~


//in the past we asked the user for their age:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Console.Write("How old are you? ");
// string ageText = Console.ReadLine();
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and from there we would do :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//bool isValidAge = int.TryParse(ageText, out int age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and we would say ok, is it a valid age and if not we would say :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// if (isValidAge == false)
// {
//     Console.WriteLine("That was an invalid age.");
//     return;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//but maybe we want to give it another shut because you know .... things happens ... you start typing something out and maybe your finger accidentally bumps the wrong key and you hit enter before you realized that you had like a K' at the end of your age and that was an accident, it happens ,you don't want always just say ok, you are done, come back later.            
//so instead maybe you want to say hey, wasn't a valid age, can you try again and give them a shut to do it again.       
//but how would you do that with what we have learned so far ? 
//well .... we wouldn't know how to. 
//so instead we use a do loop .
//we will wrap all this code inside of a do loop :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Console.Write("How old are you? ");
// string ageText = Console.ReadLine();
//
// bool isValidAge = int.TryParse(ageText, out int age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     bool isValidAge = int.TryParse(ageText, out int age);
// } while (true);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//so we have now got our code inside of a do loop ,and we are asking how old are you ,and we are going to find out if it's valid.   
//now our code looks like this :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     bool isValidAge = int.TryParse(ageText, out int age);
// } while (true);
//
// if (isValidAge == false)
// {
//     Console.WriteLine("That was an invalid age.");
//     return;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and we can cut out this if statement : 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// if (isValidAge == false)
// {
//     Console.WriteLine("That was an invalid age.");
//     return;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and put it also inside the do loop :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     bool isValidAge = int.TryParse(ageText, out int age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//         return;
//     }
// } while (true);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//either way it works ,inside the do loop and if it will stay outside of the do loop .
//if isValidAge is false then say that was an invalid age but instead of returning, just get reed of the return :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     bool isValidAge = int.TryParse(ageText, out int age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (true);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and we can check isValidAge, and notice that the compiler says that we can't do that because of the fact that we declared isValidAge inside the do loop.    
//so now we have to define bool isValidAge above the do loop, and inside the do loop we have to just assign a value to it:    


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// bool isValidAge;
//
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     isValidAge = int.TryParse(ageText, out int age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (isValidAge);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//now we can check it 





//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~





// while (true)
// {

// }