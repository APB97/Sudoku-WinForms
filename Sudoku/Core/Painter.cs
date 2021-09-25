using System;
using System.Drawing;
using static SudokuLib.Helpers.SudokuConstants;

namespace SudokuLib.Core
{
    public class Painter
    {
        private int _lineWidth = 2;
        private int _cellSize = 96;
        private float _fontSize = 62;

        public int LineWidth
        {
            get => _lineWidth;
            set => _lineWidth = Math.Max(Math.Min(value, 8), 2) / 2 * 2;
        }

        public int CellSize
        {
            get => _cellSize;
            set => _cellSize = value;
        }

        public float FontSize
        {
            get => _fontSize;
            set => _fontSize = value;
        }

        public Image CreateImage(int[,] values, bool[,] predefined)
        {
            int width = CellSize * 9 + (4 * 2 + 10) * LineWidth;
            int step = CellSize;
            int bigStep = 3 * CellSize + 6 * LineWidth;
            width += LineWidth + LineWidth;
            Bitmap bmp = new Bitmap(width, width);
            using (var graphics = Graphics.FromImage(bmp))
            {
                using (Pen linePen = new Pen(Color.Black, LineWidth), thickLinePen = new Pen(Color.Black, LineWidth + LineWidth))
                {
                    graphics.Clear(Color.White);
                    for (int i = LineWidth; i < width; i+= bigStep)
                    {
                        graphics.DrawLine(thickLinePen, 0, i, width, i);
                        graphics.DrawLine(thickLinePen, i, 0, i, width);
                        for (int j = 0; j <= 3; j++)
                        {
                            var coord = i + LineWidth + LineWidth / 2 + j * (step + LineWidth);
                            graphics.DrawLine(linePen, coord, 0, coord, width);
                            graphics.DrawLine(linePen, 0, coord, width, coord);
                        }
                    }

                    var stringFormat = new StringFormat();
                    stringFormat.Alignment = stringFormat.LineAlignment = StringAlignment.Center;
                    for (int y = 0; y < SudokuSize; y++)
                        for (int x = 0; x < SudokuSize; x++)
                            if (values[y, x] != EmptyCellValue)
                                graphics.DrawString($"{values[y, x]}", new Font(FontFamily.GenericSansSerif, FontSize),
                                    predefined[y, x] ? Brushes.Black : Brushes.Gray,
                                    new RectangleF(
                                        LineWidth * (3 + x + x / 3 * 3) + x * CellSize,
                                        LineWidth * (3 + y + y / 3 * 3) + y * CellSize,
                                        CellSize,
                                        CellSize),
                                    stringFormat);
                }
            }
            return bmp;
        }
    }
}