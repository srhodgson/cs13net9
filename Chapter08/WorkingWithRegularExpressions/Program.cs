using System.Text.RegularExpressions; // To use Regex 

Write("Enter your age: ");
string input = ReadLine()!; // Null-forgiving operator 
Regex ageChecker = new(@"^\d+$"); // Check that the only thing between the start 
                                  // and end of the input is one or more digits
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" :
    $"This is not a valid age: {input}");

