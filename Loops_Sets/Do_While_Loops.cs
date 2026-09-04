//purple:                                         ask the user for age + check if it's valid + print age:
// bool isValidAge;
// int age;
//
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     isValidAge = int.TryParse(ageText, out age);
//
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (isValidAge);
//
// Console.WriteLine($"Your age is {age}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// bool isValidAge;
// int age;

// int testNumber = 0;
//
// do
// {
//     Console.Write(testNumber);
//     testNumber += 3;
// } while (testNumber < 10);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     isValidAge = int.TryParse(ageText, out age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (isValidAge ==  false);
//
// Console.WriteLine($"Your age is {age}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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


//now we can check it .
//this loop will come up to do, it's going to run all the cod inside the curly braces ,and then it's going to check to see if it's should continue back to the top.
//and it says while (isValidAge ==  false); 
//so if we gave an invalid age in the ageText so it couldn't parse it , then what's going to happen is it's going to say ok, that's  not a valid age, therefor go back to the top and ask for the age, get that text, try and parse it, if it is valid we will skip this :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//because it is valid ,and  we also exit out of our do loop and keep running code.
//and it will keep running over and over and over again until this is false :


//~~~~~~~~~~~~~~~~~~~~~~
//while (isValidAge == false);
//~~~~~~~~~~~~~~~~~~~~~~


