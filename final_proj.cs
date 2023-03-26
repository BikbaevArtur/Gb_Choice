// Написать программу, которая из имеющегося массива строк формирует массивы из строк, длина которых
//меньше или равно 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнение алгоритма

string[] Array(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input array {i}:  ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " , ");
    }
}

int Count(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArray(int size, string[] array)
{
    string[] newarray = new string[size];
    int index = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            newarray[index]=array[i];
            index++;
        }
    }
    return newarray;
}


string[] array = Array(3);
int size = Count(array);
string[] newarray = NewArray(size, array);
ShowArray(array);
Console.WriteLine();
ShowArray(newarray);

