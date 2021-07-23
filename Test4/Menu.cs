using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto, gestisci una squadra di calcio!");

            char choice;

            do
            {
                Console.WriteLine("Premi 1 per aggiungere calciatori alla rosa");
                Console.WriteLine("Premi 2 per vendere un giocatore");
                Console.WriteLine("Premi 3 per gestire la squadra titolare");
                Console.WriteLine("Premi 4 per stampare le statistiche della squadra titolare");
                Console.WriteLine("Premi q per uscire");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Inserisci l'ID della squadra");
                        OperazioniSquadra.MostraSquadre();
                        int.TryParse(Console.ReadLine(),out int id);
                        OperazioniSquadra.AggiungiCalciatori(id);
                        OperazioniSquadra.MostraRosa(id);
                        Console.WriteLine();
                        break;
                    case '2':
                        Console.WriteLine("Inserisci l'ID della squadra");
                        OperazioniSquadra.MostraSquadre();
                        int.TryParse(Console.ReadLine(), out id);
                        Console.WriteLine("Inserisci l'ID del giocatore da eliminare");
                        OperazioniSquadra.MostraRosa(id);
                        int.TryParse(Console.ReadLine(), out int idG);
                        OperazioniSquadra.VendereGiocatore(id, idG);
                        OperazioniSquadra.MostraRosa(id);
                        Console.WriteLine();
                        break;
                    case '3':
                        Console.WriteLine("Inserisci l'ID della squadra");
                        OperazioniSquadra.MostraSquadre();
                        int.TryParse(Console.ReadLine(), out id);
                        OperazioniSquadra.GestisciSquadraTitolare(id);
                        Console.WriteLine();
                        break;
                    case '4':
                        Console.WriteLine("Inserisci l'ID della squadra");
                        OperazioniSquadra.MostraSquadre();
                        int.TryParse(Console.ReadLine(), out id);
                        OperazioniSquadra.MostraStatistiche(id);
                        Console.WriteLine();
                        break;
                    case 'q':
                        //Esci
                        Console.WriteLine("\nCiao!");
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile. Riprova!");
                        break;
                }

            } while (!(choice == 'q'));
        }
    }
}
