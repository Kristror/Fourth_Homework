using System;

namespace OneDimArray
{
    partial class Program
    {
        class OneArray
        {
            int[] arr;
            //  Создание массива и заполнение его числами от first с шагом step 
            public OneArray(int length, int firstElem, int step)
            {
                arr = new int[length];
                arr[0] = firstElem;
                for (int i = 1; i < length; i++)
                    arr[i] = arr[i - 1] + step;
            }
            public int Sum
            {
                get 
                { 
                    int sum = 0;
                    for (int i = 0; i<arr.Length; i++) 
                        sum += arr[i];
                    return sum;
                }
            }
            public void Inverse()
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = - arr[i];
            }
             public void Multi(int num)
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = arr[i] * num;
            }

            public int MaxCount
            {
                get
                {
                    int max = arr[0];
                    int maxAmo = 1;
                    for (int i = 1; i < arr.Length; i++)
                        if (arr[i] > max)
                        {
                            max = arr[i];
                            maxAmo = 1;
                        } 
                        else if(arr[i]==max)
                        {
                            maxAmo++;
                        }
                    return maxAmo;
                }
            }
            public override string ToString()
            {
                string str = "";
                foreach (int elem in arr)
                    str += elem + " ";
                return str;
            }
        }
    }
}
