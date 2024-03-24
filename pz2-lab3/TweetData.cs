using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

[XmlRoot("TweetData")]
public class TweetData {
    public string Text { get; set; }
    public string UserName { get; set; }
    public string LinkToTweet { get; set; }
    public string FirstLinkUrl { get; set; }
    public string CreatedAt { get; set; }
    public string TweetEmbedCode { get; set; }

    public override string ToString() {
        return $"Tweet: {Text}\n" +
               $"User: {UserName}\n" +
               $"Link: {LinkToTweet}\n" +
               $"First Link URL: {FirstLinkUrl}\n" +
               $"Created At: {CreatedAt}\n" +
               $"Tweet Embed Code: {TweetEmbedCode}\n";
    }
}
