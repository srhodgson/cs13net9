#region branching with the if statement
string password = "ninja";
if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
    WriteLine("your password is strong.");
}

WriteLine();
#endregion 

#region pattern matching with the is statement
// Add and remove the "" to change between string and int.

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}
#endregion