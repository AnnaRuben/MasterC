string data = "Tim, Sue, Bob, Jane";

List<string> firstNames = data.Split(',').ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}

//purple                                                                                       foreach Loop
//A simple way of looping through. 
//means loop through every element, and we get to choose if that list grows, it will loop through more of them.
//if that list shrinks, it will do less .
//if that list is empty, it would not do it at all.

//we have a list of first names, notice that we are using plural here:
//~                                                      foreach (string firstName in --> firstNames)
//~                                                     {
     
//~                                                     }

//plural is important because it means that it's a set .
//that's why naming is important.
//if we have something that has a plural name, you are expecting more than one element in that variable.
//it might be :
//Array
//List
//Dictionary.
//it's some type of set 

//here ,this first name is singular ,means it holds one :
//~                                                      foreach (string --> firstName in firstNames)
//~                                                     {
     
//~                                                     }

//in this case the foreach loop says foreach first names(set of first names), we want to create string variable firstName, foreach first name in first names.
//it's going to create as a variable for every element in our list.
//do we care how many on the list ?
//No ,the foreach will take care of that !
//do we know what order it pulse it in ?
//It pulls it in order the list is stored, but we are not going to get that i, that iterator, that array position number.
//we are going to get is that variable called firstName .  

//~                                                                foreach (string firstName in firstNames)
//~                                                               {
//~                                                                   Console.WriteLine(firstName);
//~                                                               }

//we run this and see :
//Tim
//Sue
//Bob
//Jane

//the var option :
//~                                                                foreach (var firstName in firstNames)
//~                                                               {
//~                                                                   Console.WriteLine(firstName);
//~                                                               }

//we may see var used ,it's just a shortcut for typing out the actual type name .
//var is not variable.
//it  just means that it is whatever type it was when we first assigned it.   
