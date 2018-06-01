using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AffineTrans
{
    public partial class frmMain : Form
    {
        AffineTransform AffineTransform = new AffineTransform();


        List<PointF> points = new List<PointF>();


        public frmMain()
        {
            InitializeComponent();

            points.Add(new PointF(-0.1f,0.1f));
            points.Add(new PointF(0.1f, 0.1f));
            points.Add(new PointF(0.1f, -0.2f));


            picMain.Paint += PicMain_Paint;
        }

        private void PicMain_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            float width = pictureBox.Width;
            float height = pictureBox.Height;

            List<PointF> result = new List<PointF>();
            foreach(PointF p in points)
            {
                Matrix.Vector v = AffineTransform.Transform(p);
                PointF pt = new PointF();
                pt.X = width * (v.X+0.5f);
                pt.Y = height * (v.Y+0.5f);
                result.Add(pt);
            }
            e.Graphics.Clear(Color.Black);
            e.Graphics.DrawLines(Pens.White, result.ToArray());
        }

        #region affine transform argument
        private void nRotate_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            AffineTransform.RotateDegree = decimal.ToSingle(num.Value);
            picMain.Invalidate();
        }

        private void nOffsetX_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            AffineTransform.OffsetX = decimal.ToSingle(num.Value);
            picMain.Invalidate();
        }

        private void nOffsetY_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            AffineTransform.OffsetY = decimal.ToSingle(num.Value);
            picMain.Invalidate();
        }

        private void nScaleX_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            AffineTransform.ScaleX = decimal.ToSingle(num.Value);
            picMain.Invalidate();
        }

        private void nScaleY_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            AffineTransform.ScaleY = decimal.ToSingle(num.Value);
            picMain.Invalidate();
        }
        #endregion

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AffineTransform.Order = 0;
            picMain.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AffineTransform.Order = 1;
            picMain.Invalidate();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AffineTransform.Order = 2;
            picMain.Invalidate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            AffineTransform.Order = 3;
            picMain.Invalidate();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            AffineTransform.Order = 4;
            picMain.Invalidate();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            AffineTransform.Order = 5;
            picMain.Invalidate();
        }
    }
}