//it's a little bit confusing ,because isValidAge == false that's going to return true if it's false , that's confusing.
//so what this is going to do is say continue at the top if the isValidAge statement evaluates to true .
//so isValidAge evaluates to true if isValidAge is false, go back to the top until isValidAge goes true , which true doesn't equals false, therefor it's false , therefor it stops this do/while loop .     


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
// } while (isValidAge ==  false);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//there is one bug in this code:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine($"Your age is {age}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//the compiler says no, you can't do that ,and it says "The name 'age'  does not exist in the current context".
//that's a key massage there.
//we can argue ,yes it does !
//don't argue with tools, they are usually smarter than we are.
//so in this case we declare age inside the do loop scope ,therefor age is only going to live inside this scope:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//therefor we need int age up here:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// bool isValidAge;
// int age;
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
// } while (isValidAge ==  false);
//
// Console.WriteLine($"Your age is {age}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and erase the int from :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//isValidAge = int.TryParse(ageText, out int age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//like that :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//isValidAge = int.TryParse(ageText, out age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//it's going to put a value in to age.
//now we can identify outside of the do loop :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// bool isValidAge;
// int age;
//
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     isValidAge = int.TryParse(ageText, out age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (isValidAge ==  false);
//
// Console.WriteLine($"Your age is {age}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//now lets run this code :
//How old are you? Eighteen
//compiler: "That was an invalid age."
//How old are you? Tim
//compiler: "That was an invalid age."
//How old are you? Bob
//compiler: "That was an invalid age."
//How old are you? Sue
//compiler: "That was an invalid age."
//How old are you? 18
//compiler: "Your age is 18"
//so that is how the do loop works.
//it will evaluate this while loop :


//~~~~~~~~~~~~~~~~~~~~~~
//while (isValidAge ==  false);
//~~~~~~~~~~~~~~~~~~~~~~


//and continue back to the top until this expression is false:


//~~~~~~~~~~~~~~~~~~~~~~
//while (isValidAge ==  false);
//~~~~~~~~~~~~~~~~~~~~~~


//there is a bit of a danger here :


//~~~~~~~~~~~~~~~~~~~~~~~~
// int testNumber = 0;
//
// do
// {
//     Console.Write(testNumber);
//     testNumber += 3;
// } while (testNumber != 10);
//~~~~~~~~~~~~~~~~~~~~~~~~


//that is going to add 3 to the value of testNumber.
//so remember that += is the equivalent of saying :


//~~~~~~~~~~~~~~~~~~~~~~
//testNumber = testNumber +3;
//~~~~~~~~~~~~~~~~~~~~~~


//we shortening it down because it's kinda redundant.  

//so do we see the problem here ?


//~~~~~~~~~~~~~~~~~~~~~~~~
// int testNumber = 0;
//
// do
// {
//     Console.Write(testNumber);
//     testNumber += 3;
// } while (testNumber != 10);
//~~~~~~~~~~~~~~~~~~~~~~~~


//we have here an endless loop that will run forever !
//but why ?
//we were supposed to stop at 10 !
//well ... yeah ... except of the fact that we saied  != to 10.
//well ... is it ever going to be equals to 10 ?
//no!
//because of the fact that we started with 0 ,and we add 3 each time so 3/6/9/12 ,we never saied 10.
//this is called an infinite loop, this is a bad thing !
//because an infinite loop means that our app will never stop running ,and it will get to a point that it will run out of memory and will stack and a lot of more bad things wil happen to our app.
//so we need to make sure that our loops are rock solid when it comes to our evaluations.
//so if we want to say stop at 10, we need to say that our testNumber is < 10:


//~~~~~~~~~~~~~~~~~~~~~~~
// int testNumber = 0;
//
// do
// {
//     Console.Write(testNumber);
//     testNumber += 3;
// } while (testNumber < 10);
//~~~~~~~~~~~~~~~~~~~~~~~


//because then this will continue at 3 , and say 3 is < 10 is true, go back to the top,  6 is < 10 is true, go back to the top, 9 is < 10 true, go back to the top, 12 is not < 10 false, go down to the next line and our loop has been stopped .
//we can also forget about negative numbers.
//for example we use the wrong sign ,we use - instead of += ,we will get that infinite loop again, because of the fact that we never make sure that we are going to the right direction with our number.
//so it is important with loops to make sure that our loop will always have an exit   


//~~~~~~~~~~~~~~~~~~~~~~~
// int testNumber = 0;
//
// do
// {
//     Console.Write(testNumber);
//     testNumber -= 3;
// } while (testNumber < 10);
//~~~~~~~~~~~~~~~~~~~~~~~


//another example for an infinite loop, we saied while (isValidAge); : 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     isValidAge = int.TryParse(ageText, out age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (isValidAge);
//
// Console.WriteLine($"Your age is {age}.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//now lets run this code :
//How old are you? 18
//How old are you? 25
//How old are you? 36
//How old are you? 543
//How old are you? 4
//How old are you? 5

//it's not letting us get out of it!
//but when we will write "Test"
//compiler: "That was an invalid age."
//Your age is 0
//and it exits out !
//that is totally wrong !

//so we need to be care full of our loop.
//but loops are very powerful for things like this ,where you can keep going back to the user and say no! i need a valid age from you ! 
//and maybe we want to say let me get out of it another way like give me a valid age or type exit to end the program because maybe they don't have a valid age ,and so we have to get out some way.      
//so we don't want to force the user to give us a fake age, so we need to be care full from that as well.
//we can use loops for things like we can capture instead of ageText maybe we can capture "do you want to keep going? " and if the user say yes, and should i keep going == yes or To.Lower() == yes then do it again.
//we can capture a number of people that way, if we ask for people attend to a party ,the user will type a name ,and we will ask is there another guest is coming ? the user say yes and it loops back up and it trys again, ok what is the guest name? ,and we say Bob, ok is another guest is coming ? yes, then go back to the top, what is their name ? Sue, is another guest coming ? No, and then it goes on and does the rest of the stuff.     
//so this do loop can be really powerful.
//remember, there is 2 kinds of loops, do loop that is the do\while loop , and while loop .
//the while loop is practically the same as the do loop.
//the difference is :


//~~~~~~~~~~~~
// do
// {
//     
// } while (true);
//
// while (true)
// {

// }
//~~~~~~~~~~~~


//we have done this ,do and it runs this code :


//~~~~~~~~~~~~
// do
// {
//     
// } while (true);
//~~~~~~~~~~~~


//and then evaluates if this is true or false :


//~~~~~~~~~~~
//while (true);
//~~~~~~~~~~~


//and while it is true ,go back to the top .

//while loop :


//~~~~~~~~~~~
// while (true)
// {

// }
//~~~~~~~~~~~


//has the evaluation at the top, and then curly braces.


//~~~~~~~~~~~~~~~~~~~~~
// do
// {
//Run the code at least once .   
// } while (true);
//~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~
// while (true)
// {
//Runs the code 0 or more times.
// }
//~~~~~~~~~~~~~~~~~~~~~~~~


//do loop, we always going to run the code once ,and then we will check to see if we should continue and do it again.    
//while loop, we are going to check first if we should run the code ,and then we are going to run the code how many times we need to, so we might not ever run the code in the case of a while loop.       

//when would we use do/while or while loops ?
//in our case ,we are asking the persons age and then going back to the top if it is invalid.
//well that means we should ask for the age at least once because we have to ask them what the age first, we should evaluate if their age is valid before we know what the age is.
//therefor we run this code once :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// do
// {
//     Console.Write("How old are you? ");
//     string ageText = Console.ReadLine();
//
//     isValidAge = int.TryParse(ageText, out age);
//     
//     if (isValidAge == false)
//     {
//         Console.WriteLine("That was an invalid age.");
//     }
// } while (isValidAge ==  false);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//therefor we need a do loop.

//there are other cases, maybe we have something to clean up or potentially we need to clean up some code ,and we will do a check to say hey, do we neen a cleanup ? 
//if yes, do the cleanup in here:


//~~~~~~~~~~~~~~~~~~~~~~~~
// while (true)
// {

// }
//~~~~~~~~~~~~~~~~~~~~~~~~


//otherwise just keep going !
//and if we do need to do a cleanup, we do the cleanup and say ,are we done the cleanup ? 
//no, do it again ! and again ! until we are done the cleanup ,and we go, ok now we done, and exit out.   
//so it depends on our scenario, if we use do/while or while loops.
//but the do/while and the while loops are basically the same except for how many times they will run at least.
//the while loop will run at least 0 times, it might not run at all. 
//the do loop will run at least 1 time. 

//remember ,in the do loop ,this is evaluation just like an if statements :


//~~~~~~~~~~~~~~~~~~~~~
//while (isValidAge ==  false);
//~~~~~~~~~~~~~~~~~~~~~


//we can have the same things like :
//and, or, &&, ||, To.Lower(), <, >, age range. 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~