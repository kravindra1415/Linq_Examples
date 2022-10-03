// See https://aka.ms/new-console-template for more information
public class LeftJoin
{
    public void Test()
    {
        var address = new List<AddressLeft>()
        {
            new AddressLeft(){Id=1,AddressLine="one"},
            new AddressLeft(){Id=2,AddressLine="two"},
            new AddressLeft(){Id=3,AddressLine="three"},
            new AddressLeft(){Id=4,AddressLine="four"},
        };

        var students = new List<StudentLeft>()
        {
            new StudentLeft(){Id=1,Name="A",AddressId=1},
            new StudentLeft(){Id=2,Name="AA",AddressId=2},
            new StudentLeft(){Id=3,Name="AB"},
            new StudentLeft(){Id=4,Name="AC", AddressId = 4},
            new StudentLeft(){Id=5,Name="AD", AddressId = 5}
        };

        var qs = (from std in students
                  join addr in address
                  on std.AddressId equals addr.Id
                  into studAddress
                  from studentAddress in studAddress.DefaultIfEmpty()
                  select new { StudentName = std.Name, studentAddress = studentAddress != null ? studentAddress.AddressLine : "NA" }).ToList();

        var ms = students.GroupJoin(address, std => std.AddressId, addr => addr.Id,
            (std, addr) => new { std, addr }
            ).SelectMany(m => m.addr.DefaultIfEmpty(),
            (studentData, addressData) => new
            {
                studentData.std,
                addressData
            }
            ).ToList();


        foreach (var student in qs)
        {
            Console.WriteLine(student);
        }

        //var query = (from s in students
        //             select s).Reverse();

        //foreach(var student in query)
        //{
        //    Console.WriteLine(student.Name);
        //}


        Console.ReadLine();

    }

    //public void Demo()
    //{
    //    var students = new List<StudentLeft>()
    //    {
    //        new StudentLeft(){Id=1,Name="A",AddressId=1},
    //        new StudentLeft(){Id=2,Name="AA",AddressId=2},
    //        new StudentLeft(){Id=3,Name="AB"},
    //        new StudentLeft(){Id=4,Name="AC", AddressId = 4},
    //        new StudentLeft(){Id=5,Name="AD", AddressId = 5}
    //    };

    //    var query = (from s in students
    //                 select s).Reverse();

    //    Console.WriteLine(query);

    //}
}

class StudentLeft
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AddressId { get; set; }
}

class AddressLeft
{
    public int Id { get; set; }
    public string AddressLine { get; set; }
}