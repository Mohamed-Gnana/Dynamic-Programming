

static int CoinChange(int[] coins, int amount)
{
    if (amount == 0) return 0;
    int[,] coinGrid = new int[coins.Length + 1, amount + 1];
    for(int i = 0; i < coinGrid.GetLength(0); i++)
    {
        for(int j = 0; j < coinGrid.GetLength(1); j++)
        {
            coinGrid[i, j] = int.MaxValue;
        }
    }
    for(int i = 1; i < coinGrid.GetLength(0); i++)
    {
        int currentCoin = coins[i - 1];
        for(int j = 1; j < coinGrid.GetLength(1); j++)
        {
            if(j == currentCoin)
            {
                coinGrid[i, j] = 1;
            }
            else if(j > currentCoin)
            {
                int coinDiff = j - currentCoin;
                int waysToDoCoinDiff = coinGrid[i, coinDiff];
                if(waysToDoCoinDiff != int.MaxValue)
                {
                    coinGrid[i, j] = Math.Min(coinGrid[i-1, j], waysToDoCoinDiff + 1);
                    continue;
                }
                coinGrid[i, j] = coinGrid[i - 1, j];
            }
            else
            {
                coinGrid[i, j] = coinGrid[i-1, j];
            }
        }
    }
    int minCoins = coinGrid[coins.Length, amount];
    return minCoins == int.MaxValue ? -1 : minCoins;
}

Console.WriteLine(CoinChange(new int[] { 2, 3, 4 }, 31));