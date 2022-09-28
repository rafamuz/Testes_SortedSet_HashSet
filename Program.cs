using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_SortedSet_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> eventoDia1 = new SortedSet<int>() {
                1, 2, 3, 10, 11, 12, 13, 14, 15, 16, 17, 18, 25, 26, 27 };
            SortedSet<int> eventoDia2 = new SortedSet<int>() {
                3, 10, 11, 15, 16, 17, 18, 25, 26, 27, 28, 29, 30 };

            SortedSet<int> a = new SortedSet<int>(eventoDia1);
            a.UnionWith(eventoDia2);
            PrintCollection(a, "Todas as pessoas que foram em ao menos 1 dia de evento. (Union)");

            SortedSet<int> b = new SortedSet<int>(eventoDia1);
            b.IntersectWith(eventoDia2);
            PrintCollection(b, "Somente as pessoas que foram nos 2 dias de evento. (Instersection)");

            SortedSet<int> c = new SortedSet<int>(eventoDia1);
            c.ExceptWith(eventoDia2);
            PrintCollection(c, "Somente as pessoas que foram no evento dia 1. (Difference)");

            SortedSet<int> d = new SortedSet<int>(eventoDia2);
            d.ExceptWith(eventoDia1);
            PrintCollection(d, "Somente as pessoas que foram no evento dia 2. (Difference)");

            SortedSet<int> e = new SortedSet<int>(eventoDia1);
            e.SymmetricExceptWith(eventoDia2);
            PrintCollection(e, "Todas as pessoas que foram em somente em 1 dos 2 dias de evento.");


        }

        static void PrintCollection<T>(IEnumerable<T> collection, string msg)
        {
            Console.Write(msg + " ");
            Console.WriteLine();
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
