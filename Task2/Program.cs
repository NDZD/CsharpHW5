// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int GetSum(int n){
Random rnd = new Random();
int sum = 0;
int [] arr = new int [n];
for (int i = 0; i < n; i++){

arr [i] = rnd.Next(1, 10);
}
foreach (var item in arr)
{
    if(item % 2 == 1){
        sum += item;
    }
    System.Console.WriteLine(item);     //проверка, вывод всех чисел массива
}
return sum;

}

System.Console.WriteLine($"Сумма: {GetSum(5)}" );