//The other common scenario is to rethrow a more specific exception type:

using System.Xml;

DateTime dt;
string dtString = "2010-4-31";  // Assume we're writing an XML parser and this is from an XML file
try
{
    // Parse a date of birth from XML element data
    dt = XmlConvert.ToDateTime (dtString, XmlDateTimeSerializationMode.Utc);
}
catch (FormatException ex)
{
    throw new XmlException ("Invalid DateTime", ex);
}