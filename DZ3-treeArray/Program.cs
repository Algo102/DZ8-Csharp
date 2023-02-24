// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
int [,,] arr1 = new int [3,3,3];
int count = 10;
for(int i = 0; i < arr1.GetLength(0); i++)
{
  for(int j = 0; j < arr1.GetLength(1); j++)
  {
    for (int k = 0; k < arr1.GetLength(2); k++)
    {
      arr1[i,j,k] = arr1[i,j,k] + count;
      count++;
    }
  }
}

for(int i = 0; i < arr1.GetLength(0); i++)
{
  for(int j = 0; j < arr1.GetLength(1); j++)
  {
    for (int k = 0; k < arr1.GetLength(2); k++)
    {
      Console.WriteLine($"Строка {i+1}  cтолбец {j+1}  глубина {k+1}  содержание {arr1[i,j,k]} ");
    }
    Console.WriteLine();
  }
}