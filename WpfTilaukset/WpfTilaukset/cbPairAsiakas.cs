using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTilaukset
{
    class cbPairAsiakas
    {
        public string asiakasNimi {  get; set; }
        public int asiakasNro {  get; set; }

        public cbPairAsiakas(string AsiakasNimi, int AsiakasNro)
        {
            asiakasNimi = AsiakasNimi;
            asiakasNro = AsiakasNro;
        }
        
    
    }
}
