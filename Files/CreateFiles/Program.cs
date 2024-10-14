﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Files

const string filename = "TestFile.txt";
// Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
using (StreamWriter sw = File.CreateText(filename)) {
sw.WriteLine("This is a text file.");
}