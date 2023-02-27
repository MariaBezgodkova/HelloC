// метод, который будет принимать число, факториал, которого надо вычислить
double Factorial(int n) // тип данных указываем double - т.к. могут встретиться большие значения
{
    if (n == 1) return 1; // т.к. 1!=1
    else return n * Factorial(n-1);
}
for (int i = 1;i<40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}