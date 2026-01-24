using System.IO.Pipes;

namespace Packt.Shared;

public partial class Person
{
    // A read-write property define using C# 3 auto-syntax.
    public string? FavouriteIceCream { get; set; }
    // A private backing field to store the property value .
    private string? _favoritePrimaryColour;
    // A public property to read and write to the field.
    public string? FavoritePrimaryColour
    {
        get
        {
            return _favoritePrimaryColour;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColour = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is not a primary colour. " + "Choose from: red, green, blue.");
            }
        }
    }

    private WondersOfTheAncientWorld _favouriteAncientWonder;
    public WondersOfTheAncientWorld FavouriteAncientWonder
    {
        get { return _favouriteAncientWonder; }
        set
        {
            string wonderName = value.ToString();
            if (wonderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favourite ancient wonder can only have a single enum value.",
                    paramName: nameof(FavouriteAncientWonder));
            }
            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    $"{value} is not a member of the WonderOfTheAncientWorld enum.",
                    paramName: nameof(FavouriteAncientWonder));
            }
            _favouriteAncientWonder = value;
        }
    }

    #region Properties: Methods to get and/or set data or state.
    // A readonly property defined using C# 1 to 5 sytanx.
    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}.",
                arg0: Name, arg1: HomePlanet);
        }
    }

    // Two readonly properties defined using C# 6 or later lambda expression
    // body syntax .
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;
    #endregion

    #region Indexers: Properties that use array syntax to access them.
    public Person this[int index]
    {
        get
        {
            return Children[index]; // Pass on to the List<T> indexer.
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
    }
    #endregion


}
