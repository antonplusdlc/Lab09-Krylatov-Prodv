int[] scores = [5, 4, 3, 5, 4];

/*Console.WriteLine($"{scores[0]}\n{scores[scores.Length - 1]}");
scores[2] = 67; // простите
Console.WriteLine(string.Join(", ", scores));

// мы знаем индекс каждого элемента.
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Index {i}: {scores[i]}");
}

foreach (int num in scores)
{
    Console.WriteLine(num);
}*/

int[] numbers = [10, 20, 30];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{numbers[i]} {numbers.Length} {i+1}");
}

// 10 20 30
// i = 3 length = 3
// индекса 3 нет
// <= сменить на <