// All types in this file will be defined in this file-scoped name-space 
namespace Packt.Shared;

public class Person : Object
{
    #region Fields: Data or state for this person.
    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavouriteAncientWonder;
    #endregion
}