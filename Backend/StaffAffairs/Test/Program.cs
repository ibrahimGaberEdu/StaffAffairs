using DataLayer.DBContext;
using DataLayer.Models;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StuffAppAppttContext context = new StuffAppAppttContext();
            Service<Dept> depts = new Service<Dept>(context);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach (var item in depts.Query().ToList())
            {
                Console.WriteLine(item.DeptName.Reverse().ToArray());
            }

        }
    }
}
