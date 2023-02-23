// Найти произведение двух матриц
void CreateArray(int[,] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i,j] = rnd.Next(1,10);
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

int [,] arr1 = new int [2,2];
CreateArray(arr1);

int [,] arr2 = new int [2,2];
CreateArray(arr2);


PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);

int [,] rez = new int [2,2];
rez[0,0] = arr1[0,0] * arr2[0,0] + arr1[0,1] * arr2[1,0];
rez[0,1] = arr1[0,0] * arr2[0,1] + arr1[0,1] * arr2[1,1];
rez[1,0] = arr1[1,0] * arr2[0,0] + arr1[1,1] * arr2[1,0];
rez[1,1] = arr1[1,0] * arr2[0,1] + arr1[1,1] * arr2[1,1];

Console.WriteLine();
PrintArray(rez);