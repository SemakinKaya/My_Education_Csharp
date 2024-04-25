string getLetters(string s) 
{ 
    string letters = "";
    foreach(char c in s) 
    {
        if(char.IsLetter(c)) // Изменено на char.IsLetter для поддержки букв из разных алфавитов
        {
            letters += c; // Более компактная запись для добавления символа
        }
    }
    return letters; 
}

string str = Console.ReadLine();
string result = getLetters(str);
Console.WriteLine(result);