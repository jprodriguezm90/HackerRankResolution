public static class AppleAndOranges
{
    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        /*var applesIn = 0;
        foreach(var apple in apples){
            if( s <= apple + a && apple + a <= t )
                applesIn++;
        }
        Console.WriteLine(applesIn);
        var orangesIn = 0;
        foreach(var orange in oranges){
            if( s <= orange + b && orange + b <= t )
                orangesIn++;
        }
        Console.WriteLine(orangesIn);
        */
        //Usando LinQ
        int applesIn = apples.Count(apple => (apple + a) >= s && (apple + a) <= t);

        int orangesIn = oranges.Count(orange => (orange + b) >= s && (orange + b) <= t);


        Console.WriteLine(applesIn);
        Console.WriteLine(orangesIn);
    }

    public static void callAppleAndOranges()
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}