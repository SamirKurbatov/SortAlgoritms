using SortAlgoritms;
using SortAlgoritms.DataStruct;
using System.Security.Cryptography;

//var list = new List<int>() { 22, 2, 3, 4, 5, 11, 6 };

////var bubbleSort = new BubbleSort<int>(list);

////bubbleSort.Sort();

//var insertSort = new InsertSort<int>(list);
//insertSort.Sort();

//Console.WriteLine();

//Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);



//var list = new List<int>() { 22, 2, 3, 4, 5, 11, 6 };

//var sort = new ShellSort<int>(list);

//sort.Sort();


Console.ReadLine();

//var array = new List<int>() { 76, 3, 2, 5, 6,22,11,33,11 };

//var choiceSort = new ChoiceSort<int>();

//choiceSort.Sort();

//Console.ReadLine();


//var array = new int[] { 1, 2, 3, 4 };

//int countPairs = array.Length / 2;

//var writeNumber = 0;
//for (int i = 0; i < countPairs; i++)
//{
//    writeNumber = array[i * 2] + array[i * 2 + 1];
//    Console.WriteLine(writeNumber);
//}


//int[] Merge(int[] a, int[] b)
//{
//    int i = 0, j = 0, k = 0;
//    int[] mergeArray = new int[a.Length + b.Length];

//    while (i < a.Length && j < b.Length)
//    {
//        if (a[i] <= b[j])
//        {
//            mergeArray[k] = a[i];
//            i++;
//        }
//        else
//        {
//            mergeArray[k] = a[j];
//            j++;
//        }
//        k++;
//    }

//    while (i < a.Length)
//    {
//        mergeArray[k] = a[i];
//        i++;
//        k++;
//    }

//    while (j < b.Length)
//    {
//        mergeArray[k] = b[j];
//        j++;
//        k++;
//    }


//    return mergeArray;
//}

//void Merge(int[] nums1, int m, int[] nums2, int n)
//{
//    int i = m - 1;
//    int j = n - 1;
//    int k = m + n - 1;
//    while (i >= 0 && j >= 0)
//    {
//        if (nums1[i] > nums2[j])
//        {
//            nums1[k] = nums1[i];
//            i--;
//        }
//        else
//        {
//            nums1[k] = nums2[j];
//            j--;
//        }
//        k--;
//    }

//    while (j >= 0)
//    {
//        nums1[k] = nums2[j];
//        j--;
//        k--;
//    }
//}

