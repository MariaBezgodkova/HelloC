Console.WriteLine ("Привет, как тебя зовут?");
string username = Console.ReadLine ();

if (username.ToLower () == "маша")
{
    Console.WriteLine ("Привет, дорогая!");
}
else
{
    Console.Write ("Добро пожаловать, ");
    Console.WriteLine (username);
}