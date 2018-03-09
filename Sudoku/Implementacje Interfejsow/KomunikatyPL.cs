using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class KomunikatyPL : Interfejsy.IKomunikaty
    {
        public string Uwaga => "Uwaga!";

        public string NieodpowiedniaIloscLinii => "Nieodpowiednia ilość linii w pliku!";

        public string NieodpowiedniaIloscWartosciPol(int nrLinii) =>
            string.Format("Nieodpowiednia ilość wartości pól w linii {0}!", nrLinii);

        public string NieWszystkieSaCyframi(int nrLinii) =>
            string.Format("W linii {0} nie wszystkie wartości pól są cyframi!", nrLinii);
    }
}
