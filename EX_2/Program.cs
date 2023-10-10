// Поиск элемента по позиции

// Инструкция по использованию платформы



// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

// Пример


// n = 3;
// m = 4;
// k = 2;

int n = 3;
int m = 4;
int k = 2;
int x = 2;
int y = 3;

int[,] arr = CreateIncreasingMatrix(n, m, k);

PrintArray(arr);

PrintCheckIfError(FindNumberByPosition(arr, x, y), x, y);

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

static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    // Введите свое решение ниже
    int[] arr = new int[2];
    if ((matrix.GetLength(0) > rowPosition) && (matrix.GetLength(1) > columnPosition))
    {
        arr[0] = matrix[rowPosition - 1, columnPosition - 1];
        arr[1] = 0;
    }
    else
    {
        arr[1] = -1;
    }
    return arr;
}

static void PrintCheckIfError(int[] results, int x, int y)
{
    // Введите свое решение ниже
    if (results[1] == 0)
    {
        Console.WriteLine($"The number in [{x},{y}] is {results[0]}");
    }
    else
    {
        Console.WriteLine("There is no such index");
    }

}
