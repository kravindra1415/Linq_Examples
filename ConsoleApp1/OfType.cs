namespace ConsoleApp1
{
    public class OfType
    {
        //Oftype returns the value types. ex. object string, int
        public void Test()
        {
            var dataSource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 3, 25, 4 };


            //var methodSyntax = dataSource.OfType<int>().ToList();

            var querySyntax = (from x in dataSource
                               where x is string
                               select x).ToList();

            Console.ReadLine();
        }
    }
}
