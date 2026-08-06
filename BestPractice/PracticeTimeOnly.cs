//`TimeOnly` Exercise
//Part 1 — Creating Hours
//Exercise 1 — Opening Time
//Create a `TimeOnly` variable named:
//storeOpenAt
// Input the time `9:00 AM` into it using `TimeOnly.Parse`, and then print it.
//The result should represent:
//9:00 AM

// TimeOnly storeOpenAt = TimeOnly.Parse("09:00 AM");
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

// ### Exercise 5 — Differentiating `DateTime` from `TimeOnly`
//
// Create a `DateTime` variable named:
//
//     ```csharp
//     **currentDateAndTime**
//
//     ```
//
// and enter into it:
//
//     ```csharp
//     **DateTime.Now**
//
//     ```
//
// Then create a `TimeOnly` variable named:
//
//     ```csharp
//     **currentTime**
//
//     ```
//
// and extract only the time from `currentDateAndTime`.
//
// Print the two variables and check the difference:
//
//     ```csharp
//     **Full date and time: ...
//
// Time only: ...


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~