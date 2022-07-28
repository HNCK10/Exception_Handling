// See https://aka.ms/new-console-template for more information
//--------------------------------------------------------------
// Exception - an error that occurs during execution
// -------------------------------------------------------------
// try = try some code that is considered "dangerous"
// catch = catches and handles exceptions when they occur
// finally = always executes regardless if exception is caught or not
// -------------------------------------------------------------
//double x, y, result;
//Console.WriteLine("Enter number 1: ");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter number 2: ");
//y = Convert.ToDouble(Console.ReadLine());
//result = x / y;
//Console.WriteLine("Result: "+result);
//Console.ReadKey();
// The above code is without exception handling and so if a user puts
// a  number divided by a text an error will occur
// Exception unhandled: System.FormatException "input string was not in
// the correct format.
// so we edit this program for exceptions below
//------------------------------------------------------------------
int x, y; 
double result;
// dangerous code so we add try
try
{
    Console.WriteLine("Enter number 1: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number 2: ");
    y = Convert.ToInt32(Console.ReadLine());
    result = x / y;
    Console.WriteLine("Result: " + result);
}
// if we have a try block we also need a catch block with the Exception name
catch (FormatException e)
{
    Console.WriteLine("Enter only numbers please!");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You cannot divide by zero!");
}
catch(Exception e)
{
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("Thanks for visitng");
}
Console.ReadKey();