public static class SaveThePrisoner
{
    /*
     * Complete the 'saveThePrisoner' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     *  3. INTEGER s
     */

    public static int saveThePrisoner(int n, int m, int s)
    {
        var result = 0;
        if(m > n)
        {
            result = ((s - 1) + m) % n;
            if(result == 0)
                result = n;
        }
        else
        {
            result = ((s - 1) + m);
            if (result > n)
                result -= n ;
        }
        return result;
    }
    public static void callSaveThePrisoner()
    {
        
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int s = Convert.ToInt32(firstMultipleInput[2]);

            int result = saveThePrisoner(n, m, s);

            Console.WriteLine(result);
        }
    }
}