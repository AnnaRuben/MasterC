string[] firstNames = new string[5];

firstNames[0] = "Tim";
firstNames[1] = "Sue";
firstNames[2] = "Bob";
firstNames[4] = "Jane";

Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]},  {firstNames[2]}, {firstNames[4]}");



//Array is a Variable type, that holds a bunch of something  

//we create new string array called first names.
//the variable firstNames holds 5 strings.
//this means how many position there will be,  how many values we are going to hold ,in this case 5:


//~~~~~~~~
//string[5]
//~~~~~~~~


//here we are referencing one of those specific 5, in this case the item at the position 0 :    


//~~~~~~~~~~~~~~~~~~
//firstNames[0] = "Tim";
//~~~~~~~~~~~~~~~~~~


//important to understand that in programing we have 0 based counting .
//0 based counting:
//0, 1, 2, 3, 4 = 5 items.
//item 0 is the first one, 
//item 1 is the second one,
//item 2 is the third one,
//item 3 is the fourth one,
//item 4 is the fifth  one,

//one based counting :
//1, 2, 3, 4, 5 = in the real world .

//we can skip one and write only 0, 1, 2, and 4:


//~~~~~~~~~~~~~~~~~~
// firstNames[0] = "Tim";
// firstNames[1] = "Sue";
// firstNames[2] = "Bob";
// firstNames[4] = "Jane";
//~~~~~~~~~~~~~~~~~~


//position 3 is empty ,is not been used right now, and that can be ok, usually we want to actually put a value there, but we just want to see that we aren't forced in to use all of them or even in order, we can have just position 4 to fill and nothing else.         
//so is it messy ? yes !
//is it something we probably going to do very often ? no !
//but it is possible. 









