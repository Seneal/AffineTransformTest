using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AffineTrans
{
    public class Matrix
    {
        public struct Vector
        {
            public float X;
            public float Y;
            public float Z;
        }


        private float[,] _matrix;

        public float this[int i,int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = value; }
        }

        public Matrix()
        {
            _matrix = new float[3, 3]
            {
                {1,0,0 },
                { 0,1,0},
                { 0,0,1}
            };
        }

        public Matrix(float[,] mat)
        {
            this._matrix = mat;
        }

        public Vector MultiplyVector(Vector v)
        {
            float[,] m = _matrix;
            Vector _v = new Vector();
            _v.X = m[0, 0] * v.X + m[0, 1] * v.Y + m[0, 2] * v.Z;
            _v.Y = m[1, 0] * v.X + m[1, 1] * v.Y + m[1, 2] * v.Z;
            _v.Z = m[2, 0] * v.X + m[2, 1] * v.Y + m[2, 2] * v.Z;
            return _v;
        }

        public Vector MultiplyVector(float x, float y, float z = 1)
        {
            float[,] m = _matrix;
            Vector v = new Vector();
            v.X = m[0, 0] * x + m[0, 1] * y + m[0, 2] * z;
            v.Y = m[1, 0] * x + m[1, 1] * y + m[1, 2] * z;
            v.Z = m[2, 0] * x + m[2, 1] * y + m[2, 2] * z;
            return v;
        }

        static public  Matrix operator*(Matrix left,Matrix right)
        {
            float[,] l = left._matrix;
            float[,] r = right._matrix;

            float[,] m = new float[3, 3];

            m[0, 0] = l[0, 0] * r[0, 0] + l[0, 1] * r[1, 0] + l[0, 2] * r[2, 0];
            m[1, 0] = l[1, 0] * r[0, 0] + l[1, 1] * r[1, 0] + l[1, 2] * r[2, 0];
            m[2, 0] = l[2, 0] * r[0, 0] + l[2, 1] * r[1, 0] + l[2, 2] * r[2, 0];

            m[0, 1] = l[0, 0] * r[0, 1] + l[0, 1] * r[1, 1] + l[0, 2] * r[2, 1];
            m[1, 1] = l[1, 0] * r[0, 1] + l[1, 1] * r[1, 1] + l[1, 2] * r[2, 1];
            m[2, 1] = l[2, 0] * r[0, 1] + l[2, 1] * r[1, 1] + l[2, 2] * r[2, 1];

            m[0, 2] = l[0, 0] * r[0, 2] + l[0, 1] * r[1, 2] + l[0, 2] * r[2, 2];
            m[1, 2] = l[1, 0] * r[0, 2] + l[1, 1] * r[1, 2] + l[1, 2] * r[2, 2];
            m[2, 2] = l[2, 0] * r[0, 2] + l[2, 1] * r[1, 2] + l[2, 2] * r[2, 2];


            return new Matrix(m);
        }


        static public Matrix Identity
        {
            get {
                float[,] mat = new float[3, 3]
                              {
                                    {1,0,0 },
                                    { 0,1,0},
                                    { 0,0,1}
                              };
                return new Matrix(mat );
            }
        }


        static public Matrix Rotate(float degreeAngle)
        {
            float radian =(float)( degreeAngle / 180 * Math.PI);
            float cos =(float) Math.Cos(radian);
            float sin = (float)Math.Sin(radian);

            Matrix mat = Matrix.Identity;
            mat[0, 0] = cos;
            mat[1, 1] = cos;
            mat[0, 1] = sin;
            mat[1, 0] = -sin;

            return mat;
        }

        static public Matrix Offset(float x,float y)
        {
            Matrix mat = Matrix.Identity;
            mat[0, 2] = x;
            mat[1, 2] = y;
            return mat;
        }

        static public Matrix Scale(float x, float y)
        {
            Matrix mat = Matrix.Identity;
            mat[0, 0] = x;
            mat[1, 1] = y;
            return mat;
        }



    }
}
