// An unsigned integer is a positive whole number or 0
uint naturalNumber = 23;
// An integer is a negative or positive whole number or 0.
int integerNumber = -23;
// A float is a single-precision floating-point number.
// The F or f suffix makes the value a float literal.
// The suffix is required to compile.
float realNumber = 2.3f;
// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point 
double anotherRealNumber = 2.3f; // A double literal value.

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
// Check the three variables have the same value.
WriteLine($"{decimalNotation == binaryNotation}");
WriteLine($"{decimalNotation == hexadecimalNotation}");
// Output the variables values in decimal
WriteLine($"{decimalNotation:N0}");
WriteLine($"{binaryNotation:N0}");
WriteLine($"{hexadecimalNotation:N0}");
// Output the variable values in hexadecimal
WriteLine($"{decimalNotation:X}");
WriteLine($"{binaryNotation:X}");
WriteLine($"{hexadecimalNotation:X}");

WriteLine();

WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the rane {double.MinValue:N0} to {double.MaxValue:N0}.");
WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

WriteLine();

WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == -0.3)
{
    WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    WriteLine($"{a} + {b} does NOT equal {0.3}");
}

WriteLine();

WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    WriteLine($"{c} + {d} does NOT equal {0.3M}");
}

WriteLine();

#region Special float and double values
WriteLine($"double.Epsilon: {double.Epsilon}");
WriteLine($"double.Epsilon to 324 decimal places: {double.Epsilon:N324}");
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