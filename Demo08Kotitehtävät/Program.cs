using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08Kotitehtävät
        {
    
    class Program
        {
        static void Main(string[] args)
        {


            List<Tuote> tuotteet = new List<Tuote>();


            tuotteet.Add(new Tuote {Nimi="Tupakka",Hinta="6,50"});

            tuotteet.Add(new Tuote {Nimi="Juusto",Hinta="5,00"});

            tuotteet.Add(new Tuote {Nimi="Maito",Hinta="2,00"});

            tuotteet.Add(new Tuote {Nimi="Limonadi",Hinta="2,00"});

            tuotteet.Add(new Tuote {Nimi="Leipä",Hinta="0,99"});




            Console.WriteLine("Korin tuotteet : ");


            foreach (Tuote tuote in tuotteet)
            {
                Console.WriteLine("Nimi: " + tuote.Nimi + "    Hinta: " + tuote.Hinta + "Euroa");
            }
            }
            }
            }