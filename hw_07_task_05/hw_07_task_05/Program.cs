public class Program
{
    private static List<string> DivideIntoBuckets(string sentence, int size)
    {
        List<string> result = new List<string>();

        for (int current = 0; current < sentence.Length;)
        {
            int spaceLen = sentence.Skip(current).TakeWhile(char.IsWhiteSpace).Count();
            int bucketStart = current + spaceLen;

            int bucketLen = sentence.Skip(bucketStart).TakeWhile(char.IsLetter).Count();

            if (bucketLen == 0)
                break;

            int BucketLen1 = bucketLen;
            for (int i = bucketStart + bucketLen; i < sentence.Length;)
            {
                int whitespaceLength = sentence.Skip(i).TakeWhile(char.IsWhiteSpace).Count();
                int wordLength = sentence.Skip(i + whitespaceLength).TakeWhile(char.IsLetter).Count();
                BucketLen1 += whitespaceLength + wordLength;

                if (wordLength == 0 || BucketLen1 > size)
                    break;

                bucketLen = BucketLen1;
                i += whitespaceLength + wordLength;
            }

            result.Add(sentence.Substring(bucketStart, bucketLen));
            current = bucketStart + bucketLen;
        }

        return result;
    }


    public static void Main()
    {
        Console.WriteLine(String.Join(")(", DivideIntoBuckets("она продает морские раковины у моря", 16)));
        Console.WriteLine(String.Join(")(", DivideIntoBuckets("мышь прыгнула через сыр", 8)));
        Console.WriteLine(String.Join(")(", DivideIntoBuckets("волшебная пыль покрыла воздух", 15)));
        Console.WriteLine(String.Join(")(", DivideIntoBuckets("a b c d e ", 2)));
    }
}