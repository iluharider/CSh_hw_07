using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";

        string[] words = Regex.Replace(sentence, @"[^\w\s]", "").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var groups = words.GroupBy(word => word.Length)
                          .OrderByDescending(group => group.Count());

        foreach (var group in groups)
        {
            Console.WriteLine($"Длина {group.Key}. Количество {group.Count()}");
            foreach (var word in group)
            {
                Console.WriteLine(word);
            }
        }
    }
}
