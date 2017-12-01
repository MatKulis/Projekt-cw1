using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMK
{
    class Zawartosc//:ICloneable
    {
        public string nazwapro;
        public double cena;
        public int ilosc;
        public static List<Zawartosc> zakupy;
        public void Dodawaniezakupow(List<Zawartosc> zakupy){
            //zakupy = zakuppy;
            List<Zawartosc> zakuppy = new List<Zawartosc>();
            zakuppy.Add(new Zawartosc() {nazwapro="Jablko", cena=2.34 , ilosc=4});
            
        }
    }
}
