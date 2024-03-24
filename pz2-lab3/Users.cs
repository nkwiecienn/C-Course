public class Users {

    Dictionary<String, List<TweetData>> UserDict = new Dictionary<string, List<TweetData>>();

    public Users (List<TweetData> data) {
        foreach(TweetData t in data) {
            if(UserDict.ContainsKey(t.UserName))
                UserDict[t.UserName].Add(t);
            else {
                List<TweetData> list = new List<TweetData>();
                UserDict.Add(t.UserName, list);
                UserDict[t.UserName].Add(t);
            }
        }
    }
}