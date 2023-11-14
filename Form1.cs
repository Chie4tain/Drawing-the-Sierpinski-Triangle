using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal_drawing
{
    public partial class FSierpinski_Triangle : Form
    {
        private int depth = 2;
        private Color color = Color.Black;
        private int pointCounter = 0;
        ToolStripStatusLabel string_p_count;
        ToolStripStatusLabel pic_size;
        public FSierpinski_Triangle()
        {
            InitializeComponent();
            numUpDownDepthSetter.Value = depth;

            this.Controls.SetChildIndex(PnlCanvas, 0);
            this.Controls.SetChildIndex(pnlSettings, 1);
            this.Controls.SetChildIndex(StStrip, 3);

            PnlShowColor.BackColor = color;

            string_p_count = new ToolStripStatusLabel();
            pic_size = new ToolStripStatusLabel();
            pic_size.Text = $" Size: {PnlCanvas.Width} * {PnlCanvas.Height}px";

            StStrip.Items.Add(string_p_count);
            StStrip.Items.Add(pic_size);
        }

        private void PnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF point1 = new PointF(10, PnlCanvas.Height - 10);
            PointF point2 = new PointF(PnlCanvas.Width - 10, PnlCanvas.Height - 10);
            PointF point3 = new PointF(PnlCanvas.Width / 2, 10);
            HashSet<PointF> points = new HashSet<PointF>();
            DrawSierpTriangle(g, depth, point1, point2, point3, points);
            UpdatePointCounter(points.Count);
        }

        private void UpdatePointCounter(int count)
        {
            pointCounter = count;
            string_p_count.Text = $"Points: {pointCounter.ToString()}";
        }

        private void DrawSierpTriangle(Graphics g, int p_depth, PointF p1, PointF p2, PointF p3, HashSet<PointF> p_unPoints)
        {
            if (p_depth == 0) 
            {
                PointF[] points = { p1, p2, p3 };
                g.FillPolygon(new SolidBrush(color), points);

                foreach (var point in points)
                {
                    p_unPoints.Add(point);
                }
            }
            else
            {
                PointF mid1 = Midpoint(p1, p2);
                PointF mid2 = Midpoint(p2, p3);
                PointF mid3 = Midpoint(p3, p1);
                DrawSierpTriangle(g, p_depth - 1, p1, mid1, mid3, p_unPoints);
                DrawSierpTriangle(g, p_depth - 1, mid1, p2, mid2, p_unPoints);
                DrawSierpTriangle(g, p_depth - 1, mid2, p3, mid3, p_unPoints);
            }
        }
        private PointF Midpoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X)/2, (p1.Y + p2.Y)/2);
        }

        private void SaveImage(string filepath)
        {
            Bitmap bitmap = new Bitmap(PnlCanvas.Width, PnlCanvas.Height);

            Graphics g = Graphics.FromImage(bitmap);
            PnlCanvas.DrawToBitmap(bitmap,new Rectangle(0,0,PnlCanvas.Width,PnlCanvas.Height));

            bitmap.Save(filepath);
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            pointCounter = 0;
            PnlCanvas.Refresh();
        }

        private void numUpDownDepthSetter_ValueChanged(object sender, EventArgs e)
        {
            depth = (int)numUpDownDepthSetter.Value;
        }

        private void PnlShowColor_Click(object sender, EventArgs e)
        {
            if (ColDLineColorControl.ShowDialog() == DialogResult.OK)
            {
                color = ColDLineColorControl.Color;
                PnlShowColor.BackColor = color;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                SaveImage(SFDialog.FileName);
            }
            
        }
    }
}
