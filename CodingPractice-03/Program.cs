using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

//1
var t1 = ("one", 1);
var t2 = ("one", 1);
var t3 = ("two", 2);

Console.WriteLine(t1.Equals(t2));
Console.WriteLine(t1.Equals(t3));

//2
var t4 = ("one", 1);
var t5 = ("one", 1);

Console.WriteLine(t1 == t4);
Console.WriteLine(t1 != t5);

//3
(string name, int age) person1 = ("Alice", 25);
(string x, int y) person2 = person1;

Console.WriteLine($"{person2.x}, {person2.y}");

//4
(string name, int age, char sex) bob1 = ("Bob", 23, 'M');
(string age, int sex, char name) bob2 = bob1;

Console.WriteLine(bob2.age);
Console.WriteLine(bob2.sex);
Console.WriteLine(bob2.name);

//5
List<(string name, int age)> people = new()
{
    ("Alice", 25),
    ("Bob", 30),
    ("Charlie", 35)
};

foreach (var person in people)
{
    Console.WriteLine($"{person.name}: {person.age}세");
}

//6
Dictionary<(int x, int y), string> grid = new()
{
    { (0, 0), "원점" },
    { (1, 0), "오른쪽" },
    { (0, 1), "위" }
};

Console.WriteLine(grid[(0, 0)]);
Console.WriteLine(grid[(1, 0)]);

//7
var tuple1 = new Tuple<string, int>("Bob", 23);
Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");

var tuple2 = Tuple.Create("Alice", 25);
Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}");