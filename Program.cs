string[] Array()
{
    Console.WriteLine("Введите через пробел, по окончании ввода нажмите Enter: ");
    string? Symbols = Console.ReadLine();
    if (Symbols == null) { Symbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArr = Symbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArr;
}
string PrintArray(string[] workArray)
{
    string stringArray = "[";
    for (int i = 0; i < workArray.Length; i++)
    {
        if (i == workArray.Length - 1)
        {
            stringArray += $"\"{workArray[i]}\"";
            break;
        }
        stringArray += ($"\"{workArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}