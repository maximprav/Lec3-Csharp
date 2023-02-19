// Первая группа методов

// void Method1()
// {
//     Console.WriteLine("Добрый день");
// }

// Как вызывается медот:
// Method1();
// Идентификатор метода + круглые скобки


// Вторая группа методов

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21("Привет", 4);
// Можем явно указывать именование аргумента:
// Method21(msg: "Привет", count: 4);


// Третья группа методов

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Четвертая группа методов

string Method4(int count, string c)
{
     int i = 0;
     string result = " ";

     while(i<count)
     {
        result = result + c;
        count++;
     }
     return result;
}

string ress = Method4(10, "Hello!");

Console.Write(ress);