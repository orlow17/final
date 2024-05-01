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
int StringSymbols(string[] workArr)
{
    int counter = 0;
    foreach (string item in workArr)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
string[] NewArray(string[] workArr)
{
    int resultArray = StringSymbols(workArr);
    string[] resultArr = new string[resultArray];
    int i = 0;
    foreach (string item in workArr)
    {
        if (item.Length <= 3)
        {
            resultArr[i] = item;
            i++;
        }
    }
    return resultArr;
}


string[] workArr = Array();
string[] resultArray = NewArray(workArr);
string firstArray = PrintArray(workArr);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);