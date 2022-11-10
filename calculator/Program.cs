/*Name: Usman Zia*/
/*Student#: 24087*/
/*Email: 24087@student.dorset-college.ie*/

/*Printing Instructionc*/
Console.WriteLine("**********************************");
Console.WriteLine("\tCalculator");
Console.WriteLine("**********************************\n");

Console.WriteLine("Note: This console application only takes integers and decimal values, \nplease don't add any alphabatical words or letters.\n");

PointA: /*label: to start from here if user input invalid value.*/

Console.WriteLine("Please choose from following options: ");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

/*Variables*/
int userFunction = Convert.ToInt32(Console.ReadLine());/*input from user to initiate desired function*/
int userInput1 = 0;/*input value 1*/
int userInput2 = 0;/*input value 2*/
int answer = 0;/*output value*/

/*User Conditions*/
if (userFunction == 1)/*Condition #1*/
{
    Console.WriteLine("****Addition****");

    Console.WriteLine("Enter Value: 1");/*printing and taking user input 1*/
    userInput1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Value: 2");/*printing and taking user input 2*/
    userInput2 = Convert.ToInt32(Console.ReadLine());

    answer = userInput1 + userInput2; /*addition*/

    Console.WriteLine("**********************************");
    Console.WriteLine("Answer: " + answer); /*output*/
    Console.WriteLine("**********************************");
}
else if (userFunction == 2)/*Condition #2*/
{
    Console.WriteLine("****Subtraction****");

    Console.WriteLine("Enter Value: 1");/*printing and taking user input 1*/
    userInput1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Value: 2");/*printing and taking user input 2*/
    userInput2 = Convert.ToInt32(Console.ReadLine());

    answer = userInput1 - userInput2; /*subtraction*/

    Console.WriteLine("**********************************");
    Console.WriteLine("Answer: " + answer); /*output*/
    Console.WriteLine("**********************************");
}
else if (userFunction == 3)/*Condition #3*/
{
    Console.WriteLine("****Multiplication****");

    Console.WriteLine("Enter Value: 1");/*printing and taking user input 1*/
    userInput1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Value: 2");/*printing and taking user input 2*/
    userInput2 = Convert.ToInt32(Console.ReadLine());

    answer = userInput1 * userInput2; /*multiplication*/
    
    Console.WriteLine("**********************************");
    Console.WriteLine("Answer: " + answer); /*output*/
    Console.WriteLine("**********************************");
}
else if (userFunction == 4)/*Condition #4*/
{
    Console.WriteLine("****Division****");

    Console.WriteLine("Enter Value: 1");/*printing and taking user input 1*/
    userInput1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Value: 2");/*printing and taking user input 2*/
    userInput2 = Convert.ToInt32(Console.ReadLine());

    answer = userInput1 / userInput2; /*division*/

    Console.WriteLine("**********************************");
    Console.WriteLine("Answer: " + answer); /*output*/
    Console.WriteLine("**********************************");
}
else/*Condition #5*/
{
    Console.WriteLine("**********************************");
    Console.WriteLine("Invalid Entry\n");
    Console.WriteLine("**********************************");
    goto PointA;
}
Console.WriteLine("**********************************");
Console.WriteLine("\tThanks for Using Calculator");
Console.WriteLine("**********************************");
