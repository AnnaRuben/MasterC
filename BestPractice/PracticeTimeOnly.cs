//`TimeOnly` Exercise
//Part 1 — Creating Hours
//Exercise 1 — Opening Time
//Create a `TimeOnly` variable named:
//storeOpenAt
// Input the time `9:00 AM` into it using `TimeOnly.Parse`, and then print it.
//The result should represent:
//9:00 AM

// TimeOnly storeOpenAt = TimeOnly.Parse("9:00 AM");
// string timeTypeMorning = storeOpenAt.ToString("h:mm tt");
// Console.WriteLine(timeTypeMorning);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2 — Closing Time
//Create a variable named:
//storeCloseAt
// that will hold the time `8:00 PM`.
// Print to the screen:
// The store closes at: [time]
// Use string interpolation.

// TimeOnly storeCloseAt = TimeOnly.Parse("20:00");
// string timeTypeEvening = storeCloseAt.ToString("h:mm tt");
// Console.WriteLine($"The store closes at:  {timeTypeEvening}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 3 — Two Hours
//Create two variables:
//TimeOnly schoolStartsAt
//TimeOnly schoolEndsAt
//Their values ​​will be:
//8:15 AM
// 1:30 PM
//Print two lines:
//School starts at: ...
//School ends at: ...

// TimeOnly schoolStartsAt = TimeOnly.Parse("8:15");
// string timeTypeMorning = schoolStartsAt.ToString("h:mm tt");
// Console.WriteLine($"School starts at: {timeTypeMorning}");
//
// TimeOnly schoolEndsAt = TimeOnly.Parse("13:30");
// string timeTypeEvening = schoolEndsAt.ToString("h:mm tt");
// Console.WriteLine($"School ends at: {timeTypeEvening}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 2 — The Current Time
//Exercise 4 — What time is it now?
//Create a variable named:
//currentTime
//Use:
//TimeOnly.FromDateTime(DateTime.Now)
//And print:
//The current time is: ...

// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// Console.WriteLine($"The current time is: {currentTime}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 5 — Differentiating `DateTime` from `TimeOnly`
//Create a `DateTime` variable named:
//currentDateAndTime
//and enter into it:
//DateTime.Now
//Then create a `TimeOnly` variable named:
//currentTime
//and extract only the time from `currentDateAndTime`.
//Print the two variables and check the difference:
//Full date and time: ...
//Time only: ...

// DateTime currentDateAndTime = DateTime.Now;

// TimeOnly currentTime = TimeOnly.FromDateTime(currentDateAndTime);

// Console.WriteLine($"Full date and time: {currentDateAndTime}");
// Console.WriteLine($"Time only: {currentTime}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 3 — Formatting the Time
//Exercise 6 — Displaying in 24-Hour Format
//Create a time:
//TimeOnly movieStartsAt = TimeOnly.Parse("7:45 PM");
//Print it in the format:
//19:45
//Hint:
//.ToString("HH:mm")

// TimeOnly movieStartsAt = TimeOnly.Parse("7:45 PM");
// string movieTime = movieStartsAt.ToString("HH:mm");    
// Console.WriteLine(movieTime);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 7 — 12-hour format
//Create a time that represents `6:30` in the evening and print it like this:
//06:30 PM
//Hint:
//.ToString("hh:mm tt")
//Note:
//`HH` — 24-hour format.
//`hh` — 12-hour format.
//`mm` — minutes.
//`tt` — displays `AM` or `PM`.

// TimeOnly eveningTime = TimeOnly.Parse("6:30 PM");
// string sixThirtyPm = eveningTime.ToString("hh:mm tt");
// Console.WriteLine(sixThirtyPm);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 4 — Comparing Times
//Exercise 8 — Before or After?
//Create:
//TimeOnly appointmentTime = TimeOnly.Parse("3:30 PM");
//TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//Check:
//If the current time is less than the appointment time, print:
//The appointment has not started yet.
//Otherwise, print:
//The appointment time has arrived or passed.
//Initial structure:
//if (currentTime < appointmentTime)
//{
//}
//else
//{
//}

// TimeOnly appointmentTime = TimeOnly.Parse("3:30 PM");
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//
// if (currentTime < appointmentTime)
// {
//     Console.WriteLine("The appointment has not started yet");
// }
// else
// {
//     Console.WriteLine("The appointment time has arrived or passed");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 9 — Is the business open?
//Define:
//TimeOnly openAt = TimeOnly.Parse("8:00 AM");
//TimeOnly closeAt = TimeOnly.Parse("7:00 PM");
//TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//Check if the current time is within the operating hours.
//When the business is open:
//The business is open.
//When the business is closed:
//The business is closed.
//The condition should be checked:
//currentTime >= openAt && currentTime < closeAt

// TimeOnly openAt = TimeOnly.Parse("8:00 AM");
// TimeOnly closeAt = TimeOnly.Parse("7:00 PM");
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//
// if (currentTime >= openAt && currentTime < closeAt)
// {
//     Console.WriteLine("The business is open");
// }
// else
// {
//     Console.WriteLine("The business is closed");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 10 — Gym Hours
//The gym:
//Opens at `6:00 AM`.
//Closes at `10:00 PM`.
//Write a program that displays:
//The gym is currently open.
//or:
//The gym is currently closed.
//depending on the current time.

// TimeOnly opensAt = TimeOnly.Parse("6:00 AM");
// TimeOnly closesAt = TimeOnly.Parse("10:00 PM");
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//
// if (currentTime >= opensAt && currentTime < closesAt)
// {
//     Console.WriteLine("The gym is currently open.");
// }
// else
// {
//     Console.WriteLine("The gym is currently closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 11 — School Leaving Time
//The school leaving time is:
//7:30 AM
//Check the current time:
//Before 7:30:
//It is not time to leave yet.
//Exactly at or after 7:30:
//It is time to leave.

// TimeOnly schoolLeaving = TimeOnly.Parse("7:30 AM");
// string sevenThirtyAm = schoolLeaving.ToString("h:mm tt");
// Console.WriteLine(sevenThirtyAm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//
// if (currentTime < schoolLeaving)
// {
//     Console.WriteLine("It is not time to leave yet");
// }
// else
// {
//     Console.WriteLine("It is time to leave");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 12 — Greeting by Time
//Use the current time and print:
//Before `12:00 PM`:
//Good morning!
//From `12:00 PM` to before `6:00 PM`:
//Good afternoon!
//From `6:00 PM` onwards:
//Good evening!

// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
//
// TimeOnly noon = TimeOnly.Parse("12:00 PM");
// TimeOnly evening = TimeOnly.Parse("6:00 PM");
//
// if (currentTime < noon)
// {
//     Console.WriteLine("Good morning!");
// }
// else if (currentTime < evening)
// {
//     Console.WriteLine("Good afternoon!");
// }
// else
// {
//     Console.WriteLine("Good evening!");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Final Challenge 🏆
//Opening hours system for a coffee shop
// Write a program for a coffee shop:
//Opening time: 7:00 AM
//Closing time: 8:30 PM

//The program should:
// 1. Store the opening time in a `TimeOnly` variable.
// 2. Store the closing time in a `TimeOnly` variable.
// 3. Get the current time.
// 4. Display all hours in `HH:mm` format.
// 5. Check if the coffee shop is open.
// 6. Display an appropriate message.
//Possible output example:
//Current time: 14:25
//Opening time: 07:00
//Closing time: 20:30
//The coffee shop is open.

// TimeOnly openingTime = TimeOnly.Parse("7:00 AM");
// string sevenAm = openingTime.ToString("HH:mm");
// Console.WriteLine($"Opening time: {sevenAm}");
//
// TimeOnly closingTime = TimeOnly.Parse("8:30 PM");
// string eightAndAHalf = closingTime.ToString("HH:mm");
// Console.WriteLine($"Closing time: {eightAndAHalf}");
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine($"Current time: {timeNow}");
//
// if (currentTime >= openingTime && currentTime < closingTime)
// {
//     Console.WriteLine("The coffee shop is open.");
// }
// else
// {
//     Console.WriteLine("The coffee shop is closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 1 — Creating and Printing (The Basics)
//Exercise 1 — Creating an Opening Time
//1. Create a variable:
//TimeOnly openAt;
//2. Give it a value of `8:00 AM` using `TimeOnly.Parse`.
// 3. Print it.

// TimeOnly openAt = TimeOnly.Parse("8:00 AM");
// string eightAm = openAt.ToString("h:mm tt");
// Console.WriteLine(eightAm);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2 — Creating a closing time
//1. Create a variable `closeAt` with the time `7:00 PM`.
//2. Print:
//Closing time: ...

// TimeOnly closeAt = TimeOnly.Parse("7:00 PM");
// string sevenPm = closeAt.ToString("h:mm tt");
// Console.WriteLine($"Closing time: {sevenPm}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 2 — “Just the Time” from `DateTime`
//Exercise 3 — The Current Time
//1. Create a variable named `rightNow` of type `TimeOnly` using `TimeOnly.FromDateTime(DateTime.Now)`.
//2. Print:
//`DateTime.Now`
//`rightNow`
//Goal: To see that `DateTime` contains both a date and a time, and `TimeOnly` contains only a time.

// TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
// DateTime dateAndTime = DateTime.Now;
//
// Console.WriteLine(rightNow);
// Console.WriteLine(dateAndTime);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 3 — Formatting
//Exercise 5 — 24-hour format
//1. Create a time named `meetingAt` using `TimeOnly.Parse` (choose your own time, e.g. PM ​​with minutes).
//2. Print it in 24-hour format (HH:mm).

// TimeOnly meetingAt = TimeOnly.Parse("12:00");
// string withMinutes = meetingAt.ToString("HH:mm");
// Console.WriteLine(withMinutes);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 6 — 12-hour format
//Print the same time in the format:
//06:05 PM

// TimeOnly meetingAt = TimeOnly.Parse("06:05 PM");
// string withMinutes = meetingAt.ToString("hh:mm tt");
// Console.WriteLine(withMinutes);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 4 — Time Comparisons
//Exercise 7 — Are We Open Yet?
//Conditionals Using `openAt` and `rightNow`:

//If `rightNow` Before `openAt` → `We are not open yet.`
//Else → `We are open or already past opening time.`

// TimeOnly openAt = TimeOnly.Parse("8:00 AM");
//
// TimeOnly rightNow = TimeOnly.Parse(DateTime.Now.ToString("HH:mm"));
//
// if (rightNow < openAt)
// {
//     Console.WriteLine("We are not open yet.");
// }
// else
// {
//     Console.WriteLine("We are open or already past opening time.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 8 — Is the business open (hour range)
//Define opening and closing hours (openAt/closeAt) and get the current time (rightNow).
//Check if `rightNow` is within the range of operating hours, and print:
//`The business is open.`
//`The business is closed.

// TimeOnly openAt = TimeOnly.Parse("08:00");
// string eightAm = openAt.ToString("HH:mm");
// Console.WriteLine(eightAm);
//
// TimeOnly closeAt = TimeOnly.Parse("23:00");
// string twentyThreePm = closeAt.ToString("HH:mm");
// Console.WriteLine(twentyThreePm);
//
// TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = rightNow.ToString("HH:mm");
// Console.WriteLine(timeNow);
//
// if (rightNow >= openAt && rightNow < closeAt)
// {
//     Console.WriteLine("The business is open.");
// }
// else
// {
//     Console.WriteLine("The business is closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 5 — “Local Business” Practice + Exceptions
//Exercise 9 — Exception: Early Close
//Script:
//Normally: Open 8:00, Close 19:00
//Today there is an exception: Early Close at 16:00
//Write code that defines:
//`regularCloseAt` (19:00)
//`earlyCloseAt` (16:00)
//`rightNow`
//Then select “Actual Close”:
//If today is an exception → use `earlyCloseAt`
//Otherwise → use `regularCloseAt`

// TimeOnly regularCloseAt = TimeOnly.Parse("19:00");
// TimeOnly earlyCloseAt = TimeOnly.Parse("16:00");
//
// TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
//
// bool isExceptionToday = true;
//
// TimeOnly actualCloseAt;
//
// if (isExceptionToday)
// {
//     actualCloseAt = earlyCloseAt;
// }
// else
// {
//     actualCloseAt = regularCloseAt;
// }
//
// Console.WriteLine($"Right now: {rightNow.ToString("HH:mm")}");
// Console.WriteLine($"Actual closing time: {actualCloseAt.ToString("HH:mm")}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//You are building a small program that simulates a business's opening hours system.
//It has three times that are important to you:
//Current time
//Business opening time
//Business closing time
//Then the program needs to figure out what the business's status is based on the current time.


//1. Right now: HH:mm
//The program needs to display the current time.
//For example only:
//Right now: 14:25
//HH:mm means the time should be displayed in 24-hour format.

//2. Open at: HH:mm
//You need to decide on the business's opening time and save it.
//For example, if the business opens in the morning, the program will display the opening time in the requested format:
//Open at: ...

