// See https://aka.ms/new-console-template for more information
public class UnionDemo
{
    public void Test()
    {
        //var list = new List<int>() { 3, 4, 5, 61, 2 };
        //var list2 = new List<int>() { 32, 4, 5, 21, 2 };

        //var ms = list.Union(list2).ToList();

        //var qs = (from val in list select val).Union(from v in list2 select v).ToList();

        var student1 = new List<StudentInfo>()
        {
            new StudentInfo(){ Name = "Raj",Marks=98},
            new StudentInfo(){ Name = "Ram",Marks=90},
            new StudentInfo(){ Name = "Rahul",Marks=89},
            new StudentInfo(){ Name = "Raman",Marks=79},
        };

        var student2 = new List<StudentInfo>()
        {
            new StudentInfo(){ Name = "Rakesh",Marks=91},
            new StudentInfo(){ Name = "Ram",Marks=90},
            new StudentInfo(){ Name = "Reeta",Marks=94},
           new StudentInfo(){ Name = "Raman",Marks=79},
        };

        //var ms = student1.Select(x => x.Name).Intersect(student2.Select(x => x.Name)).ToList();

        var ms = student1.Select(x => new { x.Name, x.Marks }).Union(student2.Select(x => new { x.Name, x.Marks })).ToList();

        var qs = (from val in student1 select val.Marks).Union(from val in student2 select val.Marks).ToList();

        foreach (var item in ms)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}