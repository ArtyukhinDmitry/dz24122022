void Manager()
{
    Console.WriteLine("Введите номер задачи");
    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 54:
            Task54();
            break;
        case 56:
            Task56();
            break;
        case 58:
            Task58();
            break;
        case 60:
            Task60();
            break;
        default:
            Console.WriteLine("Нет такого номера задачи");
            break;

    } 

}

Manager();



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] BubbleSort(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                if (matrix[k,j] < matrix[k,j + 1])
                {
                    int t = matrix[k,j + 1];
                    matrix[k,j + 1] = matrix[k,j];
                    matrix[k,j] = t;
                }
    return matrix;
}



void Task54()
{
    int[,] TaskMatrix = SetMatrix();
    Console.WriteLine("Сортированный массив");
    int[,] result2 = BubbleSort(TaskMatrix);
    Print2DArray(result2);
}








// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] SetMatrix(){

    int[,] resultMatrix;

    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцы: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное значение ячейки матрицы: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение ячейки матрицы: ");
    int max = Convert.ToInt32(Console.ReadLine());

    resultMatrix = Get2DArray(rows, columns ,min ,max);
    Console.WriteLine("Исходный массив");
    Print2DArray(resultMatrix);
    return resultMatrix;
}

int[,] Get2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int SumRow(int[,] matrix)
{
    int index = -1;
    int minSum = 999999999;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int sum = -1;
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            sum += matrix[row, column];
        }
        if (sum < minSum)
        {
            minSum = sum;
            index = row;
        }  
    }
    return index;
}


void Task56()
{
    int[,] TaskMatrix = SetMatrix();
    Console.WriteLine("Индекс наименьшей суммы строки: " + SumRow(TaskMatrix));
}



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultiplyMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] newMatrix = matrix;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            newMatrix[row, column] = matrix[row, column] * matrix2[row, column];
        }

    }
    return newMatrix;
}

void Task58()
{
    int[,] TaskMatrix = SetMatrix();
    int[,] TaskMatrix2 = SetMatrix();
    Console.WriteLine("Произведение двух матриц: ");
    Print2DArray(MultiplyMatrix(TaskMatrix, TaskMatrix2));
}





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] SetMatrix3D(){

    int[,,] resultMatrix;

    Console.Write("Введите x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z: ");
    int z = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное значение ячейки матрицы: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение ячейки матрицы: ");
    int max = Convert.ToInt32(Console.ReadLine());

    resultMatrix = Get3DArray(x, y, z, min ,max);
    Console.WriteLine("Исходный массив");
    Print3DArray(resultMatrix);
    return resultMatrix;
}

int[,,] Get3DArray(int x, int y, int z, int min, int max)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++) 
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = new Random().Next(min, max + 1);
            }
            
        }
    }
    return matrix;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++) 
            {
                Console.Write(matrix[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
            }
        }
        Console.WriteLine();
    }
}

void Task60()
{
    SetMatrix3D();
}
