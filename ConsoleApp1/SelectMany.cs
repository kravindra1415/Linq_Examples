namespace ConsoleApp1
{
    /// <summary>
    /// Get Records using SelectMany..
    /// </summary>
    public class SelectMany
    {
        //SelectMany is used to project each element of a sequence to an IEnumerable<T> and flattens the resulting sequence
        //into one sequence
        //in other words, SelectMany combines records from a sequence of a result and covert into one result.

        //Select and SelectMany comes under the Projection category.
        public void Test()
        {
            //List<string> list = new() { "kumar", "verma" };

            //var methodResult = list.SelectMany(x => x).ToList();
            //selectMany returns the single characters in a group.
            // e.g. in kumar, it returns as [0] => 107 'k' where 107 is a ascii value of k.


            //There is no 'SelectMany()' method available in QuerySyntax.
            //var queryResult = (from stringValue in list
            //                  from charValue in stringValue
            //                  select charValue).ToList();

            //foreach (var result in queryResult)
            //{
            //    Console.Write(result + " ");
            //}

            //Using object of other class

            //var dataSource = new List<Employee>() {
            //new Employee(){Id=1, Name="Tom",Email="tom@gmail.com",Programming=new List<string>(){ "C#","java","CPP"} },
            //new Employee(){Id=2, Name="sam",Email="sam@gmail.com",Programming=new List<string>(){ "CPP","php","DSA"}},
            //new Employee(){Id=3, Name="david",Email="david@gmail.com",Programming=new List<string>(){ "C#","java","Python"}},
            //new Employee(){Id=4, Name="ross",Email="ross@gmail.com",Programming=new List<string>(){ "CPP","dbms","R"}},
            //new Employee(){Id=5, Name="kane",Email="kane@gmail.com",Programming=new List<string>(){ "C#","html","Go"}},
            //};

            ////var methodResult = dataSource.SelectMany(x => x.Id.ToString()).ToList();

            //var queryResult = (from emp in dataSource
            //                   from rec in emp.Email.ToString()
            //                   select rec).ToList();

            //foreach (var result in queryResult)
            //{
            //    Console.Write(result + " ");
            //}



            //
            //var dataSource = new List<Employee>() {
            //    new Employee(){Id=1, Name="Tom",Email="tom@gmail.com",
            //    Programming=new List<Tech>(){
            //    new Tech() { Technology="C#" },
            //    new Tech() { Technology = "C" } } },

            //    new Employee(){Id=2, Name="sam",Email="sam@gmail.com", Programming=new List<Tech>(){
            //    new Tech() { Technology="R" },
            //    new Tech() { Technology = "Go" } }},

            //    new Employee(){Id=3, Name="david",Email="david@gmail.com", Programming=new List<Tech>(){
            //    new Tech() { Technology="JS" },
            //    new Tech() { Technology = "TS" } }},

            //    new Employee(){Id=4, Name="ross",Email="ross@gmail.com", Programming=new List<Tech>(){ } },
            //    new Employee(){Id=5, Name="kane",Email="kane@gmail.com", Programming=new List<Tech>(){
            //    new Tech(){ Technology = "TS" } ,
            //    new Tech() }},
            //};

            //var methodResult = dataSource.SelectMany(emp => emp.Programming).ToList();

            //var queryResult = (from emp in dataSource
            //                   from rec in emp.Programming
            //                   select rec).ToList();

            //foreach(var result in queryResult)
            //{
            //    Console.WriteLine(result.Technology);
            //}

            //Console.ReadLine();
        }
    }
}
