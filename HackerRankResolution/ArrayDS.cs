public static class ArrayDS
{
    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> reverseArray(List<int> a)
    {
        /* Solution A
        a.Reverse();
        return a;
        */

        /* Solution B
        List<int> b = new List<int>();
        foreach (var item in a)
        {
            b.Insert(0,item);
        }
        return b;
        */

        /* Solution C
         * 
         */
        return Enumerable.Range(0, a.Count).Select(i => a[a.Count - 1 - i]).ToList();
    

        
    }

    public static void callReverseArray()
    {

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> res = reverseArray(arr);

        Console.WriteLine(String.Join(" ", res));

    }
}