using System;

namespace SortCode
{
    //插入排序
    public class InsertSort : ISortInterface
    {
        public InsertSort()
        {
        }

        public void Demo(int[] a,Action<int[],int> actionSort)
        {
            Console.WriteLine("Befor:");
            Print(a, a.Length);

            actionSort(a, a.Length);

            Console.WriteLine("After:");
            Print(a, a.Length);
        }
        public void Demo(int[] a,int dk, Action<int[], int,int> actionSort)
        {
            Console.WriteLine("Befor:");
            Print(a, a.Length);

            actionSort(a, a.Length,dk);

            Console.WriteLine("After:");
            Print(a, a.Length);
        }

        public void Print(int[] a, int iLenth)
        {
            string msg = "";
            for (var i = 0; i < iLenth; i++)
            {
                msg += a[i] + " ";
            }
            Console.WriteLine(msg);


        }

        public void StraightInsertSort(int[] a, int n)
        {

            for (int i = 1; i < n; i++)
            {
                if (a[i] < a[i - 1])
                {
                    int j = i - 1;
                    int x = a[i];
                    a[i] = a[i - 1];
                    while (j>=0 && x < a[j])
                    {
                        a[j + 1] = a[j];
                        j--;
                    }
                    a[j + 1] = x;
                }
                Print(a,  n);
            }

        }


       public void ShellInsertSort(int[] a, int n, int dk)
        {
            for (int i = dk; i < n; ++i)
            {
                if (a[i] < a[i - dk])
                {          //若第i个元素大于i-1元素，直接插入。小于的话，移动有序表后插入  
                    int j = i - dk;
                    int x = a[i];           //复制为哨兵，即存储待排序元素  
                    a[i] = a[i - dk];         //首先后移一个元素  
                    while (x < a[j])
                    {     //查找在有序表的插入位置  
                        a[j + dk] = a[j];
                        j -= dk;             //元素后移  
                    }
                    a[j + dk] = x;            //插入到正确位置  
                }
                Print(a, n);
            }

        }
    }
}
