using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

public class Xml {

    public void saveToXml(List<TweetData> tweets, string Path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<TweetData>));

        using FileStream fileStream = new FileStream(Path, FileMode.Create);
        serializer.Serialize(fileStream, tweets);
    }

    public TwitterData MakeDataFromXml(string xmlFilePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<TweetData>));

        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            List<TweetData> tweets = (List<TweetData>)serializer.Deserialize(fileStream);
            return new TwitterData(tweets);
        }
    }

}