
using System;

namespace SortCode
{
    //排序接口
    public interface ISortInterface
    {
        //示例Demo
        void Demo(int[] a, Action<int[], int> actionSort);
        
        void Demo(int[] a, int dk, Action<int[], int, int> actionSort);

        //打印信息
        void Print(int[] a, int iLenth);

        //直接插入排序
        void StraightInsertSort(int[] a, int n);

        //Shell插入排序
        void ShellInsertSort(int[] a, int n, int dk);
        //简单排序法
        void SimpleSelectionSort(int[] array, int iArrayLen);

        //二元排序法
        void TwoElenSelectSort(int[] array, int iArrayLen);
    }
}