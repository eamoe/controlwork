/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] --> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] --> ["-2"]
["Russia", "Denmark", "Kazan"] --> []*/

void NextElementMessage(int number)
{
    Console.Write($"Введите {number}-й элемент: ");
}

string GetNextElement()
{
    return Console.ReadLine();
}

string[] InputArray()
{ 
    int i = 0;

    string[] input = new string[1];
    
    bool getNext = true;

    do
    {
        NextElementMessage(i + 1);

        string NextElement = GetNextElement();
    
        if(NextElement == "")
        {
            getNext = false;
        }
        else
        {
            Array.Resize(ref input, i + 1);
            input[i] = NextElement;
        }

        i = i + 1;
    }
    while(getNext);

    return input;
}

int getSize(string[] input, int elementLength)
{
    int size = 0;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= elementLength)
        {
            size++;
        }
    }

    return size;
}

string[] FillOutputArray(string[] input, int elementLength)
{
    string[] output = new string[getSize(input, elementLength)];

    int j = 0;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= elementLength)
        {
            output[j] = input[i];
            j = j + 1;
        }
    }

    return output;
}

Console.WriteLine("Введите исходный массив строк поэлементно. Для выхода оставьте строку ввода пустой и нажмите 'Enter'.");
string[] inputArray = InputArray();
Console.WriteLine("Ввод завершен!");

int maxElementLength = 3;
string[] outputArray = FillOutputArray(inputArray, maxElementLength);

for(int i = 0; i < outputArray.Length; i++)
{
    Console.WriteLine($"{outputArray[i]}");
}