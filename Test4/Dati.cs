using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Dati
    {
        public static List<Calciatore> rosa = new List<Calciatore>()
            {
                new Attaccante(){ID=1, Nome="NomeA1", NumeroMaglia=23, DataDiNascita="30/03/1996", NumeroGol=22 },
                new Attaccante(){ID=2, Nome="NomeA2", NumeroMaglia=1, DataDiNascita="25/03/1990", NumeroGol=4 },
                new Attaccante(){ID=2, Nome="NomeA3", NumeroMaglia=2, DataDiNascita="25/03/1980", NumeroGol=10 },
                new Centrocampista(){ID=4, Nome="NomeA4", NumeroMaglia=4, DataDiNascita="02/01/1975", NumeroPassaggiTentati=23, NumeroPassaggiRiusciti=10 },
                new Portiere(){ID=5, Nome="NomeA5", NumeroMaglia=5, DataDiNascita="10/10/1982", GolParati=34, GolSubiti=10 },
                new Difensore(){ID=6, Nome="NomeA6", NumeroMaglia=6, DataDiNascita="02/03/2000", NumeroTackleRiusciti=35 },
                new Difensore(){ID=7, Nome="NomeA7", NumeroMaglia=7, DataDiNascita="25/03/1990", NumeroTackleRiusciti=20 },
                new Centrocampista(){ID=8, Nome="NomeA8", NumeroMaglia=8, DataDiNascita="25/03/1996", NumeroPassaggiRiusciti=54, NumeroPassaggiTentati=40},
                new Difensore(){ID=9, Nome="NomeA9", NumeroMaglia=9, DataDiNascita="25/08/1990", NumeroTackleRiusciti=14},
                new Centrocampista(){ID=10, Nome="NomeA10", NumeroMaglia=10, DataDiNascita="25/03/2001", NumeroPassaggiRiusciti=16, NumeroPassaggiTentati=10 },
                new Attaccante(){ID=11, Nome="NomeA11", NumeroMaglia=11, DataDiNascita="25/02/1990", NumeroGol=2 },
                new Attaccante(){ID=12, Nome="NomeA12", NumeroMaglia=12, DataDiNascita="11/03/1990", NumeroGol=51 },
                new Portiere(){ID=13, Nome="NomeA13", NumeroMaglia=13, DataDiNascita="2/07/1990", GolParati=20, GolSubiti=5 },
                new Difensore(){ID=14, Nome="NomeA14", NumeroMaglia=14, DataDiNascita="1/03/1980", NumeroTackleRiusciti=28 },
                new Centrocampista(){ID=15, Nome="NomeA15", NumeroMaglia=15, DataDiNascita="25/11/2002", NumeroPassaggiRiusciti=42, NumeroPassaggiTentati=31}
        };

        public static List<Calciatore> rosa2 = new List<Calciatore>()
            {
                new Attaccante(){ID=1, Nome="NomeA1", NumeroMaglia=23, DataDiNascita="30/03/1996", NumeroGol=22 },
                new Attaccante(){ID=2, Nome="NomeA2", NumeroMaglia=1, DataDiNascita="25/03/1990", NumeroGol=4 },
                new Attaccante(){ID=2, Nome="NomeA3", NumeroMaglia=2, DataDiNascita="25/03/1980", NumeroGol=10 },
                new Centrocampista(){ID=4, Nome="NomeA4", NumeroMaglia=4, DataDiNascita="02/01/1975", NumeroPassaggiTentati=23, NumeroPassaggiRiusciti=10 },
                new Portiere(){ID=5, Nome="NomeA5", NumeroMaglia=5, DataDiNascita="10/10/1982", GolParati=34, GolSubiti=10 },
                new Difensore(){ID=6, Nome="NomeA6", NumeroMaglia=6, DataDiNascita="02/03/2000", NumeroTackleRiusciti=35 },
                new Difensore(){ID=7, Nome="NomeA7", NumeroMaglia=7, DataDiNascita="25/03/1990", NumeroTackleRiusciti=20 },
                new Centrocampista(){ID=8, Nome="NomeA8", NumeroMaglia=8, DataDiNascita="25/03/1996", NumeroPassaggiRiusciti=54, NumeroPassaggiTentati=40},
                new Difensore(){ID=9, Nome="NomeA9", NumeroMaglia=9, DataDiNascita="25/08/1990", NumeroTackleRiusciti=14},
                new Centrocampista(){ID=10, Nome="NomeA10", NumeroMaglia=10, DataDiNascita="25/03/2001", NumeroPassaggiRiusciti=16, NumeroPassaggiTentati=10 },
                new Attaccante(){ID=11, Nome="NomeA11", NumeroMaglia=11, DataDiNascita="25/02/1990", NumeroGol=2 },
                new Attaccante(){ID=12, Nome="NomeA12", NumeroMaglia=12, DataDiNascita="11/03/1990", NumeroGol=51 },
                new Portiere(){ID=13, Nome="NomeA13", NumeroMaglia=13, DataDiNascita="2/07/1990", GolParati=20, GolSubiti=5 },
                new Difensore(){ID=14, Nome="NomeA14", NumeroMaglia=14, DataDiNascita="1/03/1980", NumeroTackleRiusciti=28 },
                new Centrocampista(){ID=15, Nome="NomeA15", NumeroMaglia=15, DataDiNascita="25/11/2002", NumeroPassaggiRiusciti=42, NumeroPassaggiTentati=31}
        };

        public static Squadra squadra = new Squadra()
        {
            ID = 1,
            Nome = "Italia",
            DataFondazione = "25/05/1940",
            CampionatoDisputato = "capionato1",
            NomePresidente = "Presidente 1",
            NomeAllenatore = "Allenatore 1",
            Rosa = rosa
        };

        public static Squadra squadra2 = new Squadra()
        {
            ID = 2,
            Nome = "Francia",
            DataFondazione = "25/05/1960",
            CampionatoDisputato = "capionato1",
            NomePresidente = "Presidente 2",
            NomeAllenatore = "Allenatore 2",
            Rosa = rosa2
        };

        public static List<Squadra> squadre = new List<Squadra>()
        {
            squadra,
            squadra2
        };
    }
}
