/*
Задача 54: 
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
// Метод для создания массива

Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int maxElements = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = GetMatrix(rows, columns, minElements, maxElements);

// rows = 3 columns = 4 => таблица из 3-х строк и 4 -х столбцов, 
//элемент: число от min до max включительно
Console.WriteLine();
Console.WriteLine("Исходный двумерный массив, заполненный случайными целыми числами:");
PrintMatrix(resMatrix); // PrintMatrix(матрица)
Console.WriteLine();
Console.WriteLine("Элементы по убыванию в каждой строке двумерного массива:");

SortElementsInDescendingOrder(resMatrix);
PrintMatrix(resMatrix); // PrintMatrix(матрица)

int[,] GetMatrix(int m, int n, int minElements, int maxElements)
{
    int[,] matrix = new int[m,n]; // Таблица из m - строк и n - столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам, i < m
    {
       // i, j, m, k
       for (int j = 0; j < matrix.GetLength(1); j++) // Цикл по столбцам, j < n
       {
        matrix[i, j] = new Random().Next(minElements, maxElements+1);
       } 
    }
    return matrix;
}

// Метод, который печатает массив
void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
        Console.Write(array2D[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
       } 
        Console.WriteLine();
    }
}

// Метод, который упорядочит по убыванию элементы каждой строки.
void SortElementsInDescendingOrder(int[,] array2D)
{
    int temp = new int();    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < (array2D.GetLength(1) - 1); j++)
        {
            for (int k = j + 1; k < array2D.GetLength(1); k++)
            {
                if((array2D[i, j] < array2D[i, k]))
                {
                    temp = array2D[i, j];
                    array2D[i, j] = array2D[i, k];
                    array2D[i, k] = temp;
                }
            }
             
        }   
    }
return;
}
