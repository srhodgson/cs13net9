#region Exploring unary operators
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");
int c = 3;
int d = c++;
WriteLine($"c is {c}, d is {d}");
#endregion

WriteLine();

#region Binary arithmetic operators
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = { e + f}");
WriteLine($"e - f = { e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

WriteLine();

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
#endregion

WriteLine();

#region Exploring logical operators

bool p = true;
bool q = false;
WriteLine($"AND     | P     | q     ");
WriteLine($"p       | {p & p,-5} | {p & q,-5}  ");
WriteLine($"q       | {q & p,-5} | {q & q,-5}  ");
WriteLine();
WriteLine($"OR      | P     | q     ");
WriteLine($"p       | {p | p,-5} | {p | q,-5}  ");
WriteLine($"q       | {q | p,-5} | {q | q,-5}  ");
WriteLine();
WriteLine($"XOR     | P     | q     ");
WriteLine($"p       | {p ^ p,-5} | {p ^ q,-5}  ");
WriteLine($"q       | {q ^ p,-5} | {q ^ q,-5}  ");
#endregion

WriteLine();

#region Conditional logical operators
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");
WriteLine();
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");
#endregion

WriteLine();

#region bitwise and binary shift operators
int x = 10;
int y = 6;
WriteLine($"Expression  | Decimal |   Binary");
WriteLine($"--------------------------------");
WriteLine($"x           | {x,7} | {x:B8}");
WriteLine($"y           | {y,7} | {y:B8}");
WriteLine($"x & y       | {x & y,7} | {x & y:B8}");
WriteLine($"x | y       | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y       | {x ^ y,7} | {x ^ y:B8}");
// Left-shift x by three bit columns
WriteLine($"x << 3      | {x << 3,7} | {x << 3:B8}");
// multiply x by 8
WriteLine($"x * 8       | {x * 8,7} | {x * 8:B8}");
// Right-shift y by 1
WriteLine($"y >> 1      | {y >> 1,7} | { y >> 1:B8}");
#endregion

static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}