void sortarray()
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
for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      for (int k = 0; k < n - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }

Console.WriteLine();
Console.WriteLine("Отсортированный массив");
Console.WriteLine();


for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
       
}
}
sortarray();

void minstring()
{
Console.WriteLine("Введите размерность квадратного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n=m;

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

int sum(int[,] array, int i)
{
  int sumstr = 0;
  for (int j = 1; j < m; j++)
  {
    sumstr += array[i,j];
  }
  return sumstr;
}


int minsum = 0;
int sumstr = sum(array, 0);
for (int i = 1; i < m; i++)
{
  int temp = sum(array, i);
  if (sumstr > temp)
  {
    sumstr = temp;
    minsum = i;
  }
}

Console.WriteLine("Cтрокa с наименьшей суммой элементов - " + (minsum+1));

}
minstring();

void multiplicationArray()
{
Console.WriteLine("Введите количество строк l первой матрицы:");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов m первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n второй матрицы");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayone = new int[l, m];
int[,] arraytwo = new int[m, n];

 
for (int i = 0; i < l; i++) 
{
    for (int j = 0; j <m; j++)
    
        arrayone[i, j] = Convert.ToInt32(new Random().Next(0,10)); 
        
}
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j <n; j++)
    
        arraytwo[i, j] = Convert.ToInt32(new Random().Next(0,10)); 
        
}
 
for (int i = 0; i < l; i++) 
{
    for (int j = 0; j < m; j++)
    
        Console.Write(arrayone[i,j] + " ");
        Console.WriteLine();
       
}
Console.WriteLine();

for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    
        Console.Write(arraytwo[i,j] + " ");
        Console.WriteLine();
       
}

int[,] arraymultiplication = new int[l,n];

for (int i = 0; i < l; i++)
  {
    for (int j = 0; j < n; j++)
    {
      int sum = 0;
      for (int k = 0; k < m; k++)
      {
        sum += arrayone[i,k] * arraytwo[k,j];
      }
      arraymultiplication[i,j] = sum;
    }
  }

Console.WriteLine();
Console.WriteLine("Произведение первой и второй матриц");
Console.WriteLine();


for (int i = 0; i < l; i++) 
{
    for (int j = 0; j < n; j++)
    
        Console.Write(arraymultiplication[i,j] + " ");
        Console.WriteLine();
       
}
}
multiplicationArray();

void array3d()
{
Console.WriteLine("Введите размерность x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность z:");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[x, y, z];
CreateArray(array);
void CreateArray(int[,,] array)
{
  int[] arr = new int[x * y * z];
  int  num;
  for (int i = 0; i <x; i++)
  {
    arr[i] = new Random().Next(10, 99);
    num = arr[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        if (arr[i] == arr[j])
        {
          arr[i] = new Random().Next(10, 99);
          num = arr[i];
        }
          num = arr[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = arr[count];
        count++;
      }
    }
  }
}
for (int i = 0; i < array.GetLength(0); i++)
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $" {array[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
  }
}
array3d();