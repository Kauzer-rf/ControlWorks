/*
Написать прогрмаму, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше либо равна 3м символам. 
Первоначальный массив можно ввести с клавиатуру, либо задать на старте выполения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.

Примеры:
["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer sciense"] -> ["-2"]
["Russia","Denmark","Kazan"] -> []
*/
Console.Write("\nВведите строки первого массива через пробел: ");
string[] array = Console.ReadLine().Split();
Console.WriteLine("\nИзначальный массив: [{0}", String.Join(", ", array) + "]");

Console.Write("\nВведите количество символов, по которому будет фильтроваться исходный массив: ");
int maxLength = int.Parse(Console.ReadLine());

var SortedArray = array.Where(x => x.Length <= maxLength).ToArray();
Console.WriteLine("\nПолученный массив: [{0}", String.Join(", ", SortedArray) + "]");