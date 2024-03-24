using System.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;

public class Sorting {
    TwitterData twitterData { get; set; }

    public Sorting(TwitterData twitterData) {
        this.twitterData = twitterData;
    }

    public void sortByUsername() {
        twitterData.Data = twitterData.Data.OrderBy(TweetData => TweetData.UserName).ToList();
    }

    public void sortByDate() {
        const string dateFormat = "MMMM dd, yyyy 'at' hh:mmtt";
        
        twitterData.Data = twitterData.Data
            .OrderBy(tweet => DateTime.ParseExact(tweet.CreatedAt, dateFormat, CultureInfo.InvariantCulture))
            .ToList();
    }
}