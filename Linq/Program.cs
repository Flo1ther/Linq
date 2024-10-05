using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Task 1

List<int> numbers = Enumerable.Range(1, 20).ToList();

var evenNumbers = numbers.Where(n => n % 2 == 0);

Console.WriteLine("Парні числа від 1 до 20:");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

// Task 2

string[] fruits = { "Яблуко", "Банан", "Ананас", "Груша", "Апельсин", "Ківі", "Манго" };

var sortedFruits = fruits.OrderBy(fruit => fruit);

Console.WriteLine("Фрукти у алфавітному порядку:");
foreach (var fruit in sortedFruits)
{
    Console.WriteLine(fruit);
}

// Task 3

List<string> words = new List<string>
        {
            "яблуко",
            "банан",
            "ананас",
            "груша",
            "апельсин",
            "ківі",
            "манго",
            "черешня"
        };

int count = words.Count(word => word.Length > 5);

Console.WriteLine($"Кількість рядків з більше ніж 5 символами: {count}");

// Task 4

string[] words4 = { "яблуко", "банан", "груша", "ківі", "ананас", "апельсин", "манго", "вишня" };

var groupedByLength = words.GroupBy(word => word.Length);

foreach (var group in groupedByLength)
{
    Console.WriteLine($"Довжина {group.Key}:");
    foreach (var word in group)
    {
        Console.WriteLine($"  {word}");
    }
}

// Task 5

List<int> numbers5 = new List<int> { 5, 12, 18, 3, 25, 7, 15, 30 };

int sum = numbers.Where(n => n > 10).Sum();

Console.WriteLine($"Сума всіх чисел більших за 10: {sum}");