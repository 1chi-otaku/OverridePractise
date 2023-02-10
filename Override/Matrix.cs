using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class Matrix
    {
        private int[,] matrix;
        public Matrix()
        {
            matrix = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        }
        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public Matrix(int n, int m)
        {
            matrix = new int[n, m];
        }
        public Matrix(int n)
        {
            matrix = new int[n, 1];
           
        }

        public int this[int i, int j]
        {

            get
            {
                if (i < 0 || i >= matrix.GetLength(0))
                    throw new Exception("Invalid index" );
                else if (j < 0 || j >= matrix.GetLength(1))
                    throw new Exception("Invalid index");
                else
                    return matrix[i, j];
            }
            set
            {
                if (i < 0 || i >= matrix.GetLength(0))
                    throw new Exception("Invalid index");
                else if (j < 0 || j >= matrix.GetLength(1))
                    throw new Exception("Invalid index");
                else
                    matrix[i, j] = value;
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Random(int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max);
                }
            }
        }
        public void Input()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter " + (i + 1) + ";" + (j + 1) + " element:");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int Min()
        {
            int min = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        public int Max()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            return max;
        }

        public static Matrix operator +(Matrix op1, Matrix op2)
        {
            if(op1.matrix.Length != op2.matrix.Length)
            {
                throw new ArgumentException("Wrong matrix size");
            }
            Matrix result = new Matrix(op1.matrix.GetLength(0), op1.matrix.GetLength(1));
            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = op1.matrix[i, j] + op2.matrix[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix op1, Matrix op2)
        {
            if (op1.matrix.Length != op2.matrix.Length)
            {
                throw new ArgumentException("Wrong matrix size");
            }
            Matrix result = new Matrix(op1.matrix.GetLength(0), op1.matrix.GetLength(1));
            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = op1.matrix[i, j] - op2.matrix[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix op1, Matrix op2)
        {
            if (op1.matrix.Length != op2.matrix.Length)
            {
                throw new ArgumentException("Wrong matrix size");
            }
            Matrix result = new Matrix(op1.matrix.GetLength(0), op1.matrix.GetLength(1));
            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = op1.matrix[i, j] * op2.matrix[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix op1, int op2)
        {
            for (int i = 0; i < op1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < op1.matrix.GetLength(1); j++)
                {
                    op1.matrix[i, j] *= op2;
                }
            }
            return op1;
        }
        public static bool operator ==(Matrix op1, Matrix op2)
        {
            if (op1.matrix.Length != op2.matrix.Length) return false;

            for (int i = 0; i < op1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < op1.matrix.GetLength(1); j++)
                {
                    if (op1.matrix[i,j] != op2.matrix[i,j]) return false;
                }
            }
            return true;
        }
        public static bool operator !=(Matrix op1, Matrix op2)
        {
            return !(op1 == op2);
        }
    }
}