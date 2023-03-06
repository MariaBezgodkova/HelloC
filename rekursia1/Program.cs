// 1 задача Собрать строку с числами от a до b, a ≤ b
//1.1
Console.WriteLine ("Задача 1 - Собрать строку с числами от a до b, a ≤ b");
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(10, 20)); // 1 2 3 4 5 6 7 8 9 10


// используя рекурсию
//1.2
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty; //прописываем условие окончания обязательно
}

Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// 2 Задача Собрать строку с числами от a до b, a ≥ b
Console.WriteLine("2 Задача Собрать строку с числами от a до b, a ≥ b");
//2.1 
string NumbersFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor1(11, 20)); // 20 19 18 17 16 15 14 13 12 11

//2.2 через рекурсию
string NumbersRec1(int a, int b)
{
    if (a <= b) return NumbersRec1(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersRec1(1, 10)); // результат - 10 9 8 7 6 5 4 3 2 1



// 3 задача Сумма чисел от 1 до n
//3.1
Console.WriteLine("3 задача - Сумма чисел от 1 до n");
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
//Console.WriteLine("3 задача - Сумма чисел от 1 до n");
Console.WriteLine(SumFor(12)); // ответ - 78

//3.2 с рекурсией
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10)); // 55

// 4 Задача  Факториал числа
Console.WriteLine("4 Задача Факториал числа");
//4.1
int FactorialFor(int n)
{
 int result = 1;
 for (int i = 1; i <= n; i++) result *= i;
 return result;
}
Console.WriteLine(FactorialFor(8)); // ответ - 40320

//4.2 с рекурсией
int FactorialRec(int n)
{
 if (n == 1) return 1;
 else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10)); // факториал 10 - 3628800


// 5 Задача Вычислить а в степени n
Console.WriteLine("5 задача Вычислить а в степени n");
//5.1
int PowerFor(int a, int n)
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}
Console.WriteLine(PowerFor(2, 5)); // ответ - 32
//5.2 с рекурсией
int PowerRec(int a, int n)
{  if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a; //Можно записать еще так - return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10)); // 1024
//5.3
int PowerRecMath(int a, int n)
{
 if (n == 0) return 1;
 else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
 else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 8)); // 256

//6 задача В некотором машинном алфавите имеются четыре
//буквы «а», «и», «с» и «в». Покажите все слова,
//состоящие из T букв, которые можно построить из букв этого алфавита
Console.WriteLine("6 задача ");
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
 if (length == word.Length)
 {
 Console.WriteLine($"{n++} {new String(word)}"); return;
 }
 for (int i = 0; i < alphabet.Length; i++)
 {
 word[length] = alphabet[i];
 FindWords(alphabet, word, length + 1);
 }
}
FindWords("аисв", new char[2]); // результат будет 4 в 2 степени

// 7 задача Посмотреть содержимое папки
Console.WriteLine("7 задача - Посмотреть содержимое папки ");
void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
//string path = @"C:\Users\Мария\Desktop\EX\EX1";
//CatalogInfo(path);
 
 // 8 задача игра в пирамидки -  за сколько и каких ходов можно
 // переложить всю пирамидку из 3-х блинов (count) с 1 на 3 штырь 

Console.WriteLine("8 задача - Игра в пирамидки -");
 void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}
Towers ();