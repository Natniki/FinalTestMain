/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
*/

void ChechArray(string[] array, string[] resultArray){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        resultArray[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[5] {"123", "23", "hello", "world", "res"};
string[] resultArray = new string[array.Length];
ChechArray(array, resultArray);
PrintArray(resultArray);


