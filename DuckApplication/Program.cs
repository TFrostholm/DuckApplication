using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DuckApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = Duck.KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = Duck.KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = Duck.KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = Duck.KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = Duck.KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = Duck.KindOfDuck.Decoy, Size = 13 },
            };

            Console.WriteLine("Ducks without any sorting:");
            PrintDucks(ducks);

            Console.WriteLine("");
            Console.WriteLine("Ducks sorted by size:");
            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);

            Console.WriteLine("");
            Console.WriteLine("Ducks sorted by kind:");
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            Console.WriteLine("");
            Console.WriteLine("Ducks sorted by kind then size:");
            DuckComparer comparer = new DuckComparer();
            comparer.SortBy = Duck.SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("");
            Console.WriteLine("Ducks sorted by size then kind:");
            comparer.SortBy = Duck.SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);


            Console.ReadKey();



        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            }
            Console.WriteLine("End of ducks!");
        }
    }
}
