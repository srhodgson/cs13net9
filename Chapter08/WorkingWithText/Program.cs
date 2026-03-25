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