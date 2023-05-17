

using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class MaTranVuong {
    int n { get; set; }
    public double[, ] data = new double[10, 10];
    
    public double this[int i, int j]
    {
        get
        {
            return data[i, j];
        }
        set {
            data[i, j] = value; 
        }
    }
    public static MaTranVuong operator +(MaTranVuong a, MaTranVuong b) {
        MaTranVuong result = new MaTranVuong();
        for (int i = 0; i < a.n; i++) {
            for (int j = 0; j < a.n; j++) {
                result[i, j] = (a[i, j] + b[i, j]); 
            }
        }
        return result;
    }

    public static MaTranVuong operator -(MaTranVuong a, MaTranVuong b)
    {
        MaTranVuong result = new MaTranVuong();
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                result[i, j] = (a[i, j] - b[i, j]);
            }
        }
        return result;
    }
    public static MaTranVuong operator *(MaTranVuong a, MaTranVuong b)
    {
        MaTranVuong result = new MaTranVuong();
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                for (int k = 0; k < a.n; k++) {
                    result[i, j] += (a[i, k] + b[k , j]);
                }
            }
        }
        return result;
    }

    public static MaTranVuong operator /(MaTranVuong a, MaTranVuong b)
    {
        MaTranVuong result = new MaTranVuong();
        var bcv = new double[10, 10];
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                bcv[j, i] = b[i, j];
            }
        }
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                for (int k = 0; k < a.n; k++)
                {
                    result[i, j] += (a[i, k] + (1 / (double) b) * bcv[k, j]) ;
                }
            }
        }
        return result;
    }

    public static implicit operator double(MaTranVuong a)
    {
        var matrix = a.data;
        int n = (int)Math.Sqrt(matrix.Length); 

        double det = 1;

        for (int i = 0; i < n; i++)
        {
            int max = i;

            for (int j = i + 1; j < n; j++)
            {
                if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[max, i]))
                {
                    max = j;
                }
            }

            if (i != max)
            {
                for (int j = 0; j < n; j++)
                {
                    double temp = matrix[i, j];
                    matrix[i, j] = matrix[max, j];
                    matrix[max, j] = temp;
                }

                det *= -1;
            }

            if (matrix[i, i] != 1)
            {
                double div = matrix[i, i];
                for (int j = i; j < n; j++)
                {
                    matrix[i, j] /= div;
                }

                det *= div;
            }

            for (int j = i + 1; j < n; j++)
            {
                double mul = matrix[j, i];
                for (int k = i; k < n; k++)
                {
                    matrix[j, k] -= mul * matrix[i, k];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            det *= matrix[i, i];
        }

        return det;
       
    }
    public static void cls(MaTranVuong a) {
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                Console.Write($"{a.data[i, j]} ");
            }
            Console.WriteLine("\n");
        }
    }

    public static void Main(string[] args) { 
        MaTranVuong maTranVuong = new MaTranVuong();
        maTranVuong.n = 2;
        maTranVuong.data = new double[2, 2] { {1, 2 }, { 3, 4} };
        MaTranVuong maTranVuong1 = new MaTranVuong();
        maTranVuong1.n = 2;
        maTranVuong1.data = new double[2, 2] { { 5, 6 }, { 7, 8 } };
        MaTranVuong result = maTranVuong + maTranVuong1;
        Console.WriteLine((double) maTranVuong);
    }

}