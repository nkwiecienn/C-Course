public class CountWords {
    public Dictionary<string, int> CalculateWords(List<TweetData> tweets)
    {
        var wordFrequencies = new Dictionary<string, int>();

        foreach (var tweet in tweets)
        {
            string[] words = tweet.Text.ToLower().Split(new[] { ' ', ',', '.', '!', '?', '"', ';', ':', '(', ')', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordFrequencies.ContainsKey(word)) {
                    wordFrequencies[word]++;
                } else {
                    wordFrequencies.Add(word, 1);
                }
            }
        }

        return wordFrequencies;
    }

    public List<String> Top10(Dictionary<string, int> WordsDict) {
        List<KeyValuePair<string, int>> topWords = WordsDict.OrderByDescending(pair => pair.Value)
                                                                     .ThenBy(pair => pair.Key) 
                                                                     .Take(10)
                                                                     .ToList();

        List<string> topList = new List<string>();

        foreach(KeyValuePair<string, int> k in topWords) {
            topList.Add(k.Key);
        }

        return topList;
    }
}