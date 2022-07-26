using System.Xml;

// XmlConvert honors XML formatting rules:
string s = XmlConvert.ToString (true);
Console.WriteLine(s);									// true (rather than True)
var b = XmlConvert.ToBoolean(s);
Console.WriteLine(b);

DateTime dt = DateTime.Now;
Console.WriteLine($"local: {XmlConvert.ToString (dt, XmlDateTimeSerializationMode.Local)}");
Console.WriteLine($"Utc: {XmlConvert.ToString (dt, XmlDateTimeSerializationMode.Utc)}");
Console.WriteLine($"RoundtripKind: {XmlConvert.ToString (dt, XmlDateTimeSerializationMode.RoundtripKind)}");

Console.WriteLine($"DateTimeOffset: {XmlConvert.ToString (DateTimeOffset.Now)}");