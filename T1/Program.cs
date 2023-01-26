// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();


Write("Введите числа через запятую: ");

int[] numbers = CountStringsToSum(ReadLine());
PrintArray(numbers);

int sum = 0;


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}


WriteLine($" -> количество введенных значений больше 0: {sum}");


int[] CountStringsToSum(string item)
{
    int count = 1;
    for (int i = 0; i < item.Length; i++)
    {
        if (item[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < item.Length; i++)
    {
        string temporary = "";

        while (item[i] != ',')
        {
            if (i != item.Length - 1)
            {
                temporary = temporary + item[i].ToString();
                i++;
            }
            else
            {
                temporary = temporary + item[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temporary);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
    Write($"{array[array.Length - 1]}]");
}