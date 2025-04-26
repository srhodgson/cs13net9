﻿using System.Globalization; // To use CultureInfo
// Set current culture to US English so that all readers see the same ouptut 
// as shown in the book.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
// WriteToFIle(formatted); // Writes the string into a file;

WriteLine();
// Three parameter values can use named arguments 
WriteLine("{0} {1} lived in {2}.",
arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

WriteLine();
// Four or more parameters cannot use named arguments 
WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
"Roger", "Cevung", "stockholm", "Education", "Optimizely");

WriteLine();
// The following statement must be all on one line when using c#10 or earlier.
// If using c# 11 or later, we can include a line break in the middle of an 
// expression but not in the string text.
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

WriteLine();

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine(format: "{0,-10} {1,6}",
arg0: "Name", arg1: "Count");
WriteLine(format: "{0,-10} {1,6:N0}",
arg0: applesText, arg1: applesCount);
WriteLine(format: "{0,-10} {1,6:N0}",
arg0: bananasText, arg1: bananasCount);


