using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.Controllers
{
    public delegate void Notify();
    public delegate void Handler(string message);
    public class LINQControllercs : Controller
    {
        public event Notify OnNotify;
        class detail
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public IActionResult Index()
        {
            LINQ();
            

            return View();
        }
        public static void Mess(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string LINQ()
        {
            List <int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10 };

            List<detail> details = new List<detail>
            {
                new detail { Name = "Aksh", Age = 22 },
                new detail { Name = "Maya", Age = 18 },
                new detail { Name = "John", Age = 24 },
                new detail { Name = "Ravi", Age = 19 },
                new detail { Name = "Emily", Age = 21 }
            };

            var where = details.Where(m => m.Age > 20).ToList();

            var select = details.Select(m => m.Name).ToList();

            var sort = details.OrderByDescending(m => m.Age).ToList();

            var even = list.Where(n=>n % 2 == 0).ToList();

            Handler handler = new Handler(Mess);
            handler("heyy");



            return "Learnt";
        }
    }
}
