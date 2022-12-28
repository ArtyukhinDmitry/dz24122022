// Задача - рекурсия , нахождение - перевод число в двоичную систему из 10

// int number = 2; // Десятичное число для перевода

// void ToBinary(int num)
// {
//     // Базовый случай - выход из рекурсии
//     if (num == 0)
//     {
//         return; // Завершение работы функции
//     }
//     // Рекурсивный - вызов функции саму через себя
//     ToBinary(num / 2);
//     Console.Write(num % 2);
// }

// ToBinary(number);





// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцы: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// Комментарий к методу
// /// m - кол-во строк, n - столбцов
// /// min, max
// int[,] Get2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // по строчкам m
//     {
//         for (int j = 0; j < n; j++) // по столбцам n
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам 
//         {
//             Console.Write(matrix[i, j] + "\t"); // "\t" = Tab   
//         }
//         Console.WriteLine();
//     }
// }

// int[,] result = Get2DArray(rows, columns, 0, 10); // Массив rows * columns, от 0 до 10 
// Console.WriteLine("Исходный массив");
// Print2DArray(result);

// void ChangeRows(int[,] inputMatrix)
// {
//     int lastRowIndex = inputMatrix.GetLength(0) - 1; // Хранит номер последней строчки
//     for (int i = 0; i < inputMatrix.GetLength(1); i++) // По столбцам: столбец первой и последней ср
//     {
//         int temp = inputMatrix[0, i];
//         inputMatrix[0, i] = inputMatrix[lastRowIndex, i];
//         inputMatrix[lastRowIndex, i] = temp; // temp = 1
//     }
// }

// int[,] result = Get2DArray(rows, columns, 0, 10); // Массив rows * columns, от 0 до 10 
// Console.WriteLine("Исходный массив");
// Print2DArray(result);
// ChangeRows(result);
// System.Console.WriteLine("Перевернутый двумерный массив: ");
// Print2DArray(result);







// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.





// Задача 59 - Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// // Задача 53: Задайте двумерный массив.
// // Напишите программу, которая поменяет 
// // местами первую и последнюю строку массива.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// Комментарий к методу
// /// m - кол-во строк, n - столбцов
// /// min, max
// int[,] Get2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // по строчкам m
//     {
//         for (int j = 0; j < n; j++) // по столбцам n
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// /// Печать массива. На вход
// /// принимает массив для печати
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам 
//         {
//             Console.Write(matrix[i, j] + "\t"); // "\t" = Tab   
//         }
//         Console.WriteLine();
//     }
// }

// /// Метод, который меняет 1 и последнюю строчку
// void ChangeRows(int[,] inputMatrix)
// {
//     int lastRowIndex = inputMatrix.GetLength(0) - 1; // Хранит номер последней строчки
//     for (int i = 0; i < inputMatrix.GetLength(1); i++) // По столбцам: столбец первой и последней ср
//     {
//         int temp = inputMatrix[0, i];
//         inputMatrix[0, i] = inputMatrix[lastRowIndex, i];
//         inputMatrix[lastRowIndex, i] = temp; // temp = 1
//     }
// }

// int[,] result = Get2DArray(rows, columns, 0, 10); // Массив rows * columns, от 0 до 10 
// Console.WriteLine("Исходный массив");
// Print2DArray(result);
// // Текущий массив изменяется
// ChangeRows(result);
// Console.WriteLine("Перевернутый двумерный массив: ");
// Print2DArray(result);

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // Кол-во строк = кол-во столбцов
// if (rows != columns)
// {
//     Console.WriteLine("Error");
//     return; // Программа закончится, если вернется пустой return
// }
// /// Комментарий к методу
// /// m - кол-во строк, n - столбцов
// /// min, max
// int[,] Get2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // по строчкам m
//     {
//         for (int j = 0; j < n; j++) // по столбцам n
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// /// Печать массива. На вход
// /// принимает массив для печати
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам 
//         {
//             Console.Write(matrix[i, j] + "\t"); // "\t" = Tab   
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] matrix)
// {
//     int[,] change = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < change.GetLength(0); i++) // по строчкам 
//     {
//         for (int j = 0; j < change.GetLength(1); j++) // по столбцам 
//         {
//             change[j, i] = matrix[i, j];
//         }

//     }
//     return change;
// }
// int[,] result = Get2DArray(rows, columns, 0, 10); // Массив rows * columns, от 0 до 10 
// Console.WriteLine("Исходный массив");
// Print2DArray(result);

// Console.WriteLine("Поменяли строчки и столбцы: ");
// Print2DArray(ChangeArray(result));



int rows = 3;
int columns = 3;
int min = int.MaxValue; // Изначально массив заполнен нулями
int indexRows = 0;
int indexColumns = 0; // min = 0
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++) // по строчкам 
{
    for (int j = 0; j < columns; j++) // по столбцам 
    {
        matrix[i, j] = new Random().Next(10, 100); // [0-10]
        Console.Write(matrix[i, j] + "\t"); // "\t" = Tab  
        if (min > matrix[i, j]) // 30 > 20, 20 = min
        {
            indexRows = i; // Номер строчки
            indexColumns = j; // Номер столбца
            min = matrix[i, j]; // перезапись элемента
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Минимум: {min},Cтрочка: {indexRows},столбец: {indexColumns}");
for (int i = 0; i < rows; i++)
{
    if (indexRows != i) // Номер строчки с минимальным элементом в цифл for не попадает
    {
        for (int j = 0; j < columns; j++)
        {
            if (indexColumns != j)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}