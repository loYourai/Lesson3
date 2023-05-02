// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");


//string name = "Danil";
/*
if (name == "Danil") ;
{
    Console.WriteLine("Name is Danil");

}
else if (name == "danil")
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

*/


/*
string result = name == "Danil" 
    ? "NAme id Danil" 
    : name == "danil" 
    ? "NAME is Danil"
    : "Name is not Danil";

Console.WriteLine(result);
*/

// SWITCH



//2 варик
// string? nameFromConsole = Console.ReadLine(); //или desable в другой лист 
//switc ()
/*
//string switchresult = "";
switch (name)
{
   case "Danil":
       Console.WriteLine("Name is Danil");
       // switchresult ="";
       break;
   case "danil":
       Console.WriteLine("Name is Danil");
       // switchresult ="";
       break;
       default:
       Console.WriteLine("Name is unknown");
       // switchresult ="";
       break;
}
*/

//Console.WriteLine(switchresult);


//ЦИКЛЫ
/*
 bool condition = false; //while будет выполняться всегда
while (true)
{
    ///1
    ///2
    ///3
    break;
}


do //делает потом повиряет если не сошлись ответы то опять делает
{
//1

}
while (condition);


// int i = 0; можно указать и за скобками, но если надо только в цикл то лучше в скобках
int number = 5;
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("i = " + i);
    if (int == 7)
    {
        Console.WriteLine("Found 7!");
        break;
    }
    
    sum += number;
}
Console.WriteLine("Sum of 5 nimber 10 times" + sum);
*/

//int number = 0;
/*
while (true)
{
    number++;
    Console.WriteLine("Number: " + number);
     if (number == 7)
    {
        break;
    }
}

Console.WriteLine("Found 7!");
*/
/*
do
{
    Console.WriteLine("Number" + number++);
    if (number == 7)
    {
        break;
    }
}
while (true);
*/
/*
int number = 0;
int sum  = 0;  
while (number < 10)
{
    /*
    sum += number++ % == 0 
        ? number                  2варик
        : 0;
    */
/*
    if (number++ % 2 != 0) // 0/2/4/6/8/10
    {
        continue;
    }
    sum += number;
}
Console.WriteLine("Sum " + sum);

*/
/*

string name = Console.ReadLine();
int number = 0;
bool conversionResult =  int.TryParse(name, out number);



if (!conversionResult)
{
    Console.WriteLine("Input is incorrect format");
}
else
{
    if (number == 0)
    {
        Console.WriteLine("It's a zero");
    }
    else if (number > 1) 
    {
        Console.WriteLine("Positive number");

    }
    else
    {
        Console.WriteLine("Negative number");
    }


    /*
    Console.WriteLine("It's a number");
    if (number > 1000)
    {
        Console.WriteLine("This number is too big!");
    }
    
}

Console.WriteLine(number);
*/


Console.WriteLine("Enter first number:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int number2 = int.Parse(Console.ReadLine());
int result = 0;
if (number1 > 0  && number2 > 0)
{
    result = number1 * number2;
}
Console.WriteLine("Multiplication result: " + result);