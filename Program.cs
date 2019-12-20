using System;

namespace Array_Bagian1__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            int[] ArrayInteger = { 1, 3, 4, 7, 8, 10, 12, 14, 18, 20 };
            double[] ArrayDouble = { 1.1, 1.2, 1.3, 2.1, 2.2, 2.3 };
            string[] ArrayString = { "Aku", "Kamu", "Tidak Ada Orang Lain" };

            //Menampilkan Array Dengan Index Yang Dipilih
            Console.WriteLine(ArrayInteger[4]);
            Console.WriteLine(ArrayDouble[3]);
            Console.WriteLine(ArrayString[1]);

            ArrayString[1] = "Dessy Puspita Sari";
            Console.WriteLine(ArrayString[1]);

            ArrayInteger[5] = ArrayInteger[5] + 2;
            Console.WriteLine(ArrayInteger[5]);

            ArrayInteger[7] = ArrayInteger[1] + ArrayInteger[3];
            Console.WriteLine(ArrayInteger[5]);

            Console.WriteLine();

            for (i = 0; i < ArrayInteger.Length; i++) 
            {
                Console.WriteLine("Array Dengan Index ke {0} = {1}", i, ArrayInteger[i]);
            }

            Console.WriteLine();

            for (i = 0; i < ArrayDouble.Length; i++)
            {
                Console.WriteLine("Array Dengan Index ke {0} = {1}", i, ArrayDouble[i]);
            }

            Console.WriteLine();

            for (i = 0; i < ArrayString.Length; i++)
            {
                Console.WriteLine("Array Dengan Index ke {0} = {1}", i, ArrayString[i]);
            }

            Console.WriteLine();

            foreach (int A in ArrayInteger)
            {
                Console.WriteLine(A);
            }

            Console.ReadLine();
        }
    }
}
