Console.WriteLine("Hello, World!");
Console.WriteLine("Here we will call all the submissions of HackerRank");


//AppleAndOranges.callAppleAndOranges();
//SaveThePrisoner.callSaveThePrisoner();

//ArrayDS.callReverseArray();

_2DArray.callHourglassSum();


public static class _2DArray
{
    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        /* Solution A
        var maxSum = 0;
        //Extraction 
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                //Sum
                var sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                //Max
                if (i == 0 && j == 0)
                    maxSum = sum;
                if(sum > maxSum)
                    maxSum = sum;
            }
        }
        return maxSum;
        */

        return Enumerable.Range(0, arr.Count - 2)
            .SelectMany(i => Enumerable.Range(0, arr[0].Count - 2)
                .Select(j => arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2])
            ).Max();
    }
    

    public static void callHourglassSum()
    {
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);

    }

}