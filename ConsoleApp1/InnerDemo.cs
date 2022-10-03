// See https://aka.ms/new-console-template for more information
class InnerDemo
{
    public void Test()
    {
        var students = new List<StudentJoin>()
        {
            new StudentJoin(){StudentId=1,FullName="A",Semail="abc@gmail.com",AddressId=1},
            new StudentJoin(){StudentId=2,FullName="AA",Semail="aa@gmail.com",AddressId=2},
            new StudentJoin(){StudentId=3,FullName="AB",Semail="ab@gmail.com", AddressId = 0},
            new StudentJoin(){StudentId=4,FullName="AC",Semail="ac@gmail.com", AddressId = 4}
        };

        var address = new List<Address>()
        {
            new Address(){Id=1,Line="one"},
            new Address(){Id=2,Line="two"},
            new Address(){Id=3,Line="three"},
            new Address(){Id=4,Line="four"},
        };

        var marks = new List<Mark>()
        {
            new Mark(){Id=1,studentId=1,TMarks=70},
            new Mark(){Id=2,studentId=2,TMarks=90},
            new Mark(){Id=3,studentId=3,TMarks=80},
            new Mark(){Id=4,studentId=4,TMarks=80},
        };

        var qs = (from s in students
                  join a in address
                  on s.AddressId equals a.Id
                  join m in marks
                  on s.StudentId equals m.studentId
                  select new
                  {
                      Id = a.Id,
                      Line = a.Line,
                      FullName = s.FullName,
                      Semail = s.Semail,
                      Marks = m.TMarks

                  }).ToList();


        //

        var ms = students.Join(address, std => std.AddressId,
            addr => addr.Id,
            (std, addr) => new
            {
                std,
                addr
            }).Join(marks, student => student.std.StudentId, mark => mark.studentId,
            (student, mark) => new { student, mark })

            .Select(x => new
            {
                FullName = x.student.std.FullName,
                AddressId = x.student.std.AddressId,
                Line = x.student.addr.Line,
                Marks=x.mark.TMarks
            }).
           ToList();

        //students=outer data source
        //address=inner data source
        //then the matching properties of both the data source,
        //after that both the keys
        //and select the data that u want to from both data source.

        foreach (var i in ms)
        {
            Console.WriteLine(i);
        }
    }
}

class Address
{
    public int Id { get; set; }
    public string Line { get; set; } = null!;

}

class StudentJoin
{
    //StudentId=1,FullName="A",Semail="abc@gmail.com"
    public int StudentId { get; set; }
    public string FullName { get; set; }
    public string Semail { get; set; }
    public int AddressId { get; set; }
}

class Mark
{
    public int Id { get; set; }
    public int studentId { get; set; }
    public int TMarks { get; set; }
}