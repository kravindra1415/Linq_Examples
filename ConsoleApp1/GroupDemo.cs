namespace ConsoleApp1
{
    public class GroupDemo
    {
        public void Test()
        {
            var students = new List<StudentGroup>()
            {
                new StudentGroup(){Id=1,Name="john",CategoryId=1},
                new StudentGroup(){Id=2,Name="jason",CategoryId=1},
                new StudentGroup(){Id=3,Name="jis",CategoryId=2},
                new StudentGroup(){Id=4,Name="jonny",CategoryId=2},
                new StudentGroup(){Id=5,Name="joseph",CategoryId=3},
            };

            var categories = new List<Category>()
            {
                new Category(){Id=1,Name="Monitor"},
                new Category(){Id=2,Name="Dis"},
                new Category(){Id=3,Name="Nothing"},

            };

            var ms = categories.GroupJoin(students, cat => cat.Id, stud => stud.CategoryId,
                (cat, stud) => new { cat, stud }
                );

            var qs = from c in categories
                     join std in students
                     on c.Id equals std.CategoryId
                     into stdGrp
                     select new { c, stdGrp };

            //foreach (var category in qs)
            //{
            //    Console.WriteLine(category.cat.Name + "==>");

            //    foreach (var category2 in category.stud)
            //    {
            //        Console.WriteLine(category2.Name);
            //    }
            //}

            foreach (var item in qs)
            {
                Console.WriteLine(item.c.Name+"==>");

                foreach(var c in item.stdGrp)
                {
                    Console.WriteLine(c.Name);
                }
            }
        }
    }

    public class StudentGroup
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
