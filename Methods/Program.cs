// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// -----------------------------

string lineBreak = "\r\n";

// A - Methods (W.I.C)
// 1
int Multiply (int firstNumber, int secondNumber)
{ return (firstNumber * secondNumber); }

// 2
int RaiseToPowerOfThree (int number)
{ return (number * number * number); }

// 3
bool IsStringEmpty (string str)
{ return str.Length == 0; }

// 4
bool IsLargerThanForty (int number)
{ return number > 40; }

// 5
void PrintNumbersFrom0 (int number)
{
    Console.Write("0");
    for (int i = 1; i <= number; i++)
        Console.Write(", " + i);
}

// Invokes
Console.WriteLine("// A1");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine(Multiply(firstNumber, secondNumber) + lineBreak);

Console.WriteLine("// A2");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine(RaiseToPowerOfThree(firstNumber) + lineBreak);

Console.WriteLine("// A3");
string str = Console.ReadLine();
if (IsStringEmpty (str))
    Console.WriteLine("The string is empty." + lineBreak);
else
    Console.WriteLine("The string is not Empty." + lineBreak);

Console.WriteLine("// A4");
firstNumber = int.Parse(Console.ReadLine());
if (IsLargerThanForty(firstNumber))
    Console.WriteLine("The number is larger than 40." + lineBreak);
else
    Console.WriteLine("The number is smaller than 40." + lineBreak);

Console.WriteLine("// A5");
firstNumber = int.Parse(Console.ReadLine());
PrintNumbersFrom0(firstNumber);
Console.WriteLine(lineBreak);