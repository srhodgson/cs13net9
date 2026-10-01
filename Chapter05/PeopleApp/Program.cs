using Packt.Shared; // To use Person.
ConfigureConsole(); // Sets current culture to US English.
// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture 
// ConfigureConsole(culture: "fr-FR"); // Use French culture.

// Person  bob = new Person(); // C# 1 or later.
// var bob = new Person(); // C# 3 or later.
Person bob = new(); // C# 9 or later.
WriteLine(bob); // Implicit call ToString().
// WriteLine(bob.ToString()); // Does the same thing 

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time
bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine(format: "{0} was born on {1:D}.", // Long date.
    arg0: bob.Name, arg1: bob.Born);
WriteLine(format: "{0}'s favourite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavouriteAncientWonder,
    arg2: (int)bob.FavouriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

WriteLine();

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
        // This is an optional offset from UTC time zone
        TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.",
    arg0: alice.Name, arg1: alice.Born);
    
#region Understanding generic collections
// Works with all version of C#.
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 and later.
bob.Children.Add(new Person { Name = "Bella" });

// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}
#endregion    

WriteLine();

#region Making a field static

BankAccount.InterestRate = 0.012M; // Store a shared value in static field.
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Mr. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);
#endregion

WriteLine();

// Constant fields are accessible via the type.
WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine();

// Read-only fields are accesible via the variable.
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

WriteLine();
/*
// Instantiate a book using object initialiser syntax.
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
*/

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author, book.PageCount);

WriteLine();

Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

WriteLine();

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

WriteLine();

bob.WriteToConsole();
WriteLine(bob.GetOrigin());    

WriteLine();

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3,"Jump!", 98.5));
WriteLine(bob.OptionalParameters(3,number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(3,"Poke!", active: false));

WriteLine();

int a = 10;
int b = 20;
int c = 30;
int d = 40;
int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");
WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");
// Simplified C# 7 or later syntax for the out parameter 
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

WriteLine();
bob.ParamsParameters("Sum using commas", 3, 6, 1, 2);
bob.ParamsParameters("Sum using collection expression", [3,6,1,2]);
bob.ParamsParameters("Sum using explicit array", new int[] { 3, 6, 1, 2 });
bob.ParamsParameters("Sum(empty)");

WriteLine();

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
