// See https://aka.ms/new-console-template for more information
int Akkerman(int i, int j){
    if (i == 0)
    {
        return j + 1;
    }
    else if (j == 0 && i > 0)
    {
        return Akkerman(i - 1, 1);
    }
    else
    {
        return (Akkerman(i - 1, Akkerman(i, j - 1)));
    }
}

int GetNumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetNumber("Введите ваше число M: ");
int n = GetNumber("Введите ваше число N: ");
Console.Write(Akkerman(m, n));