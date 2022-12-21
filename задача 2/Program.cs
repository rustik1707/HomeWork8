 // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Getnumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
           break; 
        }
        else
        {
            Console.WriteLine("ввели некорректную команду");
        }
        
    }
    return result;
}

int[,] Getmatrix(int m, int n)
{
    int[,]array = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,11);
;
;
        }
    }

    return array;
}

void Printmatrix(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
     Console.WriteLine();   
    }
 
}

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int m = Getnumber("введите количество строк");
int n = Getnumber("введите количество столбцов");
int[,]array = Getmatrix(m,n);
Printmatrix(array);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");