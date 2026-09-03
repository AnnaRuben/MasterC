//Exercise — DO / WHILE LOOPS
//Exercise 1 — Number Counter
//Create a variable:
//int number = 0;

//Using `do/while`:
//Print `number`.

//Add `2` to it each time.

//Continue the loop as long as `number` is less than `10`.


// int number = 0;
//
// do
// {
//     Console.WriteLine(number);
//     number += 2;
// } while (number < 10);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — Count By Three
//Create a variable:
//int number = 0;

//Using `do/while`:
//Print the number.

//Add `3` to it each time.

//The loop should end when the number is not less than 15.


// int number = 0;
//
// do
// {
//     Console.WriteLine(number);
//     number += 3;
// } while (number < 15);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Getting input from the user
//Exercise 3 — Valid Age
//Ask the user:
//How old are you?
//The user can type something that is not a number.

//Requirements:
//Use `int.TryParse`.

//If the input is not a number, print:
//That was an invalid age.
//Ask again.
//The loop should end only when the user has entered a valid number.

//After the loop ends, print:
//Your age is X.
//Note: `age` should also be available outside the loop — just as the scope topic Tim teaches in the file.


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
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// ## Exercise 4 — Valid Number
// Ask:
// Please enter a number:
// If the user types:
// hello
// or any value other than `int`:
// Invalid number.
// Then ask again.
// When the user enters a valid number:
// Your number is X.
// ### Required:
// Use
// do
// {
// } while (...);
// # 🟡 Conditions inside the loop
// ## Exercise 5 — Age Under 18
// Ask the user for an age.
// First:
// * Make sure the input is a number using `TryParse`.
// * If it is not a number, ask again.
// After a valid number is received:
// * If the age is under 18:
// You are under 18.
// * Else:
// You are 18 or older.
// ## Exercise 6 — Number Range
// Ask:
// Enter a number between 1 and 10:
// The loop should continue as long as the number **is not in the range 1–10**.
// When a valid number is entered:
// Valid number.
// Conditions like `<`, `>`, `&&` and `||` are allowed, because Tim explicitly states that these expressions can be used inside loop conditions just like in `if`.
// # 🔵 Yes / No Loops
// Tim gives an example in the file of the idea of:
// > asking the user if they want to continue, and if they say `yes`, running again.
// ## Exercise 7 — Keep Going
// Printout:
// Hello User!
// Then ask:
// Do you want to continue?
// If the user types:
// yes
// the loop starts over.
// If they type something else — the loop ends.
// Use `ToLower()` so that:
// YES
// Yes
// yes
// will also work.
// #                Exercise 8 — Student Names
// !                     Inside `do/while` ask:
// @                    What is the student's name?
// $                    After the user types a name:
// %                     Student: Anna
// ^                      Then:
// &                      Is there another student?
// *                      If the answer is:
//   yes
//    ask for the student's name again.
// ?                       If not — exit the loop.
// !                       🟠 Party Exercise
// This is directly based on the example Tim describes at the end of the lesson: getting a guest's name, asking "Is another guest coming?", and if so returning to the beginning of the loop.
// ## Exercise 9 — Party Guests
// Write a program that asks:
// What is the guest's name?
// For example:
// Bob
// Then:
// Is another guest coming?
// If the user writes:
// yes
// Return to the question:
// What is the guest's name?
// If the user writes:
// no
// The loop ends and prints:
// Guest registration completed.
// # 🔴 Infinite Loops
// This is a very important part of the lesson. Tim demonstrates a situation where we start from 0 and add `3`:
// 0 → 3 → 6 → 9 → 12
// So if we wait for the number to be exactly `10`, it will never happen and we get **Infinite Loop**.
// ## Exercise 10 — Find The Infinite Loop
// Examine the following code:
// int number = 0;
// do
// {
// Console.WriteLine(number);
// number += 4;
// } while (number != 10);
// Without running it, answer:
// 1. Will the loop end?
// 2. What are the first five values ​​that will be printed?
// 3. Why might the condition create an Infinite Loop?
// 4. Which **type of condition** you learned in class would be safer?
// **Don't write the corrected code right now — just explain.**
// ## Exercise 11 — Wrong Direction
// Check:
// int number = 0;
// do
// {
// Console.WriteLine(number);
// number -= 2;
// } while (number < 10);
// Answer:
// 1. What happens to `number` each time it is passed?
// 2. Does it move in a direction that will make the condition `false`?
// 3. Will the loop terminate?
// 4. If not — why?
// This is exactly the principle Tim emphasizes: you need to make sure that the loop always moves in a direction that will have an **exit**.
// # 🟣 DO/WHILE vs. WHILE
// Exercise 12 — Choose The Correct Loop
// In each of the following cases, write only:
// do/while
// or:
// while
// A
// You need to ask the user what their age is at least once, and only then can you check if the input is correct.
// B
// There is an action that may not need to be performed at all, so you want to check if it is needed first.
// C
// You need to ask the user for the name of a guest at least once.
// D
// You need to check a condition before deciding whether to run the code.
// 🟤 Understand the order of operations
// Exercise 13 — What Happens First?
// We have:
// int number = 20;
// do
// {
// Console.WriteLine(number);
// } while (number < 10);
// Ask without running:
// Will 20 be printed?
// How many times will the loop body run?
// After all, 20 < 10 is false — so why does the code inside the loop even run?
// Exercise 14 — Same Code With While
// Now:
// int number = 20;
// while (number < 10)
// {
// Console.WriteLine(number);
// }
// Ask:
// Will 20 be printed?
// How many times will the loop body run?
// What is the difference compared to Exercise 13?
// This tests exactly the main difference of the lesson:
// do/while → first runs and then checks.
// while → first checks and then runs.
// ⭐ Exercise 15 — Valid Age + Range
// Write a program that asks:
// How old are you?
// The program should keep asking until the user gives an age that is:
// A valid number
// Greater than 0
// Less than 120
// If the input is invalid:
// Invalid age.
// When a valid age is received:
// Your age is X.
// Only what is listed in the lesson is allowed:
// do/while, if, bool, int, string, Console.ReadLine(), Console.Write/WriteLine(), TryParse, out, <, >, ==, &&, ||.
// 🏆 Final Challenge — Guest Registration
// Write a program to register people for a party.
//     At each round:
// What is the guest's name?
//     Then ask:
// How old is the guest?
//     If the age is not a valid number:
// Invalid age.
//     And the program should keep asking for an age until a valid number is received.
//     Then:
// Is another guest coming?
//     If the user answers yes — start registering another guest.
//     If he answers no — end the loop and print:
// Guest registration completed.