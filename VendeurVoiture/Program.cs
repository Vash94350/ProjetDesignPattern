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
            boitagantparent.AddRangemment(pochefille);
            boitagantparent.AddRangemment(pochefille2);
            boitagantparent.AddRangemment(boitagantbanal);

            //Module Fabrique
            Fabrique.FabriqueAcier fabriqueAcier = new Fabrique.FabriqueAcier();
            Fabrique.Voiture voiture = fabriqueAcier.CreateVoiture("voiture en acier", "v00001");
            voiture.AddRangement(boitagantparent);
            Console.WriteLine("Voiture cree : " + voiture.Name);
            Console.WriteLine("Ella a " + voiture.NombreDeRoues + " roues");
            Console.WriteLine("Les rangements presents sont : ");
            foreach (IRangement i in voiture.Rangements)
            {
                Console.WriteLine("Le rangement : " + i.Name + " de taille : " + i.Size);
            }


            //Module Conception
            Conception.ComposantFabric atelier = new Conception.ComposantFabric();
            Conception.Composant moteur20CV = atelier.getComposant("moteur20CV");
            moteur20CV.SetPrice(new Stock.Price(100.0, "EUR"));
            Conception.Composant tableauDeBordGPSIntegre = atelier.getComposant("GPSIntegre");
            tableauDeBordGPSIntegre.SetPrice(new Stock.Price(85.0, "EUR"));
            voiture.AddComposant(moteur20CV);
            voiture.AddComposant(moteur20CV);
            voiture.AddComposant(tableauDeBordGPSIntegre);
            Console.WriteLine("Les composant de " + voiture.Name + " sont : " + voiture.getListDesComposants());

            //Module Vente
            Vente.CommandeEnFrance commande_MonsieurDupont = new Vente.CommandeEnFrance(voiture);
            Console.WriteLine("Monsieur Dupont devra payer un montant total de : " + commande_MonsieurDupont.CalculeMontant() + " " + commande_MonsieurDupont.getDevise());

            //Module Comparateur avec en plus le pattern Singleton
            Console.WriteLine("Voici le stock de voiture : ");
            foreach (Fabrique.Voiture voiturei in Stock.StockDeVoiture.Instance.GetVoitureDisponnible(DateTime.Now))
            {
                Console.WriteLine("Voici la " + voiturei.Name + " avec pour reference : " + voiturei.Reference);
            }
            Console.WriteLine();


            Console.Read();
        }
    }
}
