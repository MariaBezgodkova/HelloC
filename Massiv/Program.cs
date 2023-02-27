//пример задания массива из строк
string[,] table = new string[2, 5];// задали массив из 2 строк и 5 столбцов
// String.Empty - инициализация для строк происходит такой константой
//table [0,0]   table [0,1]    table [0,2]   table [0,3]  table [0,4]
//table [1,0]   table [1,1]    table [1,2]   table [1,3]  table [1,4]
table[1, 2] = "слово";
 for (int rows = 0; rows < 2; rows ++)  // цикл по строкам
 {
  for (int colums = 0; colums < 5; colums ++)  // цикл по столбцам
{
Console.WriteLine($"-{table[rows,colums]}-");

}
}

// пример задания массива из цифр

void PrintArray(int[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)// метод для заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - возвращает кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - возвращает кол-во столбцов
        {
            matr[i, j] = new Random().Next(1, 10);// [1,10)- полуинтервал,т.е. 10- не войдет
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("**********");
PrintArray(matrix);
