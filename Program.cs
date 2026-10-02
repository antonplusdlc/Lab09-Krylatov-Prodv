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

void ChangeFirst(int[] array)
{
    array[0] = 100;
}

int[] da = [14, 88, 69];

Console.WriteLine(string.Join(", ", da));
ChangeFirst(da);
Console.WriteLine(string.Join(", ", da));

void ChangeDa(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * 2;
    }
}

ChangeDa(da);

Console.WriteLine(string.Join(", ", da));

// Массив является ссылочным типом, но при обычной передаче параметра копируется ссылка на тот же массив. Поэтому изменение элементов массива внутри метода видно снаружи.

int[] data = [-5, -2, -9];
int sum = 0;
double srednee;
int max = data[0];
int min = data[0];

foreach (int num in data)
{
    sum += num;
    if (num > max) max = num;
    if (num < min) min = num;
}

/*
- используйте только циклы — готовые `Max()`, `Min()`, `Average()` и LINQ **не применяйте**;

извините а можно было чуть чуть пораньше сказать? :((

Объясните письменно в комментарии: что получилось бы, если бы мы начинали поиск максимума со значения `0`?

max остался бы 0 так как он больше всех остальныъ элементов
*/

srednee = (double)sum / data.Length;

Console.WriteLine($"sum: {sum}\nsrednee: {srednee:F2}\nmax: {max}\nmin: {min}");

Console.WriteLine();
bool isNum;
int numer = 0;

do
{
    Console.Write("Enter int > 0: ");
    isNum = int.TryParse(Console.ReadLine(), out numer);
    if (!isNum || numer <= 0) Console.WriteLine("try again.");
} while (!isNum || numer <= 0);

int[] arrayda = new int[numer];

int da1 = 1;
int da2;

do
{
    Console.Write($"element {da1}: ");
    bool bal = int.TryParse(Console.ReadLine(), out da2);
    if (!bal) Console.WriteLine("NOT INT! TRY AGAIN.");
    else
    {
        arrayda[da1-1] = da2;
        da1++;
    }
} while (da1 != numer+1);

Console.WriteLine(string.Join(", ", arrayda));

Console.WriteLine();

// Итоговая задача

int GetMaxAndMinAndSrednee(int[] array, out int max, out double srednee, int porog, out int mporog)
{
    int min = array[0];
    max = array[0];
    int sum = 0;
    mporog = 0;

    foreach (int num in array)
    {
        if (num > max) max = num;
        if (num < min) min = num;
        sum += num;
        if (num >= porog) mporog += 1;
    }

    srednee = (double)sum / array.Length;

    return min;
}

void PrintResults(int[] array, double sr, int max, int min, int mpor)
{
    Console.WriteLine("Results:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}: {array[i]}");
    }

    Console.WriteLine($"srednee: {sr:F2}\nmax result: {max}\nmin result: {min}\nmporog: {mpor}");
}

bool isRes;
int numerr = 0;

do
{
    Console.Write("Enter results: ");
    isRes = int.TryParse(Console.ReadLine(), out numerr);
    if (!isRes || numerr <= 0) Console.WriteLine("try again.");
} while (!isRes || numerr <= 0);

int[] arraydaa = new int[numerr]; // results

int da11 = 1;
int da21;

do
{
    Console.Write($"result {da11}: ");
    bool bal = int.TryParse(Console.ReadLine(), out da21);
    if (!bal) Console.WriteLine("NOT INT! TRY AGAIN.");
    else
    {
        arraydaa[da11-1] = da21;
        da11++;
    }
} while (da11 != numerr+1);

bool isPorog;
int porog;

do
{
    Console.Write("porog: ");
    isPorog = int.TryParse(Console.ReadLine(), out porog);
    if (!isPorog) Console.WriteLine("try again");
} while (!isPorog);

double sredneee;
int maxx;
int mporog;
int minn = GetMaxAndMinAndSrednee(arraydaa, out maxx, out sredneee, porog, out mporog);

PrintResults(arraydaa, sredneee, maxx, minn, mporog);