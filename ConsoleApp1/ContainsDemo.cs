using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    public class ContainsDemo
    {
        public void Test()
        {
            //var listData = new List<string>() { "rahul", "rohit", "raj", "ram" };

            //var querySyntax = listData.Contains("ram");

            //var methodSyntax = (from data in listData
            //                    select data).Contains("rahul");


            List<Student> list = new List<Student>()
            {
                new Student(){FullName="RAj verma",Semail="abc@gmail.com"},
                new Student(){FullName="sri verma",Semail="sri@gmail.com"},
            };

            //var isExist = list.Contains(new Student() { FullName = "RAj verma", Semail = "abc@gmail.com" });
            //it returns false, beacuse of references are different of both the objects.

            //if we do like this, then it returns true.
            //var student = new Student() { FullName = "RAj verma", Semail = "abc@gmail.com" };


            //using comparer class
            var comparer = new StudentComparer();
            var isExist = list.Contains(new Student() { FullName = "RAj verma", Semail = "abc@gmail.com" }, comparer);


            var querySyntax = (from std in list
                               select std).Contains(new Student() { FullName = "RAj verma", Semail = "abc@gmail.com" }, comparer);

            //list.Add(student);
            //var isExist = list.Contains(student);
            //returns true


            //now if we want to work with differences, but the value is same, the how we can use the contains() method for that?
            //for the we have to work  with the comparer.

            Console.ReadLine();
        }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            if (object.ReferenceEquals(x, null) || (object.ReferenceEquals(null, y)))
            {
                return false;
            }

            return x.StudentId == y.StudentId && x.FullName == y.FullName && x.Semail == y.Semail;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHashCode = obj.StudentId.GetHashCode();
            int nameHashCode = obj.FullName == null ? 0 : obj.FullName.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
