namespace Sudoku.Interfejsy
{
    interface IKomunikaty
    {
        string Uwaga { get; }
        string NieodpowiedniaIloscLinii { get; }

        string NieodpowiedniaIloscWartosciPol(int nrLinii);
        string NieWszystkieSaCyframi(int nrLinii);
    }
}
