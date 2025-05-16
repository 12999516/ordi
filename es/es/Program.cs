using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];

            rnd(arr);
            WriteLine($"array prima random {stamp(arr)}");
            selectsort(arr);
            WriteLine($"array dopo selection sort {stamp(arr)}");
            rnd(arr);
            WriteLine($"array seconda random {stamp(arr)}");
            bubblesort(arr);
            WriteLine($"array dopo bubble sort {stamp(arr)}");
            rnd(arr);
            WriteLine($"array terza random {stamp(arr)}");
            insertsort(arr);
            WriteLine($"array dopo insertion sort {stamp(arr)}");
        }

        static void swc(ref int a, ref int b)
        {
            int z;
            z = a;
            a = b;
            b = z;
        }

        static void bubblesort(int[] arr)
        {

            int dms = arr.Length;

            for (int j = 0; j < dms - 1; j++)
            {
                for(int i = dms - 1; i < j; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        swc(ref arr[i], ref arr[i - 1]);
                    }
                }
            }
        }

        static void insertsort(int[] arr)
        {
            int n = arr.Length;

            for(int i = 1; i < n; i++)
            {
                int chiave = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > chiave)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = chiave;
            }
        }

        static void rnd(int[] arr)
        {
            Random rand = new Random(Environment.TickCount);
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 1001);
            }
        }

        static void selectsort(int[] arr)
        {
            int cf = 0;

            while (cf < arr.Length - 1)
            {
                int im = cf;

                for (int i = cf + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[im])
                    {
                        im = i;
                    }
                }

                if (im != cf)
                {
                    (arr[cf], arr[im]) = (arr[im], arr[cf]);
                }

                cf++;
            }
        }

        static string stamp(int[] arr)
        {
            string rt = "";

            for (int i = 0; i < arr.Length; i++)
            {
                rt += arr[i] + (i < arr.Length - 1 ? ", " : "");
            }

            return rt;
        }
    }
}
