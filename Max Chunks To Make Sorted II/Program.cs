 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
  

// 30 20 50 10 80 90 70 100 60


//https://www.youtube.com/watch?v=GxTo3agdnjs
public class Solution
{
  public int MaxChunksToSorted(int[] arr)
  {
    // 1 2 3 4 5 6
    // at any index if we partition the array then left partition max would be always smaller than right partition min
    // 1 2 3 split 4 5 6, here 3 is max from left and 4 is min from right and 3 < 4
    // will use this approach to solve this problem

    var leftMax = new int[arr.Length];
    var rightMin = new int[arr.Length];

    leftMax[0] = arr[0];
    for (int i = 1; i < leftMax.Length; i++)
    {
      leftMax[i] = Math.Max(leftMax[i - 1], arr[i]);
    }

    rightMin[rightMin.Length - 1] = arr[arr.Length - 1];
    for (int i = rightMin.Length - 2; i >= 0; i--)
    {
      rightMin[i] = Math.Min(rightMin[i + 1], arr[i]);
    }


    int count = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
      if (leftMax[i] <= rightMin[i + 1]) count++;
    }

    return count + 1;

  }
}
