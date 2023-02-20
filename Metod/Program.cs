// Дан текст, в нем нужно изменит все пробелы на /; к - на К; Г- на г

String text = "Ехал Грека через реку,"
            + " Видит Грека – в реке рак."
            + "Сунул Грека руку в реку, -"
            + "Рак за руку Греку ЦАП !";
// string s = "qwerty"
//             012345
// s [3]  = r
string Replaces(string text, char OldValue, char NewValue)
{
    string result = string.Empty; //инициализация пустой строки
    int length = text.Length;   // для того чтобы получить длинну нашей строки. обращаемся к свойству,
                                //показывающему кол-во символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";// если текущий символ совпал с искомым, то в 
                                                                //результат кладем новое значение
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replaces(text,' ', '/');
Console.WriteLine(NewText);
Console.WriteLine("*************************************************************");
string NewText2 = Replaces(NewText,'к', 'K');
Console.WriteLine(NewText2);
Console.WriteLine("*************************************************************");
string NewText3 = Replaces(NewText2,'Г', 'г');
Console.WriteLine(NewText3);
Console.WriteLine("*************************************************************");