namespace ConsoleApp1
{
    public class ReverseDemo
    {
        public void Test()
        {
            var dataSourceList = new List<int>() { 1, 24, 5, 6, 3, 53, 9 };
            int[] dataSource = new int[] { 1, 24, 5, 6, 3, 53, 9 };


            //var methodSyntax = dataSource.Reverse();
            //This Reverse Method is from System.Linq namespace

            //var querySyntax = (from val in dataSource
            //                   select val).Reverse();

            dataSourceList.Reverse();
            //This Reverse method is from System.Collections.Generic namespace.
            //it takes the List for this method is to performed.

            //var reveresedIQueryable = dataSourceList.AsQueryable().Reverse();
            var reveresedIEnumerable = dataSourceList.AsEnumerable().Reverse();

            foreach (int i in reveresedIEnumerable)
            {
                Console.WriteLine(i);
            }

        }
    }
}
