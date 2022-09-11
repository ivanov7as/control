void m()
{
Console.Write("Введите M чисел ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count = count + 1;
    }
}
 
Console.WriteLine("Количсетво элементов больше нуля - " + count);
}
m();

void crosspoint()
{
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32 (Console.ReadLine());
double y = k1*(b2-b1)/(k1-k2) + b1;
double x =(b2-b1)/(k1-k2);
Console.WriteLine("Координата точки пересечения " + x + " " + y );
}
crosspoint();

void triangle()
{

Console.WriteLine("Введите первое число");
double a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число");
double c = Convert.ToInt32 (Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine ("Являются сторонами треугольника");
}
else
{
    Console.WriteLine ("Не являются сторонами треугольника");
}
double p = (a+b+c)/2;
double s = Math. Sqrt(p * (p-a)*(p-b)*(p-c));
Console.WriteLine ("Площадь треугольника " + s);
double alpha = (Math.Acos((a*a + c*c - b*b)/(2*a*c)))*180/Math.PI;
Console.WriteLine ("Угол альфа " + alpha + " градуса");
double betha = (Math.Acos((a*a + b*b - c*c)/(2*a*b)))*180/Math.PI;
Console.WriteLine ("Угол бета " + betha + " градуса");
double gamma = (Math.Acos((b*b + c*c - a*a)/(2*c*b)))*180/Math.PI;
Console.WriteLine ("Угол гамма " + gamma + " градуса");
if (alpha == 90 || betha == 90 || gamma == 90)
{
    Console.WriteLine("Треугольник прямоугольный");
}
if (alpha == betha && betha == gamma && gamma == alpha)
{
    Console.WriteLine("Треугольник равносторонний");
}
if ((alpha == betha && gamma != alpha) || (betha == gamma && alpha !=betha) || (gamma == alpha && betha !=gamma))
{
    Console.WriteLine("Треугольник равнобедренный");
}
if (alpha == 90 && betha == 90 && gamma == 90)
{
    Console.WriteLine("Треугольник прямоугольный");
}
}
triangle();
