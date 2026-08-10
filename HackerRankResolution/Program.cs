Console.WriteLine("Hello, World!");
Console.WriteLine("Here we will call all the submissions of HackerRank");


//AppleAndOranges.callAppleAndOranges();
//SaveThePrisoner.callSaveThePrisoner();

//ArrayDS.callReverseArray();

//_2DArray.callHourglassSum();

IEnumerable<int> numbers = Enumerable.Range(1, 5);

var query = numbers.Where(n => n % 2 == 0);

numbers = Enumerable.Range(1, 10);

foreach (var n in query)
{
    Console.WriteLine(n);
}
Console.WriteLine("------");
int limit = 5;

var query2 = Enumerable.Range(1, 10)
    .Where(n => n <= limit);

foreach (var n in query2)
{
    Console.WriteLine(n);
}

limit = 8;

foreach (var n in query2)
{
    Console.WriteLine(n);
}