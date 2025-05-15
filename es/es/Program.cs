using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(Environment.TickCount);

            int[] arr = new int[100];

            for(int i = 0; i < 100; i++)
            {
                arr[i] = rand.Next(0, 1001);
            }

            WriteLine(stamp(arr));
            selectsort(arr);
            WriteLine(stamp(arr));
            //bubblesort(arr);
            //WriteLine(stamp(arr));
            //insertsort(arr);
            //WriteLine(stamp(arr));
        }

        static void rnd()
        {
        {

            for (int i = 0; i < 100; i++)
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

            for(int i = 0; i < 100; i++)
            {
                rt += arr[i] + ", ";
            }

            return rt;
        }
    }
}