Console.WriteLine ("Введите первое число");
string firstNumber = Console.ReadLine ();

Console.WriteLine ("Введите второе число");
string secondNumber = Console.ReadLine ();

Console.WriteLine ("Введите третье число");
string thirdNumber = Console.ReadLine ();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);
int thirdNum = int.Parse(thirdNumber);

if (firstNum > secondNum)

if (firstNum > thirdNum)
    Console.WriteLine ($"max = {firstNum}");

if (secondNum > firstNum)

if (secondNum > thirdNum)
    Console.WriteLine ($"max = {secondNum}");

if (thirdNum > firstNum)

if (thirdNum > secondNum)
    Console.WriteLine ($"max = {thirdNum} ");
  
   

