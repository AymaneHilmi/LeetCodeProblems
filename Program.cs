using LeetCodeProblems.Easy;

foreach (var item in TopKFrequentClass.TopKFrequent([1, 2, 2, 3, 3, 3], 2))
{
    Console.WriteLine(item);
}
Console.WriteLine("///////////////////////////////");

foreach (var item in TopKFrequentClass.TopKFrequent([7, 7], 1))
{
    Console.WriteLine(item);
}

Console.WriteLine("///////////////////////////////");

foreach (var item in TopKFrequentClass.TopKFrequent([7, 4, 6, 6, 6, 7], 2))
{
    Console.WriteLine(item);
}

return;
