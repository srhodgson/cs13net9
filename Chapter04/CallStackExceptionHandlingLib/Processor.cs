using static System.Console;

namespace CallStackExceptionHandlingLib;

public class Processor
{
    public static void Gamma() // Public so it can be called for outside.
    {
        WriteLine("In Gamma");
        Delta();
    }

    private static void Delta() // private so it can only be called internally
    {
        WriteLine("In Delta");
        File.OpenText("bad file path!");
    }
}