

static int LengthOfLIS(int[] nums)
{
    //int[,] numGrid = new int[nums.Length + 1, nums.Length + 1];
    //int maxSequence = 0;
    //for(int i = 1; i < numGrid.GetLength(0); i++)
    //{
    //    int currentNumber = nums[i - 1];
    //    for(int j = 1; j < i; j++)
    //    {
    //        if(currentNumber > nums[j-1])
    //        {
    //            numGrid[i, i] = Math.Max(numGrid[i, i], 1 + numGrid[j, j]);
    //        }
    //        maxSequence = numGrid[i,i] > maxSequence ? numGrid[i,i] : maxSequence;
    //    }
    //}
    //return maxSequence + 1;

    int[,] numGrid = new int[nums.Length+1, nums.Length + 1];
    int maxSequence = 0;
    int[] maxInEveryTurn = new int[nums.Length + 1];
    for (int i = 0; i < nums.Length; i++)
    {
        int actualI = i + 1;
        for (int j = 0; j < i; j++)
        {
            int actualJ = j + 1;
            if(nums[i] < nums[j])
            {
                numGrid[actualI, actualJ] = Math.Max(numGrid[actualI-1, actualJ], numGrid[actualI, actualJ -1]);
            }
            else
            {
                numGrid[actualI, actualJ] = numGrid[actualI, actualJ] + 1;
            }
            maxSequence = numGrid[actualI, actualJ] > maxSequence ? numGrid[actualI, actualJ] : maxSequence;

        }
        maxInEveryTurn[actualI] = maxSequence;
    }
    return maxSequence + 1;
}

Console.WriteLine(LengthOfLIS(new int[] { 4, 10, 4, 3, 8, 9 }));