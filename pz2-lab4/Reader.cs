public class Reader<T> {
    public List<T> Generate (String path, Func<String[], T> Constructor) {
        using var reader = new StreamReader(path);
        List<T> ObjectList = new();
        var headers = reader.ReadLine();

        while (!reader.EndOfStream) {
            var line = reader.ReadLine();

            if(line == null) {
                throw new ArgumentNullException(nameof(line), "Parameter cannot be null");
            }

            if(line.Length != 0) {

                var values = line.Split(',');

                var NewObject = Constructor(values);

                ObjectList.Add(NewObject);
            }
        }
        return ObjectList;
    }
}