class Object
{
    public String Name { get; set; }
}

class Program
{
    static string ConcatSkip3(IEnumerable<Object> objs, char delimiter)
    {
        var namesAfterSkip3 = objs.Skip(3).Sjelect(p => p.Name + delimiter);
        var concatenatedString = string.Concat(namesAfterSkip3);
        return concatenatedString.Substring(0, concatenatedString.Length - 1);
    }


    static void Main()
    {
        var obj1 = new Object() { Name = "A" };
        var obj2 = new Object() { Name = "B" };
        var obj3 = new Object() { Name = "C" };
        var obj4 = new Object() { Name = "D" };
        var obj5 = new Object() { Name = "E" };
        var objs = new List<Object>() { obj1, obj2, obj3, obj4, obj5 };
        Console.WriteLine(ConcatSkip3(objs, '-'));
    }
}