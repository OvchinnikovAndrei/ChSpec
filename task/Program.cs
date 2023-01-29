// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

// Например:
// [hello, 2, world, :-)] -> [2, :-)]
// [1234, 1567, -2, computer science] -> [-2]
// [Russia, Denmark, Kazan] -> []


Console.Clear();
Console.Write("Введите количество елементов массива: ");
int elementsCount = int.Parse(Console.ReadLine()!);
string[] array1 = new string[elementsCount];
for (int k = 0; k < array1.Length; k++)
{
    Console.Write($"Введите элемент массива под индексом {k}: ");
    array1[k] = Console.ReadLine()!;
}
Console.Write("Вывод массива: ");
string[] array2 = new string[array1.Length];
ArrayTemp(array1, array2);
PrintArray(array2);
void ArrayTemp(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{ 
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
      if (i != array.Length-1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }    
    Console.Write("]");
    Console.WriteLine();
}