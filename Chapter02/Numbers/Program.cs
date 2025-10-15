// An unsigned integer is a positive whole number or 0.

using System.Linq.Expressions;

uint naturalNumber = 23;
// An integer is a negative or positive whole number or 0.
int integerNumber = -23;
// A float is a single-precision floating-point number.
// The F or f suffix makes the value a float literal.
// The suffix is required to compile.
float realNumber = 2.3f;
// A double is s double-precision floating-point number.
// double is the default for a number value with a decimal point.
double anotherRealNumber = 2.3; // A double literal value.

WriteLine();

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480; 
// Check the three variables have the same value 
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
// Output the variable values in decimal 
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");

WriteLine();

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MaxValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double use {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

WriteLine();

Console.WriteLine("Using doubles: ");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

WriteLine();

Console.WriteLine("Using decimals: ");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}

WriteLine();

#region Special float and double values
WriteLine($"double.Epsilon: {double.Epsilon}");
WriteLine($"double.Epsilon to 234 decimal places: {double.Epsilon:N234}");
WriteLine($"double.Epsilon to 330 decimal places: {double.Epsilon:N330}");
const int col1 = 37; // First column width 
const int col2 = 6; // Second column width 
string line = new string('-', col1 + col2 + 3);
WriteLine(line);
WriteLine($"{"Expression",-col1} | {"Value",col2}");
WriteLine(line);
WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
WriteLine(line);
WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity,col2}");
WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}");
WriteLine(line);
#endregion

#region New number types and unsafe code

unsafe
{
    WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}");
    WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}");
}
#endregion