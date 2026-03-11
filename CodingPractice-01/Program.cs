using System;

// README.md를 읽고 코드를 작성하세요.

//1
var bob = ("Bob", 23);

Console.WriteLine(bob.Item1);
Console.WriteLine(bob.Item2);

//2-1
var numbers = (12, 34, 56);
Console.WriteLine($"{numbers.Item1}, {numbers.Item2}, {numbers.Item3}");

//2-2
var mixed = ("Hello", 100, true, 3.14);
Console.WriteLine($"{mixed.Item1}, {mixed.Item2}, {mixed.Item3}, {mixed.Item4}");

//3-1
(string, int) person = ("Alice", 25);
Console.WriteLine($"{person.Item1}, {person.Item2}");

//3-2
(ushort Width, ushort Height) resolution = (1920, 1080);
Console.WriteLine($"해상도: {resolution.Width} x {resolution.Height}");

//4
var original = ("Bob", 23);
var copy = original;

copy.Item1 = "Joe";

Console.WriteLine($"원본: {original}");
Console.WriteLine($"복사본: {copy}");

//5
var person2 = (name: "Bob", age: 23);
Console.WriteLine(person2.name);
Console.WriteLine(person2.age);

Console.WriteLine(person2.Item1);
Console.WriteLine(person2.Item2);

//6
var student = (Name: "철수", IsStudent: true, OrderPrice: 1_000);
Console.WriteLine($"{student.Name}(학생: {student.IsStudent}) - 주문: {student.OrderPrice:N0}원");

//7
(string name, int age, char gender) person3 = ("Bob", 23, 'M');
Console.WriteLine($"이름: {person3.name}");
Console.WriteLine($"나이: {person3.age}");
Console.WriteLine($"성별: {person3.gender}");

//8
var now = DateTime.Now;
var dateTuple = (now.Day, now.Month, now.Year);

Console.WriteLine($"일: {dateTuple.Day}");
Console.WriteLine($"월: {dateTuple.Month}");
Console.WriteLine($"년: {dateTuple.Year}");