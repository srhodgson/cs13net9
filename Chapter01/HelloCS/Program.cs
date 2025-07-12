string name = typeof(Program).Namespace ?? "<null>";
Console.WriteLine($"Namespace: {name}");
throw new Exception();