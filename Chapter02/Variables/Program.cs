﻿using System.ComponentModel;

object height = 1.88; // Storing a double in an object 
object name = "Amir"; // Storing a string in an object 
WriteLine($"{name} is {height} metres tall.");
// int length1 = name.Length; // This give a compile error!
int length2 = ((string)name).Length; // Cast name to a string 
WriteLine($"{name} has {length2} characters");