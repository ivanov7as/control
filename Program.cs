Console.WriteLine("Введите трехзначное число");
int num1 = Convert.ToInt32 (Console.ReadLine());
num1 = (num1 / 10)%10;
Console.WriteLine ("Второе число " + num1);

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num2 < 100){
    Console.WriteLine("Третьего числа нет");
 }
else
{
while (num2>1000){
    num2 = num2/10;
}

int thirdNumber;
thirdNumber = (num2 % 100)%10;
Console.WriteLine("Третья цифра " + thirdNumber);
}
Console.WriteLine("Ведите цифрру");
int num3 = Convert.ToInt32 (Console.ReadLine());

if (num3 <= 5)
{
    Console.WriteLine("День рабочий");
}
else if (num3 <=7)
{
    Console.WriteLine("День выходной");

}
else
{
    Console.WriteLine("Введите правильную цифру");
}
