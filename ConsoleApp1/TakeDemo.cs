// See https://aka.ms/new-console-template for more information
public class TakeDemo
{
    public void Test()
    {
        var list = new List<int>() { 3, 4, 5, 61, 2 };
        var list2 = new List<int>() { 32, 4, 5, 21, 2 };
        List<string> names = new List<string>() { "kim", "john", "Mark", "Ada", "Nitin" };


        var ms = names.TakeWhile((name, index) => name.Length > index).ToList();

        //var ms = list.Take(2);
        //var ms = list.TakeWhile(x => x <= 4).ToList();


        //var qs = (from val in list select val).TakeWhile(x => x <= 4).ToList();

        //var student1 = new List<StudentInfo>()
        //{
        //    new StudentInfo(){ Name = "Raj",Marks=98},
        //    new StudentInfo(){ Name = "Ram",Marks=90},
        //    new StudentInfo(){ Name = "Rahul",Marks=89},
        //    new StudentInfo(){ Name = "Raman",Marks=79},
        //};

        //var student2 = new List<StudentInfo>()
        //{
        //    new StudentInfo(){ Name = "Rakesh",Marks=91},
        //    new StudentInfo(){ Name = "Ram",Marks=90},
        //    new StudentInfo(){ Name = "Reeta",Marks=94},
        //   new StudentInfo(){ Name = "Raman",Marks=79},
        //};

        //var ms = student1.Select(x => x.Name).Intersect(student2.Select(x => x.Name)).ToList();

        //var ms = student1.Select(x => new { x.Name, x.Marks }).Take(3).ToList();

        //var qs = (from val in student1 select val.Marks).Take(3).ToList();

        foreach (var item in ms)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}

//so here, the question arise that, the working of the Where() and TakeWhile() is same!!
//so why there is a TakeWhile().
//Where() checks each element in the given dataset, while TakeWhile() goes until the given condition is true.