int[] numbers = {1,5,15,20,7,10,67, 92, 153, 15, 100};

string[] words = {"apple", "banana", "cherry", "date", "elderberry","mum", "amsterdam", "bloom","plane", "ferry", "car", "bike"};

//Task1
System.Console.WriteLine("Numbers	from	range");

var filteredNumber = numbers.Where(n => n > 30 && n < 100).ToList();

var text = (from num in numbers
where num > 30 && num <100
select num).ToList();
foreach (var item in filteredNumber)
{
 // System.Console.WriteLine(item);
}
System.Console.WriteLine();
//task2

System.Console.WriteLine("Minimum	length");

var filteredWords = words.Where(w => w.Length >= 5)
                        .Select(w => w.ToUpper())
                        .ToList();
foreach (var item in filteredWords)
{
//  System.Console.WriteLine(item); 
}

//task3
System.Console.WriteLine();
System.Console.WriteLine("Select	words");
var filteredWordV2 = words.Where(w => w.StartsWith("a") && w.EndsWith("m"))
                        .ToList();

foreach (var item in filteredWordV2)
{
// System.Console.WriteLine(item); 
}
//task4
System.Console.WriteLine();
System.Console.WriteLine("Top	5	numbers");
var top5Numbers = numbers.OrderByDescending(n => n)
                         .Take(5)
                         .ToList();

foreach (var item in top5Numbers)
{
//  System.Console.WriteLine(item);
}
//Task5

System.Console.WriteLine();
System.Console.WriteLine("Square	greater	than	20");
var numberSquares = numbers.Where(n => n * n > 20)
                                .Select(n => new { Number = n, Square = n * n })
                                .ToList();

foreach (var item in numberSquares)
{
//  System.Console.WriteLine(item);
}

//Task6
System.Console.WriteLine();
System.Console.WriteLine("Replace	substring");
string[] wordV2 = {"date", "elderberry","learn", "current", "deal"};

var wordsWithAsterisks = wordV2.Select(w => w.Replace("ea", "*"))
                              .ToList();
foreach (var item in wordsWithAsterisks)
{
//  System.Console.WriteLine(item);
}

// var word = from w in wordV2 

//var replaced= wordV2.select()

 

//task7
System.Console.WriteLine();
System.Console.WriteLine("Last word	containing	letter");
var sortedWordsWithE = words.OrderBy(w => w).Where(w => w.EndsWith("e")).TakeLast(1).ToList();

foreach (var item in sortedWordsWithE)
{
  System.Console.WriteLine(item);
}

//Task8
System.Console.WriteLine();
System.Console.WriteLine("Random");

var rnd = new Random();
var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var shuffledArray = array.OrderBy(i => rnd.Next());
foreach (var item in shuffledArray)
{
 // System.Console.WriteLine(item);
}