//void -метод, который ничего не возвращает, при его использование не нужен оператор return
void FillArray(int[] collection)  // FillArray - название нашей функции, которая
                                  // заполнит наш массив случайными числами от 1 до 10
                                  //collection - аргумент, который мы назвали
{
    int lenght = collection.Length;     //получаем длинну массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);// на позицию индекс кладем новое
                                                     // случайное число в диапазоне от 0 до 10
        index++;
    }
}
void PrintArray(int[] col) // функция, которая будет печатать наш массив
{
    int count = col.Length; // обозначаем кол-во элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);// будем выводить на экран значение текущего элемента
        position++;
    }
}

//найдем позицию нужного элемента в массиве:
int IndexOf(int[] collection, int find) //в качестве аргумента будет приходить наш массив collection
                                        // и некий аргумент find
{
    int count = collection.Length; // определяем кол-во элементов
    int index = 0;
    int position = -1; // переменная для позиции, если позиция с заданным числом не будет найдена,
                        // то вернет значение "-1" и мы будем понимать, что данного числа нет в массиве.
    while (index < count)
    {
        if (collection[index] == find) // сравниваем элемент массива с заданным числом на совпадение
        {
          position = index;
          break;  //добавляем оператор, что бы искать именно первое число, а потом прервать поиск
        }
            index++;
    }
    return position;
}

int[] array = new int[10]; // создаем новый массив, в котором будет 10 элементов
FillArray(array);
array [4] =4; //принудительно поставили на позиции 4 и 6 цифру - 4
array[6] =4;  //принудительно поставили на позиции 4 и 6 цифру - 4
PrintArray(array);
Console.WriteLine ( ); //выведем пустую строчку
int pos = IndexOf (array,9); // в переменную будет передаваться наш массив
                               // и будем искать, например "9"
Console.WriteLine(pos);