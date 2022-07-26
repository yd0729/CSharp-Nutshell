using System.ComponentModel;
using System.Drawing;

// Type converters are designed to format and parse in design-time environments.
TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));

var beige = (Color?)cc.ConvertFromString("Beige");
var purple = (Color?)cc.ConvertFromString("#800080");
var window = (Color?)cc.ConvertFromString("Window");

Console.WriteLine(beige);
Console.WriteLine(purple);
Console.WriteLine(window);