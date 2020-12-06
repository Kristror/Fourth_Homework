using System;
using System.IO;

namespace TwoDimArray
{
    class TwoArray
    {
        int[,] arr;

        public TwoArray(int rows, int colls, bool exist)
        {
            arr = new int[rows, colls];
            if (!exist)
            {
                Random rnd = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colls; j++)
                    {
                        arr[i, j] = rnd.Next(100);
                    }
                }
            }
        }
        public int Max
        {
            get
            {
                int max = arr[0,0];

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > max) max = arr[i, j];
                    }
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = arr[0, 0]; 
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < min) min = arr[i, j];
                    }
                }
                return min;
            }
        }
        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summ += arr[i, j];
                }
            }
            return summ;
        }
        public int Summ(int num)
        {
            int summ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   if(arr[i,j]>num) summ += arr[i, j];
                }
            }
            return summ;
        }

        public void Save(string path)
        {
            StreamWriter sr = new StreamWriter(path,false);
            sr.WriteLine($"{arr.GetLength(0)} {arr.GetLength(0)}");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sr.Write($"{arr[i, j]} ");
                }
                sr.WriteLine();
            }
            sr.Close();
        }

        public static bool Load(ref TwoArray array, string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string[] str = sr.ReadLine().Split(' ');
                array = new TwoArray(Int32.Parse(str[0]), Int32.Parse(str[1]), true);
                int i = 0;
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine().Split(' ');
                    for(int j  = 0; j < str.Length-1
                        ; j++)
                    {
                        array.arr[i,j] = Int32.Parse(str[j]);
                    }
                    i++;
                }
                sr.Close();
                return true;
            }
            else return false;
        }

        public void MaxPos(ref int row,ref int col)
        {
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}