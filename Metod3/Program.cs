//Сортировка массива от макс к мин. Находим первый макс, ставим его на первое место и тд.

int[] arr = { 2, 5, 8, 9, 6, 1 ,1,1,2,5,8,9};

void PrintArray(int[] array)  //на этом этапе создаем метода вывода массива на печать
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)// пишем метод, который упорядочит наш массив
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int Maxposition = i;
        for (int j = i+1; j <array.Length; j++)
        {
          if (array[j]> array[Maxposition]) Maxposition = j;
        }
        int temporrary = array [i];        // обмен двух позиций местами
        array [i] = array [Maxposition];
        array [Maxposition] = temporrary;
            }
}
PrintArray(arr);
SelectionSort (arr);
PrintArray(arr);
