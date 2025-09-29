using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
// Testing 
List<int> list1 = new List<int>() { 2, 2, 3, 4, 5, 6, 7, 7, 7 };
List<int> list2 = new List<int>() { 2, 3, 4, 5, 6, 7 };

// Exercise 1
static int Sum(List<int> incoming)
{
    int sum = 0;
    foreach (int i in incoming) sum += i;
    return sum;
}

static int Max(List<int> incoming)
{
    int max = Int32.MinValue;
    foreach (int i in incoming) if (i > max) max = i;

    return max;
}

static int Min(List<int> incoming)
{
    int min = Int32.MaxValue;
    foreach (int i in incoming) if (i < min) min = i;

    return min;
}

static List<int> FindNegatives(List<int> incoming)
{
    List<int> negativeList = new List<int>();

    foreach (int i in incoming) if (i < 0) negativeList.Add(i);

    return negativeList;
}

List<int> testList = new List<int>() { 1, 4, -9, 5, 5, 0, -4, 2 };
Debug.Assert(Sum(testList) == 4);
Debug.Assert(Max(testList) == 5);
Debug.Assert(Min(testList) == -9);
Debug.Assert(FindNegatives(testList).Count == 2);


//Exercise 2
static void PrintList(List<int> userList)
{

    String v = String.Join(", ", userList);
    Console.WriteLine($"[{v}]");
}

//Exercise 3
static bool TestIdentical(List <int> listA, List<int> listB)
{
    listA.Sort();
    listB.Sort();

    if (listA.Count != listB.Count) return false;
    for (int i = 0; i < listA.Count; i++)
    {
        if (listA[i] != listB[i]) return false;
    }
    return true;
}
Debug.Assert(TestIdentical(list1, list2) == false);

//Exercise 4
static bool CompareLists(List<int> list1, List<int> list2)
{
    List<int> unique1 = new List<int>();
    foreach (int x in list1)
    {
        if (!unique1.Contains(x))
            unique1.Add(x);
    }

    List<int> unique2 = new List<int>();
    foreach (int x in list2)
    {
        if (!unique2.Contains(x))
            unique2.Add(x);
    }

    unique1.Sort();
    unique2.Sort();


    if (unique1.Count != unique2.Count)
        return false;

    for (int i = 0; i < unique1.Count; i++)
    {
        if (unique1[i] != unique2[i])
            return false;
    }

    return true;
}


Debug.Assert(CompareLists(list1, list2) == true); 



// Exercise 5
static bool NaiveSearch(int item, List<int> sortedList)
{
    foreach (int i in sortedList) if (i == item) return true;
    return false;
}

static bool BinarySearch(int item, List<int> sortedList)
{
    int min = 0;
    int max = sortedList.Count() - 1;
    int median = (min + max) / 2;

    while (min <= max)
    {
        if (sortedList[median] == item) return true;
        else if (sortedList[median] < item) min = median + 1;
        else max = median - 1;
    }
    return false;
}

static bool RecursiveSearch(int item, List<int> sortedList, int max, int min)
{
    if (min > max) return false;

    int median = (min + max) / 2;

    if (sortedList[median] == item) return true;
    if (sortedList[median] < item) return RecursiveSearch(item, sortedList, median + 1, max);
    else return RecursiveSearch(item, sortedList, median - 1, min);
}

Debug.Assert(BinarySearch(3, list1) == true);
Debug.Assert(NaiveSearch(1000, list1) == false);
Debug.Assert(RecursiveSearch(4, list1, list1.Count, 0) == true);


//Exercise 6
static List<int> DuplicateList(List<int> userList)
{
    userList.Sort();
    List<int> duplicatedList = new List<int>();

    for (int i = 0; i < userList.Count - 1; i++)
    {
        if (userList[i] == userList[i + 1] && !duplicatedList.Contains(userList[i]))
        {
            duplicatedList.Add(userList[i]);
        }
    }
    return duplicatedList;
}

Debug.Assert(DuplicateList(list1).Count == 2);

//Exercise 7
static bool TestForSubset(List<int> subset, List<int> set)
{
    foreach (int i in subset)
    {
        if (!set.Contains(i)) return false;
    }

    if (subset.Count == set.Count) return false;
    return true;
}
Debug.Assert(TestForSubset(list2, list1) == true);

//Exercise 8
static List<int> ReverseInPlace(List<int> userList)
{
    int left = 0;
    int right = userList.Count - 1;

    while (left < right)
    {
        int x = userList[left];
        userList[left] = userList[right];
        userList[right] = x;

        left++;
        right--;
    }
    return userList;
}
Debug.Assert(ReverseInPlace(list1)[0] == 7);

//Exercise 9
List<int> someList = new List<int>() { 4, 2, 8, 5, 1 };

static List<int> BubbleSort(List<int> userList)
{
    int n = userList.Count;

    for (int p = 0; p < n - 1; p++)
    {
        for (int i = 0; i < n - 1 - p; i++)
        {
            if (userList[i] > userList[i + 1])
            {
                int x = userList[i];
                userList[i] = userList[i + 1];
                userList[i + 1] = x;
            }
        }
    }
    return userList;
}

PrintList(BubbleSort(someList));