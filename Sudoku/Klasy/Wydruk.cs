using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class WydrukSudoku
    {
        private int baseSize, scale, baseFrame, frameSize, oneUnitSize, threeUnitSize, nineUnitSize;

        public WydrukSudoku(int bazowyRozmiarMalegoKwadratu, int szerokoscRamki, int skala)
        {
            baseSize = bazowyRozmiarMalegoKwadratu;
            scale = skala;
            baseFrame = szerokoscRamki;
            frameSize = baseFrame * scale;
            oneUnitSize = bazowyRozmiarMalegoKwadratu * scale;
            threeUnitSize = oneUnitSize * 3;
            nineUnitSize = threeUnitSize * 3;
        }

        public void Drukuj(PoleSudoku[,] tabelkaSudoku)
        {
            Bitmap img = new Bitmap(nineUnitSize, nineUnitSize);
            Pen pioroSzare = new Pen(Color.DimGray, oneUnitSize / 100);
            Pen pioroCzarne = new Pen(Color.Black, frameSize);
            Font font = new Font(tabelkaSudoku[0, 0].textBox.Font.FontFamily,
                tabelkaSudoku[0, 0].textBox.Font.SizeInPoints * 2 * scale, FontStyle.Bold);
            var g = Graphics.FromImage(img);
            g.Clear(Color.White);

            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 != 0)
                {
                    g.DrawLine(pioroSzare, i * oneUnitSize, 0, i * oneUnitSize, nineUnitSize);
                    g.DrawLine(pioroSzare, 0, i * oneUnitSize, nineUnitSize, i * oneUnitSize);
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 == 0)
                {
                    g.DrawLine(pioroCzarne, i * oneUnitSize, 0, i * oneUnitSize, nineUnitSize);
                    g.DrawLine(pioroCzarne, 0, i * oneUnitSize, nineUnitSize, i * oneUnitSize);
                }
            }

            g.DrawLine(pioroCzarne, 0, nineUnitSize - frameSize / 2, nineUnitSize, nineUnitSize - frameSize / 2);

            var m = g.MeasureString("0", font);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    g.DrawString(tabelkaSudoku[i, j].ZawartoscPola, font, pioroCzarne.Brush,
                        new RectangleF(j * oneUnitSize + (oneUnitSize - m.Width) / 2, i * oneUnitSize + (oneUnitSize - m.Height) / 2, m.Width, m.Height));
                }
            }
            if (Properties.Settings.Default.ObrazZamiastWydruku)
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
                img.Save("tmp.png", System.Drawing.Imaging.ImageFormat.Png);
                Process p = new Process();
                p.StartInfo.FileName = "tmp.png";
                p.StartInfo.Verb = "Print";
                p.Exited += (object sender, EventArgs e) => File.Delete("tmp.png");
                p.Start();
            }
        }
    }
}
