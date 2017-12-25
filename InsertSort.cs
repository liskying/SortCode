using System;

namespace SortCode
{
    //插入排序
    public class InsertSort : ISortInterface
    {
        public InsertSort()
        {
        }

        public void Demo(int[] a, Action<int[], int> actionSort)
        {
            Console.WriteLine("Befor:");
            Print(a, a.Length);

            actionSort(a, a.Length);

            Console.WriteLine("After:");
            Print(a, a.Length);
        }
        public void Demo(int[] a, int dk, Action<int[], int, int> actionSort)
        {
            Console.WriteLine("Befor:");
            Print(a, a.Length);

            actionSort(a, a.Length, dk);

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
                    while (j >= 0 && x < a[j])
                    {
                        a[j + 1] = a[j];
                        j--;
                    }
                    a[j + 1] = x;
                }
                Print(a, n);
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
                    while (j >= 0 && x < a[j])
                    {     //查找在有序表的插入位置  
                        a[j + dk] = a[j];
                        j -= dk;             //元素后移  
                    }
                    a[j + dk] = x;            //插入到正确位置  
                }
                Print(a, n);
            }

        }
        #region 简单排序法
        /**
        简单排序法
         */
        public void SimpleSelectionSort(int[] array, int iArrayLen)
        {
            int key, tmp;
            for (int i = 0; i < iArrayLen; ++i)
            {
                key = SelectMinKey(array, iArrayLen, i);           //选择最小的元素  
                if (key != i)
                {
                    tmp = array[i]; array[i] = array[key]; array[key] = tmp; //最小元素与第i位置元素互换  
                }
                Print(array, iArrayLen);
            }
        }

        /**
        选出最小值索引
         */
        int SelectMinKey(int[] array, int iArrayLen, int iStartSortIndex)
        {
            int iMinSortIndex = iStartSortIndex;
            for (int j = iStartSortIndex + 1; j < iArrayLen; ++j)
            {
                if (array[iMinSortIndex] > array[j]) iMinSortIndex = j;
            }
            return iMinSortIndex;
        }

        #endregion

        #region 二元选择法
        public void TwoElenSelectSort(int[] array, int iArrayLen)
        {
            int i, j, min, max, tmp;
            for (i = 1; i <= iArrayLen / 2; i++)
            {
                // 做不超过n/2趟选择排序   
                min = i; max = i; //分别记录最大和最小关键字记录位置  
                for (j = i + 1; j <= iArrayLen - i; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j; continue;
                    }
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                //该交换操作还可分情况讨论以提高效率 
                Print(array, iArrayLen); 
                tmp = array[i - 1];
                array[i - 1] = array[min];
                array[min] = tmp;
                tmp = array[iArrayLen - i];
                array[iArrayLen - i] = array[max];
                array[max] = tmp;
                Print(array, iArrayLen);

            }
        }
        #endregion
    
        public void CaulMaxSubXulie()
        {
            int  i, j, len;
            int[] a=new int[100];
            int[] b=new int[100];
            var  iLen=6;
            a[0]=3;
            a[1]=10;
            a[2]=5;
            a[3]=15;
            a[4]=6;
            a[5]=8;
            Console.WriteLine("n="+iLen);

            for(i=0;i<iLen;i++) {                  
                Console.WriteLine("a["+i+"]="+a[i]);
            }
            b[0]=1;
            Console.WriteLine("开始");
            for( i=1;i<iLen;i++) {
                Console.WriteLine("第["+i+"]轮");
                Console.WriteLine("a["+i+"]="+a[i]);
                for(j=0,len=0;j<i;j++) {
                    Console.WriteLine("b["+j+"]="+b[j]);
                    if(b[j]<a[i] && len<b[j]) 
                        len=b[j];
                }
                b[j]= len+1;
            }
            Console.WriteLine("结束");
            for(i=0;i<iLen;i++) {                  
                Console.WriteLine("b["+i+"]="+b[i]);
            }
        }
    
    }
}
