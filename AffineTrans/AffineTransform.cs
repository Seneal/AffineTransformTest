using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AffineTrans
{
    public class AffineTransform
    {

        public float RotateDegree;
        public float OffsetX, OffsetY;
        public float ScaleX = 1, ScaleY = 1;

        public int Order;


        public Matrix.Vector Transform(PointF src)
        {
            Matrix rotateMat = Matrix.Rotate(RotateDegree);
            Matrix offsetMat = Matrix.Offset(OffsetX, OffsetY);
            Matrix scaleMat = Matrix.Scale(ScaleX, ScaleY);

            Matrix mat;
            //! 2018.5.31 算法
            //mat = offsetMat * (rotateMat * scaleMat);
            //! 这个应该是对的
            //mat = rotateMat *  (offsetMat * scaleMat);
            switch(Order)
            {
                case 0:
                    mat = rotateMat * offsetMat;
                    mat = mat * scaleMat;
                    break;
                case 1: mat = rotateMat * scaleMat * offsetMat ; break;
                case 2: mat = offsetMat * rotateMat * scaleMat; break;
                case 3: mat = offsetMat * scaleMat * rotateMat; break;
                case 4: mat = scaleMat * rotateMat * offsetMat; break;
                case 5: mat = scaleMat * offsetMat * rotateMat; break;
                default:mat = rotateMat * (offsetMat * scaleMat);break;
            }
            return  mat.MultiplyVector(src.X, src.Y);
        }
    }
}
