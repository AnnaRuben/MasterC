// string[] firstNames = new string[5];
//
// firstNames[0] = "Tim";
// firstNames[1] = "Sue";
// firstNames[2] = "Bob";
// firstNames[4] = "Jane";
//
// Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]},  {firstNames[2]}, {firstNames[4]}");
//
// firstNames[0] = "Timothy";
//
// Console.WriteLine(firstNames[0]);
//
// firstNames[5] = "Robert";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//single quote identifies a char 

//double quotes identifies a string

// string data = "Tim,Sue,Bob,Jane,Frank";
// string[] firstNames = data.Split(',');
//
// Console.WriteLine(firstNames[1]);
//
// Console.WriteLine(firstNames[firstNames.Length - 1]);
//
// Console.WriteLine(firstNames.Length);
//
// string[] lastNames = new string[];
//
// string[] lastNames = new string[] {"Corey", "Smith", "Jons"};
//
// int[] ages = new int[] {2, 3, 4};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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

//if we want to change the "Tim" to "Thimoty" :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~
//firstNames[0] = "Timothy";
//Console.WriteLine(firstNames[0]);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we can't go beyond 5 .
//let's say we want 6 .


//~~~~~~~~~~~~~~~~~~~~
//firstNames[5] = "Robert";
//~~~~~~~~~~~~~~~~~~~~


//it's stops right here.
//and it says index out of range exception.
//the index is out of bounds of the array, it's looking for something that doesn't exist  .
//it's a very expensive process to add one more element to array and it's not something that we really want to do.
//we need to create a brand new array and we then copy all values over to that new array and add that new extra field.  
//remember, when we choosing this number here:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string[] firstNames = new string[5];
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we want to know for certain what that number should be because if we pick too small then we have to Rerevision our entire array over again in order to get that extra field or spot or two if we needed.        
//so remember that with arrays ,we really want to work with the size that we've given ,or we want to give it a size that is prety much exactly what we want      

//imagine that we have some data ,and this data is :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string data = "Tim,Sue,Bob,Jane,Frank";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we might get this from a line in a CSV file 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// string data = "Tim,Sue,Bob,Jane,Frank";
// string[] firstNames = data.Split(',');
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we used here a single quote and not a double quotes, that was ententional, we can use double quotes here, that because it allows 2 different types of values, single quote and double quotes are a different types of values. 
//the differences are :
//a single quote:
//identifies a char.
//which is short for character, that means a single character, in this case a single character means a comma (,)

//double quotes:
//identifies a string


//here we have double quotes because this is a string value:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string data = "Tim,Sue,Bob,Jane,Frank";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we are going to split this string based up on a commas (,) and it's going to put a value in to an array called firstNames.
//so now we have:


//~~~~~~~~~~~~~~~~~~~
// firstNames[0] = "Tim";
// firstNames[1] = "Sue";
// firstNames[2] = "Bob";
// firstNames[4] = "Jane";
// firstNames[5] = "Frank";
//~~~~~~~~~~~~~~~~~~~


//and it's a total of 5 values.
//notice that we are not hard coding, like here when we saied new string with 5 positions :   


//~~~~~~~~~~~~~~~~~~~~~~~~~~~
// string[] firstNames = new string[5];
//~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we are not hard coding here, because this split is going to figure out how many values we need and put just that many in to our string array:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// string[] firstNames = data.Split(',');
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//that will give us "Sue", because it knows that position 1 is Sue:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// string data = "Tim,Sue,Bob,Jane,Frank";
// string[] firstNames = data.Split(',');

// Console.WriteLine(firstNames[1]);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//so how we are going to figure out how to go through that ?
//we can have the idea of length and that gives the total number of elements in all dimensions of the array, it gives how long the array is :    


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine(firstNames.Length);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//after we run this ,we see that the length is 5 ,so we know how long this array is, it's got 5 elements in it.
//remember ,the Length is a 1 based counting, because if it has 1 element in it, the length is going to be 1 ,but it's at position 0, so we can't ever say give me the first name at firstName.Length:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine(firstNames[firstNames.Length]);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//because that always going to be an out of bounds exception, because it's a 0 based counting, so we have to say -1:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine(firstNames[firstNames.Length - 1]);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//that will give us a last element in the list, and when we run this ,we see Frank, and if we check ,we see that Frank is the last element in the list.

//another way to declare an array :
//lets say that we know what elements we want in the array:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string[] lastNames = new string[] {"Corey", "Smith", "Jons"};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//here we say ,instead of give a numbers in [], we give you {} with all of our values.    
//and now lastNames has 3 elements in it .
//position 0, 1, and 2 with Corey, Smith, and Jons.

//string arrays aren't the only arrays we can create .
//basically we can create an array out of anything, we just need to put the [] after it:


//~~~~~~~~~~~~~~~~~~~~~~~~~
//int[] ages = new int[] {2, 3, 4};
//~~~~~~~~~~~~~~~~~~~~~~~~~


//now we have an array of integers with 3 values in them.
//position 0, 1, and 2.
//we can do the same thing with :
//double
//decimal
//Date and Time
//bool - not sure how valuable that will be but, we can use it ,and it might be useful once in a while.    



