// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить на заглавные, 
// а заглавные "С" заменить на прописные.


string text = "- Я думаю, - сказал князь, улыбаясь, - что";

// string s = "qwerty"
//             012345
// s[3] // r
//                        конкретный символ CHAR
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);