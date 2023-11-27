m:
Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
if (n > 100)
{
    Console.WriteLine("НЕВЕРНОЕ ЗНАЧЕНИЕ!!!! X_X ");
    goto m;
}

Console.WriteLine("Введите числа массива");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}

if (IsMatrixSymmetric(matrix))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
bool IsMatrixSymmetric(int[,] matrix)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] != matrix[j, i]) 
            {
                return false; 
            }
        }
    }
    return true;
}





//2 задание
//int n;
//Console.WriteLine("Введите длину массива:");
//n = Convert.ToInt32(Console.ReadLine());

//int[] n = new int[n];

//for (int j = 0; j < n.Length; j++)
//{
//    Console.WriteLine($"Значение {j} элемента массива:");
//    n[j] = Convert.ToInt32(Console.ReadLine());
//}

//for (int i = 0; i < n.Length; i++)
//{
//    Console.WriteLine(n[i]);
//}

//bool found = false; 

//for (int i = 0; i < n.Length; i++)
//{
//    for (int j = i + 1; j < n.Length; j++)
//    {
//        if (n[i] + n[j] == 0)
//        {
//            found = true;
//            Console.WriteLine($"Противоположные числа найдены: {n[i]} (индекс {i}) и {n[j]} (индекс {j})");
//        }
//    }
//}


//3 задание
//Console.WriteLine("Введите количество измеряемых дней:");
//int day = Convert.ToInt32(Console.ReadLine());

//double[] temp = new double[day];
//Console.WriteLine("Введите температуру:");

//for (int i = 0; i < day; i++)
//{
//    Console.Write($"День {i + 1}: ");
//    temp[i] = Convert.ToDouble(Console.ReadLine());
//}

//Console.WriteLine("Результат: ");

//for (int i = 0; i < day; i++)
//{
//    double currentTemp = temp[i];
//    bool isMax = true; 
//    bool isMin = true;

//    for (int j = 0; j < day; j++)
//    {
//        if (i != j)
//        {
//            if (currentTemp >= temp[j])
//            {
//                isMin = false;
//            }                                                   

//            if (currentTemp <= temp[j])
//            {
//                isMax = false;
//            }
//        }
//    }

//    if (isMax)
//    {
//        Console.WriteLine($"День {i + 1}: {currentTemp}");
//    }
//    else if (isMin)
//    {
//        Console.WriteLine($"День {i + 1}: {currentTemp}");
//    }
//}