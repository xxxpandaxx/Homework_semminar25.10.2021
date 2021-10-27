//Используя материалы со второй лекции я сделал программу по нахождению
// минимального и максимального числа.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int Min(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    return result;
}

int a1 = 21;
int b1 = 123;
int c1 = 1234;
int a2 = 123;
int b2 = 512131;
int c2 = 12;
int a3 = 122133;
int b3 = 44;
int c3 = 3344;

int max = Max(Max(a1,b1,c1),
Max(a2,b2,c2),
Max(a3,b3,c3));
int min = Min (Min(a1,b1,c1),
Min(a2,b2,c2),
Min(a3,b3,c3));

Console.WriteLine("Max number : "+ max);
Console.WriteLine("Min number : "+ min);