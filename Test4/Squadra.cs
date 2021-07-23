using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Squadra 
    
    { 

        public int ID { get; set; }
        public string Nome { get; set; }
        public string DataFondazione { get; set; }
        public string CampionatoDisputato { get; set; }
        public string NomePresidente { get; set; }
        public string NomeAllenatore { get; set; }
        public List<Calciatore> Rosa { get; set; }



        
        }
    
}
