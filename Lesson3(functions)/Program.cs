// Вид 1

void Method1()                         // без аргумегта
{
    Console.WriteLine("Автор ...");
}
// Method1();                             // вызов метода



// Вид 2

void Method2(string msg)
{
    Console.Write(msg);
}
// Method2("Some Text Message");



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
// int Year = Method3();
// Console.WriteLine(Year);



// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



// -------------- Цикл FOR   ------------------------------------------------------------------

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


// ------------- таблица умножения ------------------------------------------------------------

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}