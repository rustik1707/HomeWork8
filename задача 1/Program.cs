//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void NewArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
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
    
}
int m = Getnumber("введите количество строк");
int n = Getnumber("введите количество столбцов");
int[,]array = Getmatrix(m,n);
Printmatrix(array);
Console.WriteLine();
NewArray(array);
Printmatrix(array);