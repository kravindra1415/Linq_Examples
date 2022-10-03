// See https://aka.ms/new-console-template for more information
public class ElementAtDemo
{
    public void Test()
    {
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> strings = new List<string>() { "a", "v", "m", "c" };

        //var ms = ints.ElementAtOrDefault(100); => returns 0 
        //var ms = ints.ElementAt(100); => throws an exception index out of range
        //and also if we give the negative index like -1 then, also throws the same exception.

        var ms = ints.Where(x => x > 3).ElementAtOrDefault(4);
        var vals = strings.ElementAtOrDefault(5);

        var mixedSyntax = (from num in ints
                           select num).ElementAtOrDefault(3);

        Console.WriteLine(ms);

        Console.ReadLine();

    }
}