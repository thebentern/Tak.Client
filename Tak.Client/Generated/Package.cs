
using System.Xml.Serialization;

namespace TheBentern.Tak.Client.Generated;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
[XmlRoot(ElementName = "entry")]
public class Entry
{

    [XmlAttribute(AttributeName = "key")]
    public string Key { get; set; }

    [XmlAttribute(AttributeName = "class")]
    public string Class { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "preference")]
public class Preference
{

    [XmlElement(ElementName = "entry")]
    public List<Entry> Entry { get; set; }

    [XmlAttribute(AttributeName = "version")]
    public int Version { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "preferences")]
public class Preferences
{

    [XmlElement(ElementName = "preference")]
    public List<Preference> Preference { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
