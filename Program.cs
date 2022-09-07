void paritynum()
{
Console.WriteLine("Введите размер массива N");
int num1 = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[num1];
int parity = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i]+ " ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        parity = parity + 1;
    }
}
Console.WriteLine("Количество четных чисел " + parity);
}
paritynum();

void unparitypositionsum()
{
Console.WriteLine("Введите размер массива N");
int num2 = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[num2];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 99);
    Console.Write(array[i]+ " ");
}
for (int i = 1; i < array.Length; i++)
{
    if (i%2>0)
    {
    sum = sum + array[i];
    }
}
Console.WriteLine("Сумма чисел на нечетных позициях " + sum);
}
unparitypositionsum();

void minmaxsum()
{
Console.WriteLine("Введите размер массива N");
int num2 = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[num2];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 99);
    Console.Write(array[i]+ " ");
}
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]<min)
    {
        min=array[i];
    } 
}
for (int i = 0; i < array.Length; i++)
{
     if (array[i]>max)
    {
        max=array[i];
    } 
}
sum = min + max;
Console.WriteLine("Сумма минимального и максимального числа " + sum);
}
minmaxsum();

void nspace()
{
Console.WriteLine("Введите размерность пространства N");
int n = Convert.ToInt32 (Console.ReadLine());
int[] arrone = new int[n];
int[] arrtwo = new int[n];
for (int i = 0; i < arrone.Length; i++)
{
Console.Write("Введите координаты первой точки ");    
arrone[i] = Convert.ToInt32 (Console.ReadLine());
}
for (int i = 0; i < arrtwo.Length; i++)
{
Console.Write("Введите координаты второй точки ");    
arrtwo[i] = Convert.ToInt32 (Console.ReadLine());
}
int sumofsqrdif =0;
int difpoint;
for (int i = 0; i < n; i++)
{
difpoint = (arrone[i]-arrtwo[i])*(arrone[i]-arrtwo[i]);
sumofsqrdif = sumofsqrdif + difpoint;
}
double length = Math.Sqrt(sumofsqrdif);
Console.WriteLine("Расстояние между точками " + length);
}
nspace();




