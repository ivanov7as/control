Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine ("Максимальное число из двух чисел " + num2);
    Console.WriteLine ("Минимальное число из двух чисел " + num1);

}
if (num1 > num2)
{
    Console.WriteLine ("Максимальное число из двух чисел " + num1);
    Console.WriteLine ("Минимальное число из двух чисел " + num2);  
}
if (num1 == num2)
{
    Console.WriteLine ("числа равны");  

}

Console.WriteLine("Введите третье целое число");
int num3 = Convert.ToInt32 (Console.ReadLine());
int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3 )
{
    max = num3;
}
Console.WriteLine ( "Максимальное число из трех чисел " + max);
Console.WriteLine("Введите число для проверки четности");
int numParity = Convert.ToInt32 (Console.ReadLine());
if (numParity%2 == 0)
{
    Console.WriteLine ("Число четное");  
}
else
{
    Console.WriteLine ("Число нечетное");  

}
Console.WriteLine("Введите число N, вывода всех четных чисел от 1 до N");
int numN = Convert.ToInt32 (Console.ReadLine());
int a = 2;
while (a <= numN)
{
    Console.Write(a+ " ");
    a = a + 2;
}