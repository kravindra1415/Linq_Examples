// See https://aka.ms/new-console-template for more information
public class ExceptDemo
{
    public void Test()
    {
        //var list = new List<int>() { 12, 43, 23, 54, 67 };
        //var listSecond = new List<int>() { 5, 46, 23, 67 };

        //var ms = list.Except(listSecond).ToList();

        //var qs = (from val in ms select val).Except(listSecond).ToList();

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

        var ms = student1.Select(x => x.Name).Except(student2.Select(x => x.Name)).ToList();

        var qs = (from val in student1
                  select val.Marks).Except(from val in student2
                                           select val.Marks).ToList();

        foreach (var item in qs)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}