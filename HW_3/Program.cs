// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());

int [] arr = new int [elementsCount];

for(int i = 0; i < arr.Length; i++)
{
Console.Write($"Введите элемент массива под индексом {i}: ");
arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
Console.Write('[' + string.Join(", ", arr) + ']');
