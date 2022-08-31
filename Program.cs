string palindrom()
{
Console.WriteLine("Введите пятизначное число");
int num1 = Convert.ToInt32 (Console.ReadLine());
int digit1 = num1/10000;
int digit2 = num1/1000%10;
int digit4 = num1/10%10;
int digit5 = num1%1000%100%10;
string answer = "";

if (digit1 == digit5 && digit2 == digit4)
{
    answer = ("Число является палиндромом");

}
else
{
    answer = ("Число не является палиндромом");
}
return answer;
}
Console.WriteLine(palindrom());

string distance()
{
Console.Write("Введите координату x первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
string truedistance = ("Расстояние между точками в 3D пространстве " + length);
return truedistance;
}
Console.WriteLine(distance());

string cubetable()
{
Console.WriteLine("Введите число n");
int n = Convert.ToInt32 (Console.ReadLine());
int counter = 1;
List<int> table = new List<int>{};
while (counter <= n)
{
    int cube = (int)Math.Pow(counter, 3);
    counter+=1;
    table.Add(cube);
}
string tablecube = String.Join(" ",table.ToArray());
return tablecube;
}
Console.Write(cubetable());
