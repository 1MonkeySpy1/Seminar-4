// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int ReadNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int AnB(int A, int B) 
{
    int sum = 1;
    for(int i =1; i<=B; i++)
    {
        sum = sum*A;
    }
    return sum;
}
int Na =ReadNum("Введите число A");
int Nb =ReadNum("Введите число B");
int result = AnB(Na, Nb);
Console.WriteLine(result);