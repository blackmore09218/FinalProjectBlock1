void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.WriteLine("Введите элементы строкового массива через пробел: ");
string arrayStr = Console.ReadLine();
string[] array = arrayStr.Split(" ");
string resultArrayStr = "";
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArrayStr = resultArrayStr.Insert(resultArrayStr.Length, array[i]);
        resultArrayStr = resultArrayStr.Insert(resultArrayStr.Length, " ");
    }
}
string[] resultArray = resultArrayStr.Split(" ");
PrintArray(resultArray);