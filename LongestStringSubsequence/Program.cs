

static int LongestCommonSubsequent(string text1, string text2)
{
    int[,] strGrid = new int[text1.Length + 1, text2.Length + 1];
    int longestSubsequence = 0;
    for(int i = 1; i < strGrid.GetLength(0); i++)
    {
        int iBaseZero = i - 1;
        for(int j = 1; j < strGrid.GetLength(1); j++)
        {
            int jBaseZero = j - 1;
            if(text2[jBaseZero] != text1[iBaseZero])
            {
                strGrid[i, j] = Math.Max(strGrid[i-1, j], strGrid[i, j-1]);
            }
            else
            {
                strGrid[i, j] = strGrid[i - 1, j - 1] + 1;
            }
            longestSubsequence = strGrid[i, j] > longestSubsequence ? strGrid[i, j] : longestSubsequence;
        }
    }
    return longestSubsequence;
}
string text1 = "abcde", text2 = "ace";

Console.WriteLine(LongestCommonSubsequent(text1, text2));