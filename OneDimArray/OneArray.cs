using System;

namespace OneDimArray
{
    partial class Program
    {
        class OneArray
        {
            int[] a;
            //  Создание массива и заполнение его числами от first с шагом step 
            public OneArray(int length, int firstElem, int step)
            {
                a = new int[length];
                a[0] = firstElem;
                for (int i = 1; i < length; i++)
                    a[i] = a[i - 1] + step;
            }
            public int Sum
            {
                get 
                { 
                    int sum = 0;
                    for (int i = 1; i<a.Length; i++) 
                        sum += a[i];
                    return sum;
                }
            }
            public void Inverse()
            {
                for (int i = 1; i < a.Length; i++)
                    a[i] = - a[i];
            }
             public void Multi(int num)
            {
                for (int i = 1; i < a.Length; i++)
                    a[i] = a[i] * num;
            }

            public int MaxCount
            {
                get
                {
                    int max = a[0];
                    int maxAmo = 1;
                    for (int i = 1; i < a.Length; i++)
                        if (a[i] > max)
                        {
                            max = a[i];
                            maxAmo = 1;
                        } 
                        else if(a[i]==max)
                        {
                            maxAmo++;
                        }
                    return maxAmo;
                }
            }
            public override string ToString()
            {
                string s = "";
                foreach (int v in a)
                    s = s + v + " ";
                return s;
            }
        }
    }
}
