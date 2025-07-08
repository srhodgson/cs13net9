﻿using System.Reflection.Metadata;
using Packt.Shared; // To use Person
ConfigureConsole(); // Sets current culture to US English

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture 
// ConfigureConsole(culture: "fr-FR"); // Use French culture 

// Person bob = new Person(); // C# 1 or later 
// var bob = new Person(); // C# 3 or later 
Person bob = new(); // C# 9 or later 
WriteLine(bob); // Implicit call ToString().
// WriteLine(bob.ToString()); // Does the same thing 

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time
WriteLine(format: "{0} was born on {1:D}.",
    arg0: bob.Name, arg1: bob.Born);

WriteLine();

Person aliuce = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", // short date 
    arg0: aliuce.Name, arg1: aliuce.Born);
