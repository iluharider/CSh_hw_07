class CustomObject
{
    public String Name { get; set; }
}

class Task2
{

    static List<CustomObject> LenGreaterIndex(IEnumerable<CustomObject> objs)
    {
        return objs
            .Where((obj, idx) => obj.Name.Length > idx)
            .ToList();
    }

    static void Main()
    {
        var obj1 = new CustomObject() { Name = "A" };
        var obj2 = new CustomObject() { Name = "B" };
        var obj3 = new CustomObject() { Name = "CCCC" };
        var obj4 = new CustomObject() { Name = "DDD" };
        var objs = new List<CustomObject>() { obj1, obj2, obj3, obj4 };
        foreach (var obj in LenGreaterIndex(objs))
        {
            Console.WriteLine(obj.Name);
        }
    }
}