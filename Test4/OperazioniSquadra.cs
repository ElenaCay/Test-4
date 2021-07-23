using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test4.Dati;

namespace Test4
{
    public static class OperazioniSquadra
    {
        public static void AggiungiCalciatori(int cod)
        {
            foreach(Squadra sq in squadre)
            {
                if (sq.ID==cod)
                {
                    Console.WriteLine("Premi p se vuoi aggiungere un portiere");
                    Console.WriteLine("Premi d se vuoi aggiungere un difensore");
                    Console.WriteLine("Premi c se vuoi aggiungere un centrocampista");
                    Console.WriteLine("Premi a se vuoi aggiungere un'attaccante");
                    string x = Console.ReadLine();
                    do
                    {

                        Console.WriteLine("Inserisci l'ID del giocatore (numero intero)");
                        int.TryParse(Console.ReadLine(), out int id);
                        Console.WriteLine("Inserisci il nome del giocatore");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Inserisci il numero della maglia");
                        int.TryParse(Console.ReadLine(), out int n);
                        Console.WriteLine("Inserisci la data di nascita");
                        string dt = Console.ReadLine();
                        switch (x)
                        {
                            case "p":
                                Console.WriteLine("Inserisci il numero dei gol parati");
                                int.TryParse(Console.ReadLine(), out int gp);
                                Console.WriteLine("Inserisci il numero dei gol subiti");
                                int.TryParse(Console.ReadLine(), out int gs);
                                sq.Rosa.Add(new Portiere()
                                { ID = id, Nome = nome, NumeroMaglia = n, DataDiNascita = dt, GolParati = gp, GolSubiti = gs });
                                return;
                            case "d":
                                Console.WriteLine("Inserisci il numero dei tackle riusciti");
                                int.TryParse(Console.ReadLine(), out int ntr);
                                sq.Rosa.Add(new Difensore()
                                { ID = id, Nome = nome, NumeroMaglia = n, DataDiNascita = dt, NumeroTackleRiusciti = ntr });
                                return;
                            case "c":
                                Console.WriteLine("Inserisci il numero dei tackle riusciti");
                                int.TryParse(Console.ReadLine(), out int npr);
                                Console.WriteLine("Inserisci il numero dei tackle tentati");
                                int.TryParse(Console.ReadLine(), out int ntt);
                                sq.Rosa.Add(new Centrocampista()
                                { ID = id, Nome = nome, NumeroMaglia = n, DataDiNascita = dt, NumeroPassaggiRiusciti = npr, NumeroPassaggiTentati = ntt });
                                return;
                            case "a":
                                Console.WriteLine("Inserisci il numero dei gol");
                                int.TryParse(Console.ReadLine(), out int ng);
                                sq.Rosa.Add(new Attaccante()
                                { ID = id, Nome = nome, NumeroMaglia = n, DataDiNascita = dt, NumeroGol = ng });
                                return;
                            default:
                                Console.WriteLine("Hai premuto il tasto sbagliato. Riprova!");
                                Console.WriteLine("Premi p se vuoi aggiungere un portiere");
                                Console.WriteLine("Premi d se vuoi aggiungere un difensore");
                                Console.WriteLine("Premi c se vuoi aggiungere un centrocampista");
                                Console.WriteLine("Premi a se vuoi aggiungere un'attaccante");
                                break;
                        }
                    } while ((x != "a") ||(x!="p")||(x!="d")||(x!="c"));


                }
            }

        }

        public static void MostraSquadre()
        {
            foreach (Squadra sq in squadre)
            {
                 Console.WriteLine($"ID: { sq.ID} - Nome squadra:{sq.Nome}  - Data fondazione:{sq.DataFondazione}");
            }
        }

        public static void MostraRosa(int cod)
        {
            foreach (Squadra sq in squadre)
            {
                if (sq.ID == cod)
                {
                    foreach (Calciatore ca in sq.Rosa)
                        Console.WriteLine($"ID: { ca.ID} - Nome giocatore:{ca.Nome}  - Numero maglia:{ca.NumeroMaglia}");

                }
            }
        }

        public static void VendereGiocatore(int cod, int codG)
        {
            foreach (Squadra sq in squadre)
            {
                if (sq.ID == cod)
                {
                    foreach (var ca in sq.Rosa)
                    {
                        if (ca.ID == codG)
                        {
                            sq.Rosa.Remove(ca);
                        }
                    }
                }
            }
        }

        public static void GestisciSquadraTitolare(int cod)
        {

        }
        public static void MostraStatistiche(int cod)
        {

        }
    }
}
