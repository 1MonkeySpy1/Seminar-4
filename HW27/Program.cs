// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

//  452 -> 11
//  82 -> 10
//  9012 -> 12
 int ReadNum(string msg)
 {
     Console.WriteLine(msg);
     return Convert.ToInt32(Console.ReadLine());
 }
 int NumA(int A)
 {
    int count = Convert.ToString(A).Length;
    int next= 0;
    int result = 0;
    for(int i=0; i<count; i++)
    {
        next = A - A%10;
        result = result + (A - next);
        A = A/10;
    }
    return result;
 }
 int N = ReadNum("Введите число");
 int Sum = NumA(N);
 Console.WriteLine($"Сумма = {Sum}");
