

static int ClimbStaris(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 2;
    int[] stepsGrid = new int[n];
    stepsGrid[0] = 1;
    stepsGrid[1] = 2;
    for(int i = 2 ; i < n; i++)
    {
        stepsGrid[i] = stepsGrid[i - 1] + stepsGrid[i - 2];
    }
    return stepsGrid[n-1];
}

Console.WriteLine(ClimbStaris(5));