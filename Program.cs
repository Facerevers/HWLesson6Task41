// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ShowPositiveNumbers(int[] mas)
{
    int j = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0) {j++;}
    }
    return j;
}

int[] CreateMas(int numbers)
{
    int[] mas = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine($"Введите элемент массива {i}: ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mas;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numbers = GetInput("Введите количество элементов массива: ");
int[] mas = CreateMas(numbers);
Console.Write($"Массив: [{String.Join(", " , mas)}]");
Console.Write($" -> {ShowPositiveNumbers(mas)}");