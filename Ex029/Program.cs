// Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

int[] numbers = new int[5];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    { 
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
        Console.Write(array[i] + " ");
     }
}

