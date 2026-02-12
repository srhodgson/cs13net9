using Packt.Shared;

Person harry = new()
{
    Name = "harry",
    Born = new(year: 2001, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};
harry.WriteToConsole();