// 3. Close at: HH:mm
//The same goes for the closing time.
//The program needs to know when the business closed and display:
//Close at: ...

//4.Business status: OPEN or CLOSED
//Now comes the part where the program needs to make a decision.
//It needs to look at:
//The time now
//Opening time
//Closing time
//And decide:
//OPEN
//or:
//CLOSED
//That is, the question you need to answer in the program is:
//Should the business be open at the current time?
//5. If the business is closed — explain why
//This is the part that makes the challenge a "smart system."

//It is not enough to write:
//CLOSED
//If the business is closed, the program also needs to understand why it is closed.

//There are only two possible reasons in the exercise:
//The business has not yet opened
//That is, the current time is too early.

// Then it should appear:
//Before opening
//The business has already closed
//That is, the operating hours have already ended.
//Then it should appear:
//After closing
//So there are actually three possible situations
//From a conceptual point of view only:
//Situation A: Still too early → The business is closed because it has not yet opened.
//Situation B: We are within operating hours → The business is open.
//Situation C: It's too late → The business is closed because it has already closed.

// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine($"Right now: {timeNow}");
//
// TimeOnly openingTime = TimeOnly.Parse("06:00");
// string six = openingTime.ToString("HH:mm");
// Console.WriteLine($"Open at: {six}");
//
// TimeOnly closingTime = TimeOnly.Parse("23:00");
// string twentyThree = closingTime.ToString("HH:mm");
// Console.WriteLine($"Close at: {twentyThree}");
//
// if (currentTime < openingTime)
// {
//     Console.WriteLine("CLOSED");
//     Console.WriteLine("Before opening");
// }
// else if (currentTime < closingTime)
// {
//     Console.WriteLine("OPEN");
// }
// else
// {
//     Console.WriteLine("CLOSED");
//     Console.WriteLine("After closing");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~






//TimeOnly — Weak Points Practice
//HH vs. hh and tt Correct formatting
//<, >, <=, >= Hour boundaries
//&& vs ||

//Conflicting/redundant conditions Building a simple and correct condition
//Part 1 — Time Formatting
//Exercise 1 — 24-Hour Format

//Create a TimeOnly variable named:
//departureTime
//And put into it:
//8:45 PM

//Print it exactly like this:
// 20:45

// TimeOnly departureTime = TimeOnly.Parse("08:45 PM");
// string twentyFortyFive = departureTime.ToString("HH:mm");
// Console.WriteLine(twentyFortyFive);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2 — 12-Hour Format

//Create a variable named:
//meetingTime

//Save it:
//6:05 PM

//Print it:
//06:05 PM

// TimeOnly meetingTime = TimeOnly.Parse("6:05 PM");
// string sixOoFive = meetingTime.ToString("hh:mm tt");
// Console.WriteLine(sixOoFive);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 3 — Two Different Formats

//Create only one TimeOnly named:
//movieTime

//With the value:
//9:30 PM

//From the same variable Print two lines:
// 24-hour format: 21:30
// 12-hour format: 09:30 PM

//TimeOnly movieTime = TimeOnly.Parse("9:30 PM");

//string twentyFourHourFormat = movieTime.ToString("HH:mm");
//string twelveHourFormat = movieTime.ToString("hh:mm tt");

//Console.WriteLine($"24-hour format: {twentyFourHourFormat}");
//Console.WriteLine($"12-hour format: {twelveHourFormat}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 2 — Simple Comparisons
//Exercise 4 — Before the Appointment

//Create:
//TimeOnly appointmentTime
//TimeOnly currentTime

//Appointment time:
//4:00 PM

//currentTime should contain the current time using the method you learned in class.

// If the current time is before the appointment time:
//The appointment is later.

//Otherwise:
//The appointment time has arrived or passed.

// TimeOnly appointmentTime = TimeOnly.Parse("4:00 PM");
// string forPm = appointmentTime.ToString("h:mm tt");
// Console.WriteLine(forPm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine(timeNow);
//
// if (currentTime < appointmentTime)
// {
//     Console.WriteLine("The appointment is later.");
// }
// else
// {
//     Console.WriteLine("The appointment time has arrived or passed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 5 — Exact Boundary
//The store opens at:
//9:00 AM

//Check the current time.

//If the current time is exactly 9:00 AM or later:
//The store has opened.

//If it is before 9:00 AM:
//The store has not opened yet.

//Pay special attention to the case where the time is exactly 9:00 AM.

// TimeOnly opensAt = TimeOnly.Parse("9:00 AM");
// string nineAm = opensAt.ToString("h:mm tt");
// Console.WriteLine(nineAm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine(timeNow);
//
// if (currentTime >= opensAt)
// {
//     Console.WriteLine("The store has opened.");  
// }
// else
// {
//     Console.WriteLine("The store has not opened.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 3 — Is the Time Inside the Range?
//Exercise 6 — Library Opening Hours

//The library:
//Opens: 08:00

//Closes: 17:00

//It is considered open:
//Starting exactly 08:00

//Until before 17:00

//The program should display:
//The library is open.

//Or:

//The library is closed.
//Depending on the current time.

// TimeOnly libraryOpens = TimeOnly.Parse("08:00");
// string eightAm = libraryOpens.ToString("HH:mm");
// Console.WriteLine(eightAm);
//
// TimeOnly libraryClose = TimeOnly.Parse("17:00");
// string seventeenPm =  libraryClose.ToString("HH:mm");
// Console.WriteLine(seventeenPm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine(timeNow);
//
// if (currentTime >= libraryOpens && currentTime < libraryClose)
// {
//     Console.WriteLine("The library is open.");  
// }
// else
// {
//     Console.WriteLine("The library is close.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 7 — Swimming Pool

//The pool:
//Opens: 06:30 AM
//Closes: 9:00 PM

//Write a program that checks if it is open now.

//At exactly the opening time it is open.
//At exactly the closing time it is already closed.

//Output:
//The swimming pool is open.

//Or:
//The swimming pool is closed. 

// TimeOnly opens = TimeOnly.Parse("06:30 AM");
// string sixAm = opens.ToString("HH:mm tt");
// Console.WriteLine(sixAm);
//
// TimeOnly closes = TimeOnly.Parse("9:00 PM");
// string ninePm = closes.ToString("h:mm tt");
// Console.WriteLine(ninePm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm tt");
// Console.WriteLine(timeNow);
//
// if (currentTime >= opens && currentTime < closes)
// {
//     Console.WriteLine("The swimming pool is open.");  
// }
// else
// {
//     Console.WriteLine("The swimming pool is closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    
//Exercise 8 — Computer Lab

//The computer lab is open:
//10:00 AM - 4:30 PM

//Use three TimeOnly variables:
//opensAt
//closesAt
//currentTime

//and print:
//Computer lab: OPEN
//or:
//Computer lab: CLOSED

// TimeOnly opensAt = TimeOnly.Parse("10:00 AM");
// string tenAm = opensAt.ToString("HH:mm tt");
// Console.WriteLine(tenAm);
//
// TimeOnly closesAt = TimeOnly.Parse("4:30 PM");
// string forPm =  closesAt.ToString("h:mm tt");
// Console.WriteLine(forPm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm tt");
// Console.WriteLine(timeNow);
//
// if (currentTime >= opensAt && currentTime < closesAt)
// {
//     Console.WriteLine("Computer lab: OPEN");
// }
// else
// {
//     Console.WriteLine("Computer lab: CLOSE");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 4 — Avoid Contradictory Conditions
//Exercise 9 — Leaving for Work

//You need to leave for work at:
//7:45 ​​AM

//Before this time:
//Stay home.

//Exactly at 7:45 or after:
//Leave for work.

//There are only two situations here.

// TimeOnly leaveForWork = TimeOnly.Parse("7:45 AM");
// string sevenFortyFiveAm = leaveForWork.ToString("h:mm tt");
// Console.WriteLine(sevenFortyFiveAm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine(timeNow);
//
// if (currentTime >= leaveForWork)
// {
//     Console.WriteLine("Leave for work.");
// }
// else
// {
//     Console.WriteLine("Stay home.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 10 — Closing Time

//A restaurant closes at:
//11:00 PM

//If it is still before closing time:
//The restaurant has not closed yet.

//Exactly at or after 11:00 PM:
//The restaurant is closed.

// TimeOnly closeAt = TimeOnly.Parse("11:00 PM");
// string elevenPm = closeAt.ToString("hh:mm tt");
// Console.WriteLine(elevenPm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine(timeNow);
//
// if (currentTime < closeAt)
// {
//     Console.WriteLine("The restaurant has not closed yet.");
// }
// else
// {
//     Console.WriteLine("The restaurant is closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 5 — Three Time Ranges

//Exercise 11 — Parts of the Day

//Use the current time.

//The ranges are:
//Before 12:00 PM
//Morning
//12:00 PM until before 5:00 PM
//Afternoon
//5:00 PM and later
//Evening

//Print only one of the options:
//Morning
//Afternoon
//Evening


// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm tt");
// Console.WriteLine(timeNow);
//
// TimeOnly morning = TimeOnly.Parse("12:00 PM");
// string twelvePm = morning.ToString("HH:mm tt");
// Console.WriteLine(twelvePm);
//
// TimeOnly afternoon = TimeOnly.Parse("5:00 PM");
// string fivePm = afternoon.ToString("h:mm tt");
// Console.WriteLine(fivePm);
//
// if (currentTime < morning)
// {
//     Console.WriteLine("Morning");
// }
// else if (currentTime >= morning && currentTime < afternoon)
// {
//     Console.WriteLine("Afternoon");
// }
// else
// {
//     Console.WriteLine("Evening");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 12 — Store Message

//A store operates according to the following rules:

//Before 9:00 AM
//The store has not opened yet.

//9:00 AM until before 8:00 PM
//The store is open.

//8:00 PM and later
//The store is closed.

//Use TimeOnly only for business hours.

// TimeOnly open = TimeOnly.Parse("9:00 AM");
// string nineAm = open.ToString("h:mm tt");
// Console.WriteLine(nineAm);
//
// TimeOnly close = TimeOnly.Parse("8:00 PM");
// string eightPm = close.ToString("h:mm tt");
// Console.WriteLine(eightPm);
//
// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm tt");
// Console.WriteLine(timeNow);
//
// if (currentTime < open)
// {
//     Console.WriteLine("The store has not opened yet.");
// }
// else if (currentTime >= open && currentTime < close)
// {
//     Console.WriteLine("The store is open.");
// }
// else
// {
//     Console.WriteLine("The store is closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 6 — Formatting + Logic Together
//Exercise 13 — Pharmacy

//Pharmacy:
//Opening time: 08:30 AM

//Closing time: 07:30 PM

//The program should display:
//Current time: ...
//Opening time: ...
//Closing time: ...

//All three hours must be in the format:
//HH:mm

//Then:
//The pharmacy is open.
//OR:
//The pharmacy is closed.

// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine($"Current time: {timeNow}");
//
// TimeOnly openingTime = TimeOnly.Parse("08:30 AM");
// string eightThirtyAm = openingTime.ToString("HH:mm");
// Console.WriteLine($"Opening time: {eightThirtyAm}");
//
// TimeOnly closingTime = TimeOnly.Parse("07:30 PM");
// string sevenAndAHalfPm = closingTime.ToString("HH:mm");
// Console.WriteLine($"Closing time: {sevenAndAHalfPm}");
//
// if (currentTime >= openingTime && currentTime < closingTime)
// {
//     Console.WriteLine("The pharmacy is open.");
// }
// else
// {
//     Console.WriteLine("The pharmacy is closed.");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Final Challenge — TimeOnly Mastery

//A coffee shop is open between:
//06:45 AM
//and:
//09:15 PM

//Create a program that does all of the following:
//Stores the opening time in TimeOnly.
//Stores the closing time in TimeOnly.
//Gets the current time.

//Displays the three hours in HH:mm format.

//Checks if the current time is within the operating hours.
//At exactly the opening time — the coffee shop is open.
//At exactly the closing time — the coffee shop is closed.
//At the end, one of two messages is displayed:
//The coffee shop is currently open.

//Or:
//The coffee shop is currently closed.

// TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
// string timeNow = currentTime.ToString("HH:mm");
// Console.WriteLine($"Current time: {timeNow}");
//
// TimeOnly open = TimeOnly.Parse("06:45 AM");
// string sixFortyFiveAm = open.ToString("HH:mm");
// Console.WriteLine($"Opening time: {sixFortyFiveAm}");
//
// TimeOnly close = TimeOnly.Parse("09:15 PM");
// string nineFifteenPm = close.ToString("HH:mm");
// Console.WriteLine($"Closing time: {nineFifteenPm}");
//
// if (currentTime >= open && currentTime < close)
// {
//     Console.WriteLine("The coffee shop is currently open.");
// }
// else
// {
//     Console.WriteLine("The coffee shop is currently closed.");
// }