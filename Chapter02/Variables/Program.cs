using System.Xml; // To use XmlDocument

#region Storing any type of object
object height = 1.88; // Storing a double in an object 
object name = "Amir"; // Storing a string in an object 
WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length; // This gives a compile error 
int length2 = ((string)name).Length; // Cast name to a string 
WriteLine($"{name} has {length2} characters.");
#endregion 

WriteLine();

#region Storing dynamic types
dynamic something;
// Storing an array of int values in a dynamic object.
// An array of any type has a Length property
something = new[] { 3, 5, 7 };
// Storing an int in a dynamic object.
// int does not have a Length property.
//something = "Steve";
// This compiles but might throw an exception at run-time.
WriteLine($"Then length of something is {something.Length}");
// Output the type of the something variable.
WriteLine($"something is a {something.GetType()}");
#endregion

WriteLine();

#region Inferring the type of a local variable
var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds stirling 
var fruit = "Apples"; // string values use single-quotes 
var letter = 'z'; // char values use single-quotes 
var happy = true; // Booleans can only be true or false 

WriteLine();

// Good use of var because it avoids the repeated type 
// as shown in the more verbose second statement.
var xml1 = new XmlDocument(); // Works with C# 3 and later 
XmlDocument xml2 = new XmlDocument(); // Works with all C# versions

// Bad use of var because we cannot tell the type, so we 
// should use a specific type declaration as shown in
// the second statement.
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");
#endregion