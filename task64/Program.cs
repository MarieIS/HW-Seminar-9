// See https://aka.ms/new-console-template for more information
string WriteIntNumber(int num){
    if (num == 1){
        return "1";
    }
    else {
        return num.ToString() + ", " + WriteIntNumber(num-1);
    }
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetNumber("Введите ваше число: ");
Console.WriteLine($"N = {N} -> [{WriteIntNumber(N)}]");