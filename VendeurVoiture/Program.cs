using System;

namespace VendeurVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            BoiteAGants boitagantparent = new BoiteAGants("superboite", 10, "trappeCoté", "x459846f");
            BoiteAGants boitagantbanal = new BoiteAGants("banalboiteagant", 2, "trappeVertical", "x5648468f");
            var pochefille = new Poche("petite poche", 2, "1351351");
            var pochefille2 = new Poche("petite poche 2", 2, "1351351");
            boitagantparent.Rangements.Add(pochefille);
            boitagantparent.Rangements.Add(pochefille2);
            boitagantparent.Rangements.Add(boitagantbanal);
            /*           Voiture voiture = new Voiture("turbobinette","x285962f");
                       Console.WriteLine(voiture.NombreDeRoues);
                       voiture.Rangements.Add(boitagantparent);
                       foreach (IRangement i in voiture.Rangements)
                       {
                           Console.WriteLine(i.Name);
                           Console.WriteLine(i.Size);
                       }
                       Console.Read();*/

            Fabrique.FabriqueAcier fabriqueAcier = new Fabrique.FabriqueAcier();
            Fabrique.Voiture voiture = fabriqueAcier.CreateVoiture("voiture en acier", "xizjogiz");
            voiture.Rangements.Add(boitagantparent);
            Console.WriteLine(voiture.Name);
            Console.WriteLine(voiture.NombreDeRoues);
            Console.WriteLine("Les rangements presents sont : ");
            foreach (IRangement i in voiture.Rangements)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Size);
            }
            Console.Read();
        }
    }
}
