class Program
{
    static Dictionary<String, String> EngToRusDictionary = new Dictionary<String, String>()
    {
        {"this","эта"},
        {"dog","собака"},
        {"eats","ест"},
        {"too","слишком"},
        {"much","много"},
        {"vegetables","овощей"},
        {"after","после"},
        {"lunch","обеда"}
    };

    static void CreateTranslatedBook(String str, int n)
    {
        foreach (
            var chunk in str.Split()
            .Select(word => EngToRusDictionary[word.ToLower()]
            .ToUpper()).Chunk(n)
            )
        {
            foreach (var word in chunk)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

        }
    }
    static void Main()
    {
        CreateTranslatedBook("This dog eats too much vegetables after lunch", 3);
    }
}