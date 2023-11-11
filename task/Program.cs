/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
*/

class Program
{
    static void Main(string[] args)
    {
        string[] inputArray = new string[] { "Hello", "2", "world", ":-)" };
        int count = 0;

        if (inputArray != null) // Проверка на null для inputArray
        {
            foreach (string str in inputArray)
            {
                if (str != null) // Проверка на null для str
                {
                    if (str.Length <= 3)
                    {
                        count++;
                    }
                }
            }
        }

        string[] resultArray = new string[count];
        int currentIndex = 0;

        if (inputArray != null)
        {
            foreach (string str in inputArray)
            {
                if (str != null)
                {
                    if (str.Length <= 3)
                    {
                        resultArray[currentIndex] = str;
                        currentIndex++;
                    }
                }
            }
        }

        Console.WriteLine("Result Array: [" + string.Join(", ", resultArray) + "]");
    }
}


