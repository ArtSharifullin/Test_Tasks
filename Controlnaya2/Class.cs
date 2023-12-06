using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    public class Matrix
    {
        private int rows = 0;
        private int columns = 0;
        private int[,] matr;

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            matr = new int[rows, columns];
        }

        public Matrix(int size) : this(size, size)
        {
        }

        public Matrix(string filename)
        {
            string[] sentenses = File.ReadAllLines(filename);

            string[] first_sentense = sentenses[0].Split(' ');
            int n = int.Parse(first_sentense[0]);
            int m = int.Parse(first_sentense[1]);
            this.rows = n;
            this.columns = m;
            matr = new int[n, m];

            for (int i = 1; i < n + 1; i++)
            {
                string[] elements = sentenses[i].Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matr[i - 1, j] = int.Parse(elements[j]);
                }
            }
        }

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return columns; }
        }

        public int this[int i, int j]
        {
            get { return matr[i, j]; }
            private set { matr[i, j] = value; }
        }

        public void FillRandom()
        {
            Random r = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matr[i, j] = r.Next(-100, 100);

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    sb.Append($"{matr[i, j],3} ");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        //Само задание вот -

        public Matrix(Matrix a)
        {
            rows = a.Rows; columns = a.Columns;
            matr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j - i - 1 < 0) { matr[i, j] = a[i, (j - i - 1) + columns]; }
                    else { matr[i, j] = a[i, j - i - 1 ]; }
                    
                }
            }
            
        }
    }
}



























































































































