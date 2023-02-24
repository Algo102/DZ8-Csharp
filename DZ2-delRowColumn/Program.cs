// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void CreateArray(int[,] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i,j] = rnd.Next(11,99);
    }
  }
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j] + "  ");
    }
    Console.WriteLine();
  }
}

int [,] arr1 = new int [3,3]; //можем указать любой размер массива
CreateArray(arr1);
PrintArray(arr1);
Console.WriteLine();

int min = arr1[0,0];
int m=0; //строка с минимальным значением
int n=0; //столбец с минимальным значением

//поиск минимальной позиции
for(int i = 0; i < arr1.GetLength(0); i++)
{
  for(int j = 0; j < arr1.GetLength(1); j++)
  {
    if (min > arr1[i,j])
    {
      min = arr1[i,j];
      m = i;
      n = j;
    }
  }
}

Console.WriteLine($"Минимальный элемент {min} находится в строке - {m}, в колонке - {n}");

//новый массив с уменьшенным размером
int [,] rez = new int [arr1.GetLength(0)-1,arr1.GetLength(1)-1];

for (int i = 0; i < rez.GetLength(0); i++)
{
  int a = i >= m ? i + 1 : i;
  for (int j = 0; j < rez.GetLength(1); j++)
  {
    int b = j >= n ? j + 1 : j;
    rez[i, j] = arr1[a, b];
  }
}

// for (int i = 0; i < rez.GetLength(0); i++)
// {
//   int a = i;
//   if (i >= m)  a = i + 1;
//   else a = i;
  
//   for (int j = 0; j < rez.GetLength(1); j++)
//   {
//     int b = j;
//     if (j >= n)  b = j + 1;
//     else b = j;
//     rez[i, j] = arr1[a, b];
//   }
// }

PrintArray(rez);