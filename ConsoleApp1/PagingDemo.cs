public static class PagingDemo
{
    public static void Test()
    {
        int totalPagePerView = 4;

        do
        {
            Console.WriteLine("Enter your page number!!");

            if (int.TryParse(Console.ReadLine(), out int pageNumber))
            {
                var ms = GetEmployees().Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView).ToList();

                foreach (var item in ms)
                {
                    Console.WriteLine($"ID = {item.Id} and Name ={item.Name}");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid Page Number");
            }
        } while (true);
    }
    public static List<Emp> GetEmployees()
    {
        return new List<Emp>()
        {
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
            new Emp(){Id=1,Name="Ram"},
        };
    }
}

public class Emp
{
    public int Id { get; set; }
    public string? Name { get; set; }
}