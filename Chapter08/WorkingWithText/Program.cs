using System.Globalization; // To use CultureInfo
OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro Symbol

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");
WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

WriteLine();

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} cities in the array.");
foreach (string item in citiesArray)
{
    WriteLine($"    {item}");
}

WriteLine();

string fullName = "Alan Shore";
int indexOfTheSpace = fullName.IndexOf(' ');
string firstName = fullName.Substring(
    startIndex: 0, length: indexOfTheSpace);
string lastName = fullName.Substring(
    startIndex: indexOfTheSpace + 1);
WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");    

WriteLine();

string company = "Microsoft";
WriteLine($"Text: {company}");
WriteLine($"Starts with M: {0}, contains an N: {1}",
    arg0: company.StartsWith('M'), arg1: company.Contains('N'));

WriteLine();

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");
string text1 = "Mark";
string text2 = "MARK";
WriteLine($"text1: {text1}, text2: {text2}");
WriteLine("Compare: {0}.", string.Compare(text1, text2));
WriteLine("Compare (ignoreCase): {0}.",
    string.Compare(text1, text2, ignoreCase: true));
WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
    string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase));
// German string comparisons 
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
text1 = "Strasse";
text2 = "Straße";
WriteLine($"text1: {text1}, text2: {text2}");
WriteLine("Compare: {0}.", string.Compare(text1, text2,
    CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace));
WriteLine("Compare (IgnoreCase, IgnoreNonSPace): {0}.",
    string.Compare(text1, text2, CultureInfo.CurrentCulture,
    CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase));
WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
    string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase));