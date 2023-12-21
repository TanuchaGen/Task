//  Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,10].
// Пример
// [30 21 23 5 50 42 10 25 3 19] => 6

// int[] array = new int[10];
// int result = 0;

// for(int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1,51);
//     System.Console.Write(array[i] + " ");

//     if(array[i]>= 20 && array[i]<= 90)
//     {
//         result = result + 1;
//     }
// }
// System.Console.WriteLine();

// Console.Write(result);



// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая
// определяет количество чётных чисел в массиве.
// Пример
// [6 7 19 34 3 1 4 7 9 1] => 3

// int[] array = new int[10];
// int result = 0;

// for(int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1,51);
//     System.Console.Write(array[i] + " ");

//     if(array[i]%2 ==0)
//     {
//         result = result + 1;
//     }
// }
// System.Console.WriteLine();

// Console.Write(result);


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементом массива.
// Пример
// [2.2 0.4 9.11 7.2 78.98] => 78/58


// double max = 0;
// double a = 0;
// double[] array = new double[5];
// for(int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     System.Console.Write(array[i] + " ");
//     double min = array[0];
//     //  double max = array[0];
//     if(max<array[i])
//     {
//         max = array[i];
//     }
    
//     if(min>array[i])
//     {
//         min = array[i];
//     }
//     a = max - min;
// }
// System.Console.WriteLine();
// Console.WriteLine(a);