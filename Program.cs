/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.WriteLine("Введите количество строк в массиве: "); 
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("введите количество столбцов: "); 
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];  
int[,] CreatArray(int m, int n) 
{     
int[,] array1 = new int[m, n];     
Random rnd = new Random();     
for (int i = 0; i < array1.GetLength(0); i++)     
    {        for (int j = 0; j < array.GetLength(1); j++)         
             {      array1[i, j] = rnd.Next(0, 10);         
             }     
    }     return array1; 
}
string ArrayToString(int[,] array1) 
{   string result = string.Empty;
    for (int i = 0; i < array1.GetLength(0); i++) 	
    { 		for (int j = 0; j < array.GetLength(1); j++)
     		{ 			
                result += $"{array1[i, j]} "; 		
            }  		
            result += Environment.NewLine; 	
    }  	return result;
}
int [,] array1 = CreatArray(m,n);  
Console.WriteLine("Ваш массив: ");
Console.WriteLine(ArrayToString(array1));
Console.WriteLine("Среднее арифметическое элементов в столбцах составляет: ");
for (int j = 0; j < array1.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        sum += array1[i, j];
    }
    Console.Write($"{ sum / array1.GetLength(0)} ");
}