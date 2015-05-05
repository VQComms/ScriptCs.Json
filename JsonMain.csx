using ServiceStack.Text;

public T Deserialize<T>(string json)where T: new()
{
    return JsonSerializer.DeserializeFromString<T>(json);
}

public T DeserializeFromFile<T>(string fileName)where T: new()
{
    using (TextReader reader = File.OpenText(@fileName))
    {
        var data = JsonSerializer.DeserializeFromReader<T>(reader);
        return data;
    }
}