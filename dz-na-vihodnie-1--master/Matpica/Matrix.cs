using Matpica;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matpica
{
    internal class Matrix
    {
        int[,] DoubleArray;
        int[,] DoubleArray2;
        int[,] DoubleArray3;
        int n, m, i, j, k, t;
        int z = 0;
        int c = 0;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            DoubleArray = new int[n, m];
            DoubleArray2 = new int[n, m];
            DoubleArray3 = new int[n, m];
        }

  
        public void EnterElements()
        {
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("введите элемент [{0},{1}] :  ", i, j);
                    DoubleArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

  
        public void PrintMatrix()
        {
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(DoubleArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

       
        public void EnterElements2()
        {
            for (k = 0; k < n; k++)
            {
                for (t = 0; t < m; t++)
                {
                    Console.Write("введите элемент [{0},{1}] :  ", k, t);
                    DoubleArray2[k, t] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        
        public void PrintMatrix2()
        {
            for (k = 0; k < n; k++)
            {
                for (t = 0; t < m; t++)
                {
                    Console.Write(DoubleArray2[k, t] + " ");
                }
                Console.WriteLine();
            }
        }
        /*
        
        public void Plus()
        {
            for (z = 0; z < n; z++)
            {
                 for (c = 0; c < m; c++)
                 {
                    DoubleArray3[z, c] = DoubleArray[i, j] + DoubleArray2[k, t];
                 }
            }
        }
        
     
        public void PrintMatrix3()
        {
            for (z = 0; z < n; z++)
            {
                for (c = 0; c < m; c++)
                {
                    Console.Write(DoubleArray3[z, c] + " ");
                }
                Console.WriteLine();
            }
        }
        */
        
        public int Multiply
        {
            set
            {
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        DoubleArray[i, j] *= value;
                    }
                }
            }
        }
        /*
        public void Umn()
        {
            for (i = 0; i < n; i++)
            {
                for (t = 0; t < m; t++)
                {
                   for (k = 0; k < n; k++)
                    {
                        DoubleArray3[z, c] = DoubleArray[i, j] * DoubleArray2[k, t];
                        Console.Write(DoubleArray3[z, c] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }*/
    }
}