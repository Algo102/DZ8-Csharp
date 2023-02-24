Console.Clear();
int[] result = new int[8];
result [0] = 1;
int x = 0;
int y = 0;
Console.SetCursorPosition(16,8);
for (int i = 0; i < result.Length; i++) 
{
  int left = 0;
  for (int j = 0; j <= i; j++) 
  {                  
    int tmp = result [j];
    result [j] = result [j] + left;
    left = tmp;
    
    Console.Write(" " + result [j]);
    
  }
  Console.WriteLine();
  Console.SetCursorPosition(15-x,9+y);
  x++;
  y++;
  
        
}
