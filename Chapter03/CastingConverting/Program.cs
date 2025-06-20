using static System.Convert;

int a = 10;
double b = a; // An int can be safely cast into a double 
WriteLine($"a is {a}, b is {b}");

double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}");

long e = 5_000_000_000;
int f = (int)e;
WriteLine($"e is {e:N0}, f si {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

WriteLine();

WriteLine($"{0,12} {1,34}", "Decimal", "Binary");
WriteLine($"{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);

WriteLine();

long r = 0b_101000101010001100100111010100101010;
int s = (int)r;
WriteLine($"{r,38:B38} = {r}");
WriteLine($"{s,38:B32} = {s}");

WriteLine();

double g = 9.8;
int h = ToInt32(g); // A method of System.Convert 
WriteLine($"g is {g}, h is {h}");