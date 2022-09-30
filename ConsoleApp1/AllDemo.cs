namespace ConsoleApp1
{
    public class AllDemo
    {
        //All() method requires all the consitions true.
        public void Test()
        {
            //StudentInfo[] students = { new StudentInfo { Name = "John", Marks = 85 }, new StudentInfo { Name = "smith", Marks = 96 } };

            //var methodSyntax = students.All(x => x.Marks > 80);
            //it returns true

            //var querySyntax = (from student in students
            //                   select student).All(st => st.Name.Contains('h'));
            //it returns true

            //StudentInfo[] students = {
            //    new StudentInfo { Name = "John", Marks = 85, Subjects = new List<Subject>() {
            //    new Subject() { SubjectName = "C", SubjectMarks = 76 } ,
            //    new Subject() { SubjectName = "CPP", SubjectMarks = 69 } ,
            //    new Subject() { SubjectName = "Java", SubjectMarks = 76 }
            //    } },
            //    new StudentInfo { Name = "smith", Marks = 96 , Subjects = new List<Subject>() {
            //    new Subject() { SubjectName = "C", SubjectMarks = 86 } ,
            //    new Subject() { SubjectName = "CPP", SubjectMarks = 90 } ,
            //    new Subject() { SubjectName = "Java", SubjectMarks = 75 }
            //    } },
            //    new StudentInfo { Name = "Lee", Marks = 90 , Subjects = new List<Subject>() {
            //    new Subject() { SubjectName = "C", SubjectMarks = 68 } ,
            //    new Subject() { SubjectName = "CPP", SubjectMarks = 65 } ,
            //    new Subject() { SubjectName = "Java", SubjectMarks = 75 }
            //    } },

            //};

            //var studentDemo = students.Where(std => std.Subjects.All(x => x.SubjectMarks > 70)).Select(s => s).ToList();

            //var queryStudent = (from s in students
            //                   where s.Subjects.All(s => s.SubjectMarks > 68)
            //                   select s).ToList();

            //foreach (var student in queryStudent)
            //{
            //    Console.WriteLine(student.Name + " | " + student.Marks);
            //}

            Console.ReadLine();
        }
    }
}
