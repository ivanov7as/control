string[] array1;
Console.WriteLine("Введите массив строк");
string arrayenter = Console.ReadLine();
array1 = arrayenter.Split(' ');
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
        }
    }
}

NewArray(array1, array2);
PrintArray(array2);