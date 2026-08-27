using static System.Console;

WriteLine("* Top-Level functions examples");

WhatsMyNameSpace(); // Call the function.

void WhatsMyNameSpace()
{
    WriteLine("Namespace of Program class: {0}",
        arg0: typeof(Program).Namespace ?? "null");
}