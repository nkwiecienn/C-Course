using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ReadJson {
    string Path;

    public ReadJson(string Path) {
        this.Path = Path;
    }

    public TwitterData makeDataFromJson() {
        string jsonString = File.ReadAllText(Path);

        var options = new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
            AllowTrailingCommas = true,
            ReadCommentHandling = JsonCommentHandling.Skip
        };

        var twitterData = JsonSerializer.Deserialize<TwitterData>(jsonString, options);

        return twitterData;
    }
}