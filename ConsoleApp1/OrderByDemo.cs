namespace ConsoleApp1
{
    public class OrderByDemo
    {
        //ThenBy => sort data at the second level by ascending order. 
        //ThenByDescending => sort data at the second level by descending order. 
        public void Test()
        {
            //var dataSource = new List<int>() { 3, 2, 4, 6, 1, 20, 7 };

            //var querySyntax = (from d in dataSource
            //                   where d > 5
            //                   orderby d
            //                   select d).ToList();

            //var querySyntax = from d in dataSource
            //                  where d > 5
            //                  orderby d descending
            //                  select d;

            //var methodSyntax = dataSource.
            //                   Where(num => num < 15)
            //                   .OrderBy(d => d);

            //var methodSyntax = dataSource.Where(rec => rec > 3).OrderByDescending(d => d);

            //var dataSource = new List<string>()
            //{
            //    "Rohit",
            //    "Virat",
            //    "Shreyas",
            //    "Surya",
            //    "Rishabh",
            //    "Dinesh"
            //};

            //var querySyntax = (from val in dataSource
            //                   where val.StartsWith('S') && val.EndsWith('a')
            //                   orderby val
            //                   select val).ToList();

            //var methodSyntax = dataSource.Where(val => val.Length > 5)
            //    .OrderBy(data => data).Select(val => val.ToString());

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item);
            //}

            //var dataSource = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        Id= 1,
            //        Name="Nayan",
            //        Email="n@gmail.com"
            //    },

            //    new Employee()
            //    {
            //        Id= 2,
            //        Name="Nupur",
            //        Email="nr@gmail.com"
            //    },

            //    new Employee()
            //    {
            //        Id= 3,
            //        Name="Neha",
            //        Email="nh@gmail.com"
            //    },

            //    new Employee()
            //    {
            //        Id= 4,
            //        Name="nisha",
            //        Email="nsh@gmail.com"
            //    },
            //};


            //var querySyntax = (from rec in dataSource
            //                   where rec.Email.Contains('n')
            //                   orderby rec.Name
            //                   orderby rec.Email descending
            //                   select rec).ToList();

            //var querySyntax = (from rec in dataSource
            //                   orderby rec.Name descending, rec.Email descending
            //                   select rec).ToList();

            //var methodSyntax = dataSource.Where(rec => rec.Id > 2).OrderBy(x => x.Name).ToList();

            //var methodSyntax = dataSource.
            //    Where(rec => rec.Id > 2).
            //    OrderByDescending(x => x.Name).
            //    ThenBy(x => x.Email).
            //    ToList();


            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Console.ReadLine();
        }
    }
}
