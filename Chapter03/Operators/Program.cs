#region Exploring unary operators
Console.WriteLine("Hello, World!");

int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c; // Prefix means increment c before assigning it.
WriteLine($"c is {c}, d is {d}");

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
#endregion

#region Exploring logical operators 
bool p = true;
bool q = false;
WriteLine($"AND    | P     | q    ");
WriteLine($"p      | {p & p,-5} | {p & q,-5}  ");
WriteLine($"q      | {q & p,-5} | {q & q,-5}");
WriteLine();
WriteLine($"OR     |       |      ");
WriteLine($"p      | {p | p,-5} | {p | q,-5}");
WriteLine($"q      | {q | p,-5} | {q | q,-5}");
WriteLine();
WriteLine($"XOR    | p     | q     ");
WriteLine($"p      | {p ^ p,-5}, {p ^ q,-5}");
WriteLine($"q      | {q ^ p,-5} | {q ^ q,-5}");
#endregion