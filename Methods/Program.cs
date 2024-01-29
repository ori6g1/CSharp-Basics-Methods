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
{ return (int)Math.Pow(number, 3); }

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
Console.Write("Enter the first number to add: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the second number to add: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine(Multiply(firstNumber, secondNumber) + lineBreak);

Console.WriteLine("// A2");
Console.Write("Enter a number to raise to the power of 3: ");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine(RaiseToPowerOfThree(firstNumber) + lineBreak);

Console.WriteLine("// A3");
Console.Write("Enter a string, to check if it is empty: ");
string str1 = Console.ReadLine();
if (IsStringEmpty (str1))
    Console.WriteLine("The string is empty." + lineBreak);
else
    Console.WriteLine("The string is not Empty." + lineBreak);

Console.WriteLine("// A4");
Console.Write("Enter a number to check if it is larger than 40: ");
firstNumber = int.Parse(Console.ReadLine());
if (IsLargerThanForty(firstNumber))
    Console.WriteLine("The number is larger than 40." + lineBreak);
else
    Console.WriteLine("The number is smaller or equal to 40." + lineBreak);

Console.WriteLine("// A5");
Console.Write("Enter a number to print all numbers up to it: ");
firstNumber = int.Parse(Console.ReadLine());
PrintNumbersFrom0(firstNumber);
Console.WriteLine(lineBreak);

// B - Methods
// 1
double RaiseExponent (int baseNumber, int exponent)
{ return Math.Pow(baseNumber, exponent); }

// 2
float Remainder (int dividend, int divisor)
{ return dividend % divisor; }

// 3 
string Concatinate (string str1, string str2)
{ return str1 + str2; }

// 4
int FindGreatestDivisor (int num1, int num2)
{
    int largestDivisor = 1;

    for (int i = 2; (i <= Math.Sqrt(num1)) || (i <= Math.Sqrt(num2)); i++)
        if ((num1 % i == 0) && (num2 % i == 0))
            largestDivisor = i;
    return largestDivisor;
}

// 5
int AddDigits (int num)
{
    int sum = 0;

    for (int tmpNum = num; tmpNum > 0; tmpNum /= 10)
        sum += (tmpNum % 10);

    return sum;
}

// 6
int CountSpaces (string str)
{
    int spacesCount = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
            spacesCount++;
    }
    return spacesCount;
}

// Invokes
Console.WriteLine("// B1");
Console.Write("Enter a number as the base: ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter a number as the exponent: ");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The raised number is: " + RaiseExponent(firstNumber, secondNumber) + lineBreak);

Console.WriteLine("// B2");
Console.Write("Enter a number as the dividend: ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter a number as the divisor: ");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The remainder between the numbers is: " + Remainder(firstNumber, secondNumber) + lineBreak);

Console.WriteLine("// B3");
Console.Write("Enter a string to concatinate: ");
str1 = Console.ReadLine();
Console.Write("Enter another string to concatinate: ");
string str2 = Console.ReadLine();
Console.WriteLine("The concatination of the strings: " + Concatinate(str1, str2) + lineBreak);

Console.WriteLine("// B4");
Console.Write("Enter a first number: ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter a second number: ");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The greatest divisor among the two numbers is: " + FindGreatestDivisor(firstNumber, secondNumber) + lineBreak);

Console.WriteLine("// B5");
Console.Write("Enter a number to add its digits: ");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The sum of all digits is: " + AddDigits(firstNumber) + lineBreak);

Console.WriteLine("// B6");
Console.Write("Enter a string to count its spaces: ");
str1 = Console.ReadLine();
Console.WriteLine("The amount of spaces in the string is: " + CountSpaces(str1) + lineBreak);