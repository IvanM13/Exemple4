Console.WriteLine ("Enter the first number");
string firstNumber = Console.ReadLine ();

Console.WriteLine ("Enter the second number");
string secondNumber = Console.ReadLine ();

Console.WriteLine ("Enter the third number");
string thirdNumber = Console.ReadLine ();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);
int thirdNum = int.Parse(thirdNumber);

if (firstNum > secondNum)

if (firstNum > thirdNum)
    Console.WriteLine ($"max = {firstNum}");
    
else
    Console.WriteLine($"YOU WIN!");

if (secondNum > firstNum)

if (secondNum > thirdNum)
    Console.WriteLine ($"max = {secondNum}");

else
    Console.WriteLine($"YOU WIN!");

if (thirdNum > firstNum)

if (thirdNum > secondNum)
    Console.WriteLine ($"max = {thirdNum} ");

else
    Console.WriteLine($"YOU WIN!");



  
   

