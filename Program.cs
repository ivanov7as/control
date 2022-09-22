void nnumber()
{
Console.WriteLine("Задайте значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumber(m, n);
void NaturalNumber(int m, int n)
{
  if (m > n) return;
  NaturalNumber(m, n - 1);
  Console.Write(n + ", ");
}
}
nnumber();
Console.WriteLine();
void nsum()
{
Console.WriteLine("Задайте значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());
void NaturalSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write("Cумма натуральных элементов в промежутке от M до N равна " + (sum-m) );
    return;
  }
  NaturalSum(m, n - 1, sum);
}
NaturalSum(m, n, m);
}
nsum();
Console.WriteLine();
void ackermannfunction()
{
Console.WriteLine("Задайте значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());
int Ackermann(int n, int m)
{
	if(n == 0)
	{
		return m + 1;
	}
	if(n > 0 && m == 0)
	{
		return Ackermann(n - 1, 1);
	}
	return Ackermann(n - 1, Ackermann(n, m - 1));
}
Console.WriteLine("Функция Аккермана равна " + Ackermann(m,n));
}
ackermannfunction();