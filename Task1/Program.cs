// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int GetEvenNumbers(int n){
Random rnd = new Random();
int count = 0;
int [] arr = new int [n];
for (int i = 0; i < n; i++){

arr [i] = rnd.Next(100, 1000);
}
foreach (var item in arr)
{
    if(item % 2 == 0){
        count++;
    }
    System.Console.WriteLine(item);     //проверка, вывод всех чисел массива
}
return count;
}
System.Console.WriteLine(GetEvenNumbers(10));