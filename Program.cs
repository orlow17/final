string[] Array()
{
    Console.WriteLine("Введите через пробел, по окончании ввода нажмите Enter: ");
    string? Symbols = Console.ReadLine();
    if (Symbols == null) { Symbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArr = Symbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArr;
}
string PrintArray (string[] workArr)
{
    string stringArray = "[";
    for (int i = 0; i < workArr.Length; i++)
    {
        if (i == workArr.Length - 1)
        {
            stringArray += $"\"{workArr[i]}\"";
            break;
        }
        stringArray += ($"\"{workArr[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}