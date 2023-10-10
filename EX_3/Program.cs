// Среднее арифметическое каждого столбца

// Инструкция по использованию платформы



// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.
// Пример


// n = 3;
// m = 4;
// k = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));

// /*
// 1   3   5   7   
// 9   11  13  15  
// 17  19  21  23  
// The averages in columns are: 
// 9.00    11.00   13.00   15.00
// */

int n = 4;
int m = 5;
int k = 3;

Console.Clear();
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));

// Methods

static void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

static int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    // Введите свое решение ниже
    int[,] array = new int[n, m];
    array[0, 0] = 1;
    int prevItem = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = i == 0 ? 1 : 0; j < m; j++)
        {
            array[i, j] = prevItem + k;
            prevItem = array[i, j];
        }
    }
    return array;
}

static void PrintListAvr(double[] list)
{
    // Введите свое решение ниже
    Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:f2}\t");
    }
}

static double[] FindAverageInColumns(int[,] matrix)
{
    // Введите свое решение ниже
    double[] result = new double[matrix.GetLength(1)];
    double temp;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            temp += matrix[j,i];
        }
        result[i] = temp / matrix.GetLength(0);
    }
    return result;
}
