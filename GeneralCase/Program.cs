//Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 
// number символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int PromptInt(string message) //функция ввода целочисленного значения типа int 
//с последующей конвертацией
{
    Console.Write(message);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

string PromptString(string message)//функция ввода значения типа string 
{
    Console.Write(message);
    string temp = Console.ReadLine();
    return temp;
}

bool ValidateNumber(int number) // проверка введенного числа на соответствие заданному интервалу
{
    if (number <= 0)
    {
        System.Console.WriteLine("Введите число больше нуля");
        return false;
    }
    return true;
}

void PrintArray(string[] array)//функция вывода одномерного массива
//элементы выводятся через запятую, заключены в квадратные скобки
{
    System.Console.Write($"->[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}

string[] MyStringArray(int size)//заполнение одномерного массива 
//данными типа string из консоли
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = PromptString($"Введите {i + 1}-й элемент: ");
    }
    return result;
}

void SelectStringArray(string[] matrix,int number)
//выбирает и выводит на печать 
//из строкового массива элементы меньше либо равно number
    {
        string[] tempArray = new string[matrix.Length];
        int k = 0;
        for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= number)
        {
            tempArray[k] = matrix[i];
            k++;
        }
    }
    if (k == 0)
    {
        Console.WriteLine("->[]");
    }
    else
    {
        string[] threeSymbolsArray = new string[k];
        for (int j = 0; j < k; j++)
        {
            threeSymbolsArray[j] = tempArray[j];
        }
        Console.WriteLine();
        PrintArray(threeSymbolsArray);
    }
}

System.Console.WriteLine("Задайте кол-во эл-тов массива, ");
int size = PromptInt("который планируете ввести: ");
System.Console.WriteLine("Введите до какого кол-ва символов включая ");
int number = PromptInt("нужно выбрать элементы из массива: ");
if (ValidateNumber(size))
{
    string[] array = MyStringArray(size);
    SelectStringArray(array, number);
}