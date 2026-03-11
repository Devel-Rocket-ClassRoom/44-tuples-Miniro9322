using System;

// README.md를 읽고 코드를 작성하세요.

//1
var t = Tally();
Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");

static (int, int) Tally()
{
    var result = (12, 3);
    return result;
}

//2
var result = Calculate();
Console.WriteLine($"합계: {result.Sum}, 개수: {result.Count}");

static (int Sum, int Count) Calculate()
{
    return (45, 6);
}

//3
var pair = GetPair();
Console.WriteLine($"{pair.first}, {pair.second}");

static (int first, int second) GetPair() => (100, 200);

//4
int[] data = { 5, 2, 8, 1, 9, 3 };
var result2 = FindMinMax(data);
Console.WriteLine($"최솟값: {result2.min}, 최댓값: {result2.max}");

static (int min, int max) FindMinMax(int[] numbers)
{
    int min = numbers[0];
    int max = numbers[0];

    foreach (int num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
        if (num > max)
        {
            max = num;
        }
    }

    return (min, max);
}

//5
var zeros = ZeroZero();
Console.WriteLine($"{zeros.Item1}, {zeros.Item2}");

static (int, int) ZeroZero() => default;

//6
var bob = ("Bob", 23);

(string name, int age) = bob;

Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");

//7
var (sum, count) = Tally2();
Console.WriteLine($"Sum: {sum}, Count: {count}");

static (int Sum, int Count) Tally2() => (12, 3);

//8
string firstName = "";
int userAge = 0;

var person = ("Alice", 30);

(firstName, userAge) = person;

Console.WriteLine($"{firstName}, {userAge}");

//9
var (_, age2, _) = GetPerson();
Console.WriteLine($"나이: {age2}");

static (string name, int age, char gender) GetPerson() => ("Bob", 23, 'M');