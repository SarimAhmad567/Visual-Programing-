using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // Create XML Writer Settings
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true; // Make the XML readable with indentation
        settings.IndentChars = "\t"; // Use tab for indentation

        // Create the XmlWriter with the specified settings
        using (XmlWriter w = XmlWriter.Create("GPS.xml", settings))
        {
            // Write the XML declaration
            w.WriteStartDocument();

            // Start the root element GPS_Log
            w.WriteStartElement("GPS_Log");

            // Start Position element with DateTime attribute
            w.WriteStartElement("Position");
            w.WriteAttributeString("DateTime", "1/26/2017 5:08:59 PM");

            // Add x and y elements
            w.WriteElementString("x", "65.8973342");
            w.WriteElementString("y", "72.3452346");

            // Start SatteliteInfo element
            w.WriteStartElement("SatteliteInfo");
            w.WriteElementString("Speed", "40");
            w.WriteElementString("NoSatt", "7");
            w.WriteEndElement(); // End of SatteliteInfo

            // End Position element
            w.WriteEndElement(); // End of Position

            // Start Image element with Resolution attribute
            w.WriteStartElement("Image");
            w.WriteAttributeString("Resolution", "1024x800");

            // Add Path element
            w.WriteElementString("Path", @"\images\1.jpg");

            // End Image element
            w.WriteEndElement(); // End of Image

            // End the root element GPS_Log
            w.WriteEndElement(); // End of GPS_Log

            // End the XML document
            w.WriteEndDocument();
        }

        Console.WriteLine("XML file 'GPS.xml' created successfully.");
    }
}
