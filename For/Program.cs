// Цикл "for"

// string Method4(int count, string c)
// {
//     string result = string.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }

// string ress = Method4(10, "Hello!");

// Console.Write(ress);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}