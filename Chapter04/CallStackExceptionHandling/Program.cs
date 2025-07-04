using System.ComponentModel;
using System.Configuration.Assemblies;
using CallStackExceptionHandlingLib;

WriteLine("In Main");
Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Beta");
    Processor.Gamma();
}