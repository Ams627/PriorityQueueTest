using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;


namespace PriorityQueueTest
{
    class X : IComparable<X>
    {
        public int Priorty { get; set; }
        public string Name { get; set; }

        public int CompareTo(X other)
        {
            return Priorty - other.Priorty;
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var q = new PriorityQueue<X>();
                var all = new[]
                {
                    new X { Priorty = 1, Name = "gone" },
                    new X { Priorty = 5, Name = "hello" },
                    new X { Priorty = -1, Name = "fred" },
                    new X { Priorty = 10, Name = "jim" }
                };
                foreach (var item in all)
                {
                    q.Enqueue(item);
                }

                while (q.Count != 0)
                {
                    var r = q.Dequeue();
                    Console.WriteLine($"{r.Priorty} {r.Name}");
                }
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
