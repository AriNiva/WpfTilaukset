using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace WpfTilaukset
{
    class TilausRivi
    {
        public int TilausNumero {  get; set; }
        public int TilausRiviNumero {  get; set; }
        public int TuoteNumero {  get; set; }
        public string TuoteNimi { get; set; }
        public int Maara {  get; set; }
        public decimal AHinta { get; set; }
        public decimal Summa { get; set; }
        public decimal RiviSumma() 
        {
            Summa = AHinta * Maara;
            return Summa;
        }
        //Luodaan oma luokka, jotta sitä mukaa kun perustetaan tilausrivejä, olio voidaan viedä suoraan gridiin, koska grid tunnistaa ominaisuuksissa määriteltyjä sarakkeita
        //Luokassa on RiviSumma-metodi jota ei ole tietokannassa. Gridissä on sarake RiviSummaa varten.
    }
}
