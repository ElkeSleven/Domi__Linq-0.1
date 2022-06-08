using System;
using System.Collections.Generic; //<-- voor gebruik te kunnen maken van een list 
using System.Text;
using System.Linq;
using System.Threading.Tasks;
/* // Data
 * zet de class naar  --> public static 
 * declareren van variable als public static  
 */

/*// opgaven 
 * Gebruik de volgende IEnumerable objecten
 * public static List<int> driehoek
 * public static string[] tekst
 
 */


namespace LINQ
{
    public static class LinqData
    {
        public static List<int> driehoek = new List<int>()
        {
            1,   1,   1,   1,   1,   1,   1,   1,   1,   1,   1,
            1,   2,   3,   4,   5,   6,   7,   8,   9,   10,
            1,   3,   6,   10,  15,  21,  28,  36,  45,
            1,   4,   10,  20,  35,  56,  84,  120,
            1,   5,   15,  35,  70,  126, 210,
            1,   6,   21,  56,  126, 252,
            1,   7,   28,  84,  210,
            1,   8,   36,  120,
            1,   9,   45,
            1,   10,
            1
        };

        public static string[] tekst = new string[]
        {
            "langspeelfilm", "vluchtmisdrijf", "dovemansgesprek", "containerpark",
            "confituur", "inox", "valavond", "enerverend", "lopen", "bank", "vieruurtje",
            "waterzooi", "maaltijdcheque", "arrondissement", "eindtermen", "nieuwjaarsbrief"
        };






      /*  public static List<LinqEntitie> linqEntitie = new List<LinqEntitie>
        {
            new LinqEntitie("Brug4", 0, "Arendonk", 2370, "Holstraat", 14, 3000, new List<int>{ 4, 3, 1, 5 }),
            new LinqEntitie("Brug1", 1, "Arendonk", 2370, "Holstraat", 3, 8000, new List<int>{ 1, 4, 3, 5, 2, 3, 3, 4, 4}),
            new LinqEntitie("Poort1", 2, "Gent", 9000, "Stropkaai", 12, 7000, new List<int>{ 5, 4, 3, 4 , 4}),
            new LinqEntitie("Rijsteller", 3, "Hasselt", 3500, "Industrielaan", 1, 2500, new List<int>{ 5, 4, 3, 5, 2, 3, 4, 4}),
            new LinqEntitie("Automa klein", 4, "Berchem", 2600, "Nieuwevaart", 77, 10000, new List<int>{ 4 }),
            new LinqEntitie("Schuifla", 5, "Hasselt", 3500, "Industrielaan", 15, 1500, new List<int>{ 3, 5, 2 }),
            new LinqEntitie("Automa groot", 6, "Berchem", 2600, "Nieuwevaart", 76, 30000, new List<int>{ 5 }),
            new LinqEntitie("Brug2", 7, "Arendonk", 2370, "Molenweg", 7, 3000, new List<int>{ 4, 3, 5, 2 }),
            new LinqEntitie("Veerhal", 8, "Melle", 9090, "Merelstraat", 48, 500, new List<int>{ 5, 5 }),
            new LinqEntitie("Poort2", 9, "Gent", 9000, "Burgstraat", 113, 6600, new List<int>{ 1, 2, 1, 1, 2, 3}),
            new LinqEntitie("D1", 10, "Knokke", 8300, "Vaart", 2, 2200, new List<int>{ 5, 4, 1 }),
            new LinqEntitie("Brug3", 11, "Arendonk", 2370, "Molenweg", 8, 8000, new List<int>{ 5, 2, 3, 5, 5 }),
            new LinqEntitie("D2", 12, "Knokke", 8300, "Vaart", 4, 2200, new List<int>{ 2, 3, 4 }),
            new LinqEntitie("D3", 13, "Knokke", 8300, "Vaart", 6, 2200, new List<int>{ 3, 4, 3 })
        };*/


    }
}
