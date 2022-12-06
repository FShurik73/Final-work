// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arrayFirst = new string[8] {"123", "23", "hello", "world", "res","final", "rip","6"};
string[] arrayFinal = new string[arrayFirst.Length];
void FinalArray(string[] arrayFirst, string[] arrayFinal )
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arrayFinal [count] = arrayFirst[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FinalArray(arrayFirst, arrayFinal);
PrintArray(arrayFinal);