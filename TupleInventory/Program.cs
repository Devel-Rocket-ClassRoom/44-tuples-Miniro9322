using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

List<(string name, int quantity, int price)> inventory = new List<(string name, int quantity, int price)>();

AddItem(inventory, "체력 포션", 3, 500);
AddItem(inventory, "마나 포션", 5, 800);
AddItem(inventory, "해독제", 2, 300);
AddItem(inventory, "엘릭서", 1, 5000);

Console.WriteLine("=== 아이템 인벤토리 ===");
foreach(var item in inventory)
{
    Console.WriteLine($"{item.name} - 수량: {item.quantity}개, 단가: {item.price:n0}원");
}

Console.WriteLine("\n=== 가장 비싼 아이템 ===");
(string name, int price) = FindMostExpensive(inventory);
Console.WriteLine($"이름: {name}, 단가: {price:n0}원");

Console.WriteLine("\n=== 인벤토리 합산 ===");
(int totalValue, int totalCount) = CalculateTotal(inventory);
Console.WriteLine($"총 가치: {totalValue:n0}\n총 아이템 수: {totalCount}개");


void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    inventory.Add((name, quantity, price));
}

(string name, int price) FindMostExpensive(List<(string name, int quantity, int price)> inventory)
{
    int max = int.MinValue;
    string name = string.Empty;

    foreach(var item in inventory)
    {
        if(item.price > max)
        {
            max = item.price;
            name = item.name;
        }
    }

    return (name, max);
}

(int totalValue, int totalCount) CalculateTotal(List<(string name, int quantity, int price)> inventory)
{
    int totalValue = 0;
    int totalCount = 0;

    foreach(var item in inventory)
    {
        totalValue += item.quantity * item.price;
        totalCount += item.quantity;
    }

    return (totalValue, totalCount);
}