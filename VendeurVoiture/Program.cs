using System;

namespace VendeurVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            //module Rangement
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

            //Module Fabrique
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


            //Module Conception
            Conception.Voiture voiture2 = new Conception.Voiture();
            Conception.ComposantFabric atelier = new Conception.ComposantFabric();
            Conception.Composant moteur20CV = atelier.getComposant("moteur20CV");
            voiture2.lesComposants.Add(moteur20CV);

            Console.WriteLine("Les composants de la voiture2 sont ");
            Console.WriteLine(voiture2.toString());

            //Module Vente
            Vente.CommandeEnFrance commande_MonsieurDupont = new Vente.CommandeEnFrance(2037.2);
            Console.WriteLine("Monsieur Dupont devra payer un montant total de : " + commande_MonsieurDupont.CalculeMontant());

            Console.Read();
        }
    }
}
