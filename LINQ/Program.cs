using System;
using System.Collections.Generic; //<-- voor gebruik te maken van een list 
using System.Linq;  // <-- voor linq 


/*// opgaven oefeningen
 * a. Druk al de woorden af in de array, tekst, die langer zijn dan tien karakters.
 * b. Bereken het gemiddelde voor de getallen in de list driehoek die groter zijn dan 100.
 * c. Druk al de unieke getallen af uit de List, driehoek.
 * d. Druk alle unieke getallen af uit de List, driehoek, die deelbaar zijn door 
 * drie of vijf. De getallen worden in een oplopende volgorde afgedrukt.
 * e. Druk de woorden uit de array, tekst, af in een aflopende volgorde op
 * basis van lengte. Verder zijn woorden met dezelfde lengte gesorteerd 
 * op een oplopende alfabetische volgorde.
 * f. Maak een groep op basis van de startletter van ieder woord voor al de woorden in de array, tekst.
 * g. Vind alle paren van getallen en woorden waar de lengte van het woord
 * uit de array, tekst, gelijk is aan een getal uit de List, driehoek. Druk het
 * alle gevonden paren af.
 * h. Maak een uitbreiding op de vorige oefening die er voor zorgt dat elk
 * woord slechts één maal voorkomt in de resulterende paren.
 * i. Druk alle woorden af uit de array, tekst, die minstens drie klinkers bevatten.
 * 
 
 
 */


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

           // *a.Druk al de woorden af in de array, tekst, die langer zijn dan tien karakters.
             SortLinq_a();

           // *b.Bereken het gemiddelde voor de getallen in de list driehoek die groter zijn dan 100.
             SortLinq_b();

           // *c.Druk al de unieke getallen af uit de List, driehoek.
             SortLinq_c();

           // *d.Druk alle unieke getallen af uit de List, driehoek, die deelbaar zijn door drie of vijf. De getallen worden in een oplopende volgorde afgedrukt.
             SortLinq_d();

            //*e.Druk de woorden uit de array, tekst, af in een aflopende volgorde op basis van lengte. Verder zijn woorden met dezelfde lengte gesorteerd op een oplopende alfabetische volgorde.
            SortLinq_e();

            //*f.Maak een groep op basis van de startletter van ieder woord voor al de woorden in de array, tekst.
            SortLinq_f();

            //*g.Vind alle paren van getallen en woorden waar de lengte van het woord uit de array, tekst, gelijk is aan een getal uit de List, driehoek. Druk het alle gevonden paren af.
            SortLinq_g();

            //h.Maak een uitbreiding op de vorige oefening die er voor zorgt dat elk woord slechts één maal voorkomt in de resulterende paren.
            SortLinq_h();

            //i.Druk alle woorden af uit de array, tekst, die minstens drie klinkers bevatten.
            SortLinq_i();
    

        }

        //*a.Druk al de woorden af in de array 'tekst'  die langer zijn dan tien karakters.
        public static void SortLinq_a()
        {
            // manier 1 query syntax
            var querySyntax = from woord in LinqData.tekst where woord.Length > 10 select woord;
            foreach (string woord in querySyntax)
            {
                Console.WriteLine(woord);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            var methodSyntax = LinqData.tekst.Where(x2 => x2.Length > 10);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //* b.Bereken het gemiddelde voor de getallen in de list driehoek die groter zijn dan 100.
        public static void SortLinq_b()
        {
            // manier 1 query syntax
            var querySyntax = (from x in LinqData.driehoek where x > 100 select x).Average();
            Console.WriteLine(querySyntax);
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
            // manier 2 Method syntax
            var methodSyntax = LinqData.driehoek.Where(d => d > 100).Average();
            Console.WriteLine(methodSyntax);
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //* c.Druk al de unieke getallen af uit de List, driehoek.
        public static void SortLinq_c()
        {
            // manier 1 query syntax
            var querySyntax = (from d in LinqData.driehoek select d).Distinct();
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();


            // manier 2 Method syntax
            var methodSyntax = LinqData.driehoek.Distinct();
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

        }

        // d.Druk alle unieke getallen af uit de List, driehoek, die deelbaar zijn door drie of vijf.
        // De getallen worden in een oplopende volgorde afgedrukt.
        public static void SortLinq_d()
        {
            // manier 1 query syntax
            var querySyntax = LinqData.driehoek
                .Where(d => d % 3 == 0 || d % 5 == 0)
                .OrderBy(d => d)
                .Distinct();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
          
            // manier 2 Method syntax
            var methodSyntax = LinqData.driehoek.Where(d => d % 3 == 0 || d % 5 == 0).OrderBy(d => d).Distinct();
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //e.Druk de woorden uit de array, tekst, af in een aflopende volgorde op
        //basis van lengte.Verder zijn woorden met dezelfde lengte gesorteerd op een oplopende alfabetische volgorde.
        public static void SortLinq_e()
        {
            // manier 1 query syntax
            var qryMethod = from woord in LinqData.tekst orderby woord.Length descending, woord ascending select woord;
            foreach (var item in qryMethod)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            var methodSyntax = LinqData.tekst
               .OrderBy(bee => bee)
               .OrderByDescending(b => b.Length);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //* f.Maak een groep op basis van de startletter van ieder woord voor al de woorden in de array, tekst.
        public static void SortLinq_f()
        {
            // manier 1 query syntax

            var querySyntax = from leukeNaam in LinqData.tekst
                      orderby leukeNaam
                      group leukeNaam by leukeNaam.First() into eersteLetter
                      select eersteLetter;
            foreach (var item in querySyntax)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var x in item)
                {
                    Console.WriteLine($"{x}");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            //  manier 2 Method syntax
            var methodSyntax = LinqData.tekst
                .OrderBy(t => t)
                .GroupBy(x => x.First());
            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var x in item)
                {
                    Console.WriteLine($"{x}");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //g. Vind alle paren van getallen en woorden waar de lengte van het woord
        //uit de array, tekst, gelijk is aan een getal uit de List, driehoek.Druk het alle gevonden paren af.
        public static void SortLinq_g()
        {
            // manier 1 query syntax
            var querySyntax = (from woord in LinqData.tekst
                       join hoek in LinqData.driehoek
                       on woord.Length equals hoek
                       orderby woord.Length, woord
                       select (woord, hoek));
            foreach (var x in querySyntax)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            var methodSyntax = LinqData.tekst
                .Join(LinqData.driehoek, woord => woord.Length, hoek => hoek, (woord, hoek) => (hoek, woord));
            foreach (var x in methodSyntax)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

        }

        //h.Maak een uitbreiding op de vorige oefening die er voor zorgt dat elk
        //woord slechts één maal voorkomt in de resulterende paren.
        public static void SortLinq_h()
        {
            // manier 1 query syntax
            var querySyntax = (from woord in LinqData.tekst
                       join hoek in LinqData.driehoek
                       on woord.Length equals hoek
                       orderby woord.Length, woord
                       select (woord, hoek)).Distinct();
            foreach (var x in querySyntax)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();


            // manier 2 Method syntax
            var methodSyntax = LinqData.tekst
                .Join(LinqData.driehoek, woord => woord.Length, hoek => hoek, (woord, hoek) => (hoek, woord))
                .Distinct();
            foreach (var x in methodSyntax)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

        }

        //* i. Druk alle woorden af uit de array, tekst, die minstens drie klinkers bevatten.
        public static void SortLinq_i()
        {
            char[] klinkers = { 'a', 'e', 'i', 'o', 'u' };
            
            // manier 1 query syntax
            var querySyntax = from woord in LinqData.tekst
                      where (from letter in woord
                             where klinkers.Contains(letter)
                             select letter).Count() >= 3
                      select woord;
            foreach (var x in querySyntax)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();


            // manier 2 Method syntax
            var methodSyntax = LinqData.tekst
                .Where(woord => woord.Where(letter => klinkers.Contains(letter)).Count() >= 3);
            foreach (var x in methodSyntax)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }


    }

}
