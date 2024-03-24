public class Program {
public static void Main()
    {
        string jsonFilePath = "C:\\Users\\natal\\VS Projects\\pz2-lab3\\data.json";
        ReadJson readJson = new ReadJson(jsonFilePath);
        TwitterData twitterData = readJson.makeDataFromJson();

        Xml xml = new Xml();
        xml.saveToXml(twitterData.Data, "C:\\Users\\natal\\VS Projects\\pz2-lab3\\data_xml.xml");

        TwitterData twitterFromXml = xml.MakeDataFromXml("C:\\Users\\natal\\VS Projects\\pz2-lab3\\data_xml.xml");

        Sorting sorting = new Sorting(twitterData);
            Console.WriteLine("Before sorting by username:");

        for(int i = 0; i < 20; i++) {
            Console.WriteLine(twitterData.Data[i].UserName);
        }

        sorting.sortByDate();

        Console.WriteLine("After sorting by username:");

        for(int i = 0; i < 20; i++) {
            Console.WriteLine(twitterData.Data[i].UserName);
        }

        Console.WriteLine("Before sorting by date:");

        for(int i = 0; i < 20; i++) {
            Console.WriteLine(twitterData.Data[i].CreatedAt);
        }

        sorting.sortByDate();

        Console.WriteLine("After sorting by date:");

        for(int i = 0; i < 20; i++) {
            Console.WriteLine(twitterData.Data[i].CreatedAt);
        }

        Console.WriteLine("First tweet by date: " + '\n' + twitterData.Data[0].ToString() + '\n');

        Console.WriteLine("Last tweet by date: " + '\n' + twitterData.Data[^1].ToString() + '\n');

        Users users = new Users(twitterData.Data);

        CountWords countWords = new CountWords();
        var wordsDict = countWords.CalculateWords(twitterData.Data);
        
    }
}