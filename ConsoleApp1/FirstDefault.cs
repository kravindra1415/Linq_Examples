// See https://aka.ms/new-console-template for more information
public class FirstDefault
{
    public void Test()
    {
        List<int> list = new List<int>() { 11, 22, 33, 44, 55, 66, 77 };

        //var ms = list.Where(x=>x>33).First();
        //var ms = list.First(x => x > 500); => gives error as sequence contains no matching elements.
        //var ms = list.First(x => x > 5);
        //performance wise it's recommended to use..

        //var ms1 = list.FirstOrDefault(x => x > 500);

        var users = new List<User>()
        {
            new User() { Name = "abc",Password="abc"},
            new User() { Name = "raj",Password="root"},
            new User() { Name = "john",Password="admin"},
            new User() { Name = "pawan",Password="welcome1"},
        };

        //var ms = users.First(x => x.Name == "abc" && x.Password == "abc");
        //var ms = users.FirstOrDefault(x => x.Name == "abc" && x.Password == "abc");

        //var mixedS = (from u in users
        //           select u).FirstOrDefault(x => x.Name == "pawan" || x.Password == "admin");


        //var ms = users.Last();
        //var ms = users.LastOrDefault(u => u.Password?.Length > 3);

        //var ms1 = (from u in users
        //select u).LastOrDefault(u => u.Password?.Length > 3);

        var ms = list.Single(x => x > 70);

        Console.WriteLine(ms);

        Console.ReadLine();
    }
}

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
}