using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sudoku
{
    class WydrukSudoku
    {
        private int baseSize, scale, baseFrame, frameSize, oneUnitSize, threeUnitSize, nineUnitSize;
        private string nazwaPlikuTymczasowegoPng = "tmp.png";
        private Pen pioroSzare, pioroCzarne;

        public WydrukSudoku(int bazowyRozmiarMalegoKwadratu, int szerokoscRamki, int skala)
        {
            baseSize = bazowyRozmiarMalegoKwadratu;
            scale = skala;
            baseFrame = szerokoscRamki;
            frameSize = baseFrame * scale;
            oneUnitSize = bazowyRozmiarMalegoKwadratu * scale;
            threeUnitSize = oneUnitSize * 3;
            nineUnitSize = threeUnitSize * 3;
            pioroSzare = new Pen(Color.DimGray, frameSize / 2);
            pioroCzarne = new Pen(Color.Black, frameSize);
        }

        public void Drukuj(SudokuCell[,] tabelkaSudoku)
        {
            Bitmap img = new Bitmap(nineUnitSize, nineUnitSize);
            var g = Graphics.FromImage(img);
            Font font = new Font(tabelkaSudoku[0, 0].textBox.Font.FontFamily,
                tabelkaSudoku[0, 0].textBox.Font.SizeInPoints * 2 * scale, FontStyle.Bold);
            g.Clear(Color.White);
            RysujSzareLinie(g);
            RysujCzarnePogrubioneLinie(g);
            RysujZawartoscPolSudoku(tabelkaSudoku, g, font);
            if (Properties.Settings.Default.PictureInsteadOfPrint)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    AddExtension = true,
                    DefaultExt = ".png",
                    Filter = "Pliki PNG|*.png"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    img.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                img.Save(nazwaPlikuTymczasowegoPng, System.Drawing.Imaging.ImageFormat.Png);
                Process p = new Process();
                p.StartInfo.FileName = nazwaPlikuTymczasowegoPng;
                p.StartInfo.Verb = "Print";
                p.Exited += (object sender, EventArgs e) => File.Delete(nazwaPlikuTymczasowegoPng);
                p.Start();
            }
        }

        private void RysujSzareLinie(Graphics g)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 != 0)
                {
                    g.DrawLine(pioroSzare, i * oneUnitSize, 0, i * oneUnitSize, nineUnitSize);
                    g.DrawLine(pioroSzare, 0, i * oneUnitSize, nineUnitSize, i * oneUnitSize);
                }
            }
        }

        private void RysujCzarnePogrubioneLinie(Graphics g)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 == 0)
                {
                    g.DrawLine(pioroCzarne, i * oneUnitSize, 0, i * oneUnitSize, nineUnitSize);
                    g.DrawLine(pioroCzarne, 0, i * oneUnitSize, nineUnitSize, i * oneUnitSize);
                }
            }
            RysujPoprawionePoziomeKrawedzie(g);
            RysujPoprawionePionoweKrawedzie(g);
        }

        private void RysujPoprawionePionoweKrawedzie(Graphics g)
        {
            g.DrawLine(pioroCzarne, frameSize / 2, 0, frameSize / 2, nineUnitSize);
            g.DrawLine(pioroCzarne, nineUnitSize - frameSize / 2, 0, nineUnitSize - frameSize / 2, nineUnitSize);
        }

        private void RysujPoprawionePoziomeKrawedzie(Graphics g)
        {
            g.DrawLine(pioroCzarne, 0, frameSize / 2, nineUnitSize, frameSize / 2);
            g.DrawLine(pioroCzarne, 0, nineUnitSize - frameSize / 2, nineUnitSize, nineUnitSize - frameSize / 2);
        }

        private void RysujZawartoscPolSudoku(SudokuCell[,] tabelkaSudoku, Graphics g, Font font)
        {
            var m = g.MeasureString("0", font);
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (tabelkaSudoku[i, j].textBox.Font.Bold)
                        g.DrawString(tabelkaSudoku[i, j].CellContent, font, pioroCzarne.Brush,
                            new RectangleF(j * oneUnitSize + (oneUnitSize - m.Width) / 2,
                            i * oneUnitSize + (oneUnitSize - m.Height) / 2, m.Width, m.Height));
        }
    }
}
