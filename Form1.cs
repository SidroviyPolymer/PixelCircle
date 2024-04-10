using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PixelCircles
{
    public partial class MainForm : Form
    {
        private UInt32 d;
        private UInt32 m;
        private UInt32 length;
        private List.List<int> list;

        public MainForm()
        {
            InitializeComponent();
            d = 0;
            m = 0;
            length = 0;
            list = new List.List<int>();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TB_D_TextChanged(object sender, EventArgs e)
        {
            if (TB_D.Text == "")
            {
                CanvasClear();
                return;
            }

            string text = TB_D.Text;
            if (text.Length > length)
            {
                if (text.Last<char>() < 48 || text.Last<char>() > 57)
                    TB_D.Text = TB_D.Text.Substring(0, text.Length - 1);
                else
                    ++length;
            }



            d = UInt32.Parse(TB_D.Text);            
            FillList();
            CanvasDraw();
        }

        private void TrBar_M_ValueChanged(object sender, EventArgs e)
        {
            CanvasDraw();
        }

        private void FillList()
        {
            list.Clear();

            UInt32 r = d / 2;

            double realX = ((d & 1) == 0) ? 0.5 : 1.0;
            double realR = ((double)d) / 2.0;

            for (UInt32 iter = 0; iter < r; ++iter)
            {
                double realY = Math.Sqrt(realR * realR - realX * realX);
                if ((d & 1) == 0)
                    realY += 0.5;

                int pixelY = (int)(Math.Truncate(realY));

                list.PushBack(pixelY);
                ++realX;
            }
        }

        private void CanvasDraw()
        {
            CanvasClear();
            Graphics graphics = PB_Canvas.CreateGraphics();

            SolidBrush inner = new SolidBrush(Color.FromArgb(0, 0, 0));
            Pen outer = new Pen(Color.FromArgb(255, 255, 255));

            m = (UInt32)TrBar_M.Value;

            UInt32 r = d / 2;
            UInt32 x = 0;
            UInt32 y = 0;

            for (UInt32 row = r; row > 0; --row, ++y, x = 0)
            {
                for (UInt32 col = r; col > 0; --col, ++x)
                {
                    if (list.At(col - 1) >= row)
                        DrawRectangle(x, y, m, Color.Black);
                }

                if ((d & 1) != 0)
                    DrawRectangle(x++, y, m, Color.Red);

                for (UInt32 col = 0; col < r; ++col, ++x)
                {
                    if (list.At(col) >= row)
                        DrawRectangle(x, y, m, Color.Black);
                }
            }

            x = 0;

            if ((d & 1) != 0)
            {
                for (UInt32 i = 0; i < d; ++i, ++x)
                    DrawRectangle(x, y, m, Color.Red);
                ++y;
            }

            x = 0;

            for (UInt32 row = 0; row < r; ++row, ++y, x = 0)
            {
                for (UInt32 col = r; col > 0; --col, ++x)
                {
                    if (list.At(col - 1) >= row + 1)
                        DrawRectangle(x, y, m, Color.Black);
                }

                if ((d & 1) != 0)
                {
                    DrawRectangle(x, y, m, Color.Red);
                    ++x;
                }

                for (UInt32 col = 0; col < r; ++col, ++x)
                {
                    if (list.At(col) >= row + 1)
                        DrawRectangle(x, y, m, Color.Black);
                }

                if ((d & 1) == 0)
                    DrawCenter(d, m);
            }
        }

        private void PB_Canvas_Click(object sender, EventArgs e)
        {
            CanvasClear();
        }        

        private void CanvasClear()
        {
            Graphics graphics = PB_Canvas.CreateGraphics();
            graphics.Clear(Color.White);            
        }

        private void DrawRectangle(UInt32 x, UInt32 y, UInt32 m, Color color)
        {
            Graphics graphics = PB_Canvas.CreateGraphics();

            SolidBrush inner = new SolidBrush(color);
            Pen outer = new Pen(Color.FromArgb(255, 255, 255));

            UInt32 w = 4 * m;
            graphics.FillRectangle(inner, x * w, y * w, w, w);
            graphics.DrawRectangle(outer, x * w, y * w, w, w);
        }

        private void DrawCenter(UInt32 d, UInt32 m)
        {
            Graphics graphics = PB_Canvas.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            UInt32 r = d / 2;

            graphics.DrawLine(pen, r * 4 * m, 1, r * 4 * m, d * 4 * m - 1);
            graphics.DrawLine(pen, r * 4 * m - 1, 1, r * 4 * m - 1, d * 4 * m - 1);
            graphics.DrawLine(pen, 1, r * 4 * m, d * 4 * m - 1, r * 4 * m);
            graphics.DrawLine(pen, 1, r * 4 * m - 1, d * 4 * m - 1, r * 4 * m - 1);
        }
    }
}
