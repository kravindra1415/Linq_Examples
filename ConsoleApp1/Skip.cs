namespace ConsoleApp1
{
    public class SkipDemo
    {
        public void Test()
        {
            var list = new List<int>() { 3, 4, 5, 61, 2 };
            var list2 = new List<int>() { 32, 4, 5, 21, 2 };
            List<string> names = new() { "kim", "kohn", "Mark", "Ada", "Nitin" };

            //var qs = (from num in list
            //select num).Where(num => num >= 2).Skip(2).ToList();

            //var ms = names.Skip(2).ToList();

            //var qs = list.SkipWhile(x => x > 2).ToList();

            //var ms = (from val in list
            //select val).SkipWhile(val => val < 5).ToList();

            var ms1 = names.SkipWhile(val => val.StartsWith('k') && val.Length < 4).ToList();

            var ms2 = names.SkipWhile((value, index) => value.Length < index).ToList();

            Console.ReadLine();
        }
    }
}
