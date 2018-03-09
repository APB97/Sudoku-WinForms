using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Interfejsy
{
    interface IKomunikaty
    {
        #region //Właściwości
        string Uwaga { get; }
        string NieodpowiedniaIloscLinii { get; }
        #endregion


        #region //Metody
        string NieodpowiedniaIloscWartosciPol(int nrLinii);
        string NieWszystkieSaCyframi(int nrLinii);
        #endregion
    }
}
