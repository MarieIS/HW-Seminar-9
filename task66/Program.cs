// See https://aka.ms/new-console-template for more information
int CalcSum(int num1, int num2){
  if (num1 > num2){
     return 0;
  }
  else{
    return num1 + CalcSum(num1+1, num2);
}
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int M = GetNumber("Введите ваше число M: ");
int N = GetNumber("Введите ваше число N: ");
int min = 0;
int max = 0;
if (N > M){
    min = M;
    max = N;
}
else{
    min = N;
    max = M;
}

int sum = CalcSum(min, max);
Console.WriteLine($"M = {M}, N = {N} -> {sum}");