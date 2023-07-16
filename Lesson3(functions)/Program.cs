// // Вид 1

// void Method1()                         // без аргумегта
// {
//     Console.WriteLine("Автор ...");
// }
// // Method1();                             // вызов метода



// // Вид 2

// void Method2(string msg)
// {
//     Console.Write(msg);
// }
// // Method2("Some Text Message");



// // Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // int Year = Method3();
// // Console.WriteLine(Year);



// // Вид 4

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "z");
// // Console.WriteLine(res);



// // -------------- Цикл FOR   ------------------------------------------------------------------

// // string Method4(int count, string text)
// // {
// //     string result = String.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "z");
// // Console.WriteLine(res);


// // ------------- таблица умножения ------------------------------------------------------------

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// void method1()
// {
//     Console.WriteLine("Juventus");
// }
// method1();

// void Method2(string message)
// {
//     Console.WriteLine(message);
// }

// Method2("Inter Milano");


// void Method2(int message)
// {
//     Console.WriteLine(message);
// }

// Method2(25);

// void Method2(string message, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(message);
//         i++;
//     }
// }
// Method2("Juventus", 10);

// void Method2(string message, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(message);
//         i++;
//     }
// }
// Method2(count: 5, message: "Juventus");

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// int Method3()
// {
//     int i = a;
//     int j = b;
//     int count = i * j;
//     return count;
// }
// int result = Method3();
// Console.WriteLine(result);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string message = string.Empty;

//     while (i < count)
//     {
//         message = message + text;
//         i++;
//     }
//     return message;
// }

// string res = Method4(5, "<Juve>  ");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string message = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         message = message + text;
//     }
//     return message;
// }

// string res = Method4(5, "<Juve>  ");
// Console.WriteLine(res);


// for (int i = 2; i < 10; i++)
// {
//     Console.WriteLine($"Умножение на {i}");
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



// Console.WriteLine("Введите пятизначное число: ");
// string s = Console.ReadLine()!;

// if (s[0] == s[4])

//     if (s[1] == s[3])
//     {
//         Console.WriteLine(s + " - это палиндром");
//     }
//     else
//     {
//         Console.WriteLine(s + " - нет, это не палиндром");
//     }
// else
// {
//     Console.WriteLine(s + " - нет, это не палиндром");
// }

// Console.WriteLine("Задача 19");
// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"Ваше число: {number} - палиндром.");
//     }
//     else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5)
// {
//     CheckingNumber(number);
// }
// else 
// {
//     Console.WriteLine($"Введи правильное число");
// }

// string text = "Несколько месяцев назад скачал от нечего делать с торрентов архив прессы. Распаковал его и ткнул в произвольную статью. Этой статьей оказалась заметка от середины июля 2004 о пропаже питерского журналиста Максима Максимова. И что-то у меня в памяти вспыхнуло от сочетания этого имени и фамилии, набрал запрос в яндексе и по фотке сразу же узнал его.";

// string s = "qwerty"
//             0123
// s[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; // инициализация пустой строки

//     int length = text.Length; // покажет колличество символов в строке 
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue)
//         {
//             result = result + $"{newValue}";
//         }
//         else
//         {
//             result = result + $"{text[i]}";
//         }
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);



// int[] arr = { 1, 5, 2, 8, 3, 1, 3, 9, 5, 4, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

int[] arr = { 1, 5, 2, 8, 3, 1, 3, 9, 5, 4, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);