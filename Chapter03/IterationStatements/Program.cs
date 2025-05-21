#region Looping with the while statement
int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}
#endregion

WriteLine();

#region Looping with the do statement
string? actualPassword = "Pa$$w0rd";
string? password;
do
{
    Write("Enter your password: ");
    password = ReadLine();
} while (password != actualPassword);
WriteLine("Correct!");
#endregion
