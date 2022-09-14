void fillnmarray()
{
Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j <n; j++)
    
        array[i, j] = Convert.ToDouble(new Random().Next(-100,100)/10.0); 
        
}
 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
       
}
}
fillnmarray();

string searchnumber()
{
Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j <n; j++)
    
        array[i, j] = Convert.ToInt32(new Random().Next(0,100)); 
        
}
 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
       
}
int[] arrayod = new int[m*n];
int count = 0;
{
            
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrayod[count++] = array[i, j];
        }
     }
}
Console.WriteLine("Введите позицию элемента в двумерном массиве");
int num = Convert.ToInt32(Console.ReadLine());
int number = num - 1;
string search = " ";
if (number>m*n)
search = "такого числа в массиве нет";
 else
 {
object position = arrayod.GetValue(number);
search = ("Значение ячейки с этим номером " + position);
 }
 return search;
 }
 Console.WriteLine(searchnumber())

 void armeen()
{
Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j <n; j++)
    
        array[i, j] = Convert.ToInt32(new Random().Next(0,100)); 
        
}
 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
       
}
double arithmeticMean = 0;
for (int i = 0; i < m; i++) 
{
    double sum = 0;
    for (int j = 0; j <n; j++)
    {
        sum+=array[j,i];
    }
    arithmeticMean = sum/n;
    Console.WriteLine("средннее арифметическое " + (i+1) + "-го столбца " + arithmeticMean);   
}
}
armeen();
 