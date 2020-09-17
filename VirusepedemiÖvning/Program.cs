using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VirusepedemiÖvning
{

    class Program
    {
        static void Main(string[] args)
        {
            Smitta.CreateDiscotek();
            Smitta.SmittSpridning();
        }
    }

    class Smitta
    {
        static List<Person> discotek = new List<Person>();

        public static void CreateDiscotek()
        {
            for (int i = 0; i < 100; i++)
            {
                Person p = new Person();
                if (i==0)
                {
                    p.Smittad = true;
                    p.Imun = false;
                    p.SmittadNär = 5;
                }
                else
                {
                    p.Smittad = false;
                    p.Imun = false;
                    p.SmittadNär = 0;
                }

                discotek.Add(p);
            }
        }

        public static bool IsInfected(Person p)
        {
            return !p.Smittad;
        }
        public static void SmittSpridning()
        {
            int antalSmittade = 0;
            while (antalSmittade >= 0 && antalSmittade < discotek.Count)
            {
                Person p = discotek.Find(IsInfected);
                antalSmittade = discotek.IndexOf(p);
                

                Console.WriteLine($"{antalSmittade}");

                if (antalSmittade == -1)
                {
                    break;
                }

                int smittoräknare = antalSmittade;

                int antalSmittsamma = 0;
                foreach (Person person in discotek)
                {
                    if (person.SmittadNär <= 5 && person.SmittadNär > 0)
                    {
                        antalSmittsamma++;
                    }
                }

                if (antalSmittsamma<antalSmittade)
                {
                    for (int i = 0; i < antalSmittsamma; i++)
                    {
                        discotek[smittoräknare].Smittad = true;
                        smittoräknare++;
                    }
                }
                else
                {
                    for (int i = 0; i < antalSmittade; i++)
                    {
                        discotek[smittoräknare].Smittad = true;
                        smittoräknare++;
                    }
                }
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public bool Smittad { get; set; }
        public int SmittadNär { get; set; }
        public bool Imun { get; set; }
    }
}
