using System;

namespace CShop
{
    class _4_03_Array
    {
        private static void OutputArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);
            Console.WriteLine("배열의 요소 수 : " + arr.Length);
            Console.WriteLine();

        }

        private static void OutputArrayElements(string title, Array arr)
        {
            Console.WriteLine("[" + title + "]");

            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr.GetValue(i) + ", ");
            }

            Console.Write("\n\n");
        }

        public _4_03_Array()
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, false } };
            OutputArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);

            OutputArrayElements("원본 intArray", intArray);
            Array.Sort(intArray);
            OutputArrayElements("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);

            OutputArrayElements("intArray로부터 복사된 copyArray", copyArray);
        }
    }
}
