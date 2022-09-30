using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ConsoleApp1
{
    public class DistinctDemo
    {
        public void Test()
        {
            //List<int> list = new List<int>() { 3, 2, 5, 6, 71, 2, 4 };

            //var ms = list.Distinct().ToList();

            //var qs = (from data in list
            //          select data).Distinct().ToList();

            List<StudentD> list = new List<StudentD>()
            {
                new StudentD(){FullName="RAj verma",Semail="abc@gmail.com"},
                new StudentD(){FullName="sri verma",Semail="sri@gmail.com"},
                new StudentD(){FullName="RAj verma",Semail="abc@gmail.com"},
                new StudentD(){FullName="sii verma",Semail="sri@gmail.com"},
            };

            //var ms = list.Select(s => s.FullName).Distinct().ToList();

            //var qs = (from val in list
                      //select val.FullName).Distinct().ToList();

            var ms = list.Distinct(new StudentComparers()).ToList();

            Console.ReadLine();
        }

    }
}

class StudentD : IEquatable<StudentD>
{
    public string FullName { get; set; }
    public string Semail { get; set; }

    public bool Equals(StudentD? other)
    {
        if (object.ReferenceEquals(other, null))
        {
            return false;
        }
        if (object.ReferenceEquals(this, other))
        {
            return true;
        }

        return this.Semail.Equals(other.Semail) && this.FullName.Equals(other.FullName);
    }

    public override int GetHashCode()
    {
        int NameHashCode = FullName.GetHashCode();
        int EmailHashCode = Semail.GetHashCode();

        return NameHashCode ^ EmailHashCode;
    }
}

class StudentComparers : IEqualityComparer<StudentD>
{
    public bool Equals(StudentD? x, StudentD? y)
    {
        return x.FullName.Equals(y.FullName) && x.Semail.Equals(y.Semail);
    }

    public int GetHashCode([DisallowNull] StudentD obj)
    {
        int NameHashCode = obj.FullName.GetHashCode();
        int EmailHashCode = obj.Semail.GetHashCode();

        return NameHashCode ^ EmailHashCode;
    }
}