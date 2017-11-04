using System;

namespace SortCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[8] { 3, 1, 5, 7, 2, 4, 9, 6 };
            ISortInterface insertSort=new InsertSort();
            insertSort.Demo(a,insertSort.StraightInsertSort);
            insertSort.Demo(a, 1,insertSort.ShellInsertSort);

           
        }
    }
}
