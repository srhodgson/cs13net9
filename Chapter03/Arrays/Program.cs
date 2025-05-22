string[] names; // This can reference any size array of strings.

// Allocate memory for four strings in an array
names = new string[4];

// Store items at these index positions 
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// Loop through the names 
for (int i = 0; i < names.Length; i++)
{
    // Output the item at index position i.
    WriteLine($"{names[i]} is at position {i}");
}