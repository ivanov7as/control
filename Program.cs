string asqrtb(){
Console.WriteLine("Введите число A");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32 (Console.ReadLine());
int c = a;
for (int i=1; i < b; i++)
    {
        a=a*c;
    }
string answer = ("A в степени B равно " + a);
return answer;
}
Console.WriteLine(asqrtb());

string summofnum()
{
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32 (Console.ReadLine());
int sum = 0;
while (num1>0)
{
    sum = sum + num1%10;
    num1 = num1/10;
}
string summof =  ("Сумма чисмел " + sum);
return summof;
}
Console.WriteLine(summofnum());

stringarray();
void stringarray()
{
int [] array = new int[8];
for (int i = 0; i <array.Length; i++)
{
    Console.Write("Введите элемент " + (i+1) + " ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    
}
for (int i = 0; i <array.Length; i++)
{
    System.Console.Write("{0} ", array[i]);
}
}

median();
void median()
{
Console.WriteLine("Введите размерность массива N");
int n = Convert.ToInt32 (Console.ReadLine());
int [] arr = new int[n];
int temp;
double med;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
 
Console.WriteLine("Отсортированный массив");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
Console.WriteLine("Медианное значение");
if (n%2 == 0)
{
    med = (arr[((n-1)/2)]+arr[n/2])/2;
    Console.WriteLine(med);    
}
else
{
    med = arr[(n/2)];
    Console.WriteLine(med);
}
}