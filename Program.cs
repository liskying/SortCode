using System;

namespace SortCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[9] { 3, 1, 5, 7, 2, 4, 9, 6, 8 };
            ISortInterface insertSort=new InsertSort();

            //Console.WriteLine("直接插入排序法");
            //insertSort.Demo(a,insertSort.StraightInsertSort);

            //Console.WriteLine("Shell插入排序法");
            //insertSort.Demo(a, 1,insertSort.ShellInsertSort);

            //Console.WriteLine("简单选择排序法");
            //insertSort.Demo(a,insertSort.SimpleSelectionSort);

            //Console.WriteLine("二元选择排序法");
            //insertSort.Demo(a,insertSort.TwoElenSelectSort);
            insertSort.CaulMaxSubXulie();
        }
    }
}
