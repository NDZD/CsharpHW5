// Задача 38: Задайте массив вещественных чисел. Найдите
//  разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int GetDifference(int n ){
    Random rnd = new Random();
int subtraction = 0;
int max = 0;
int min = 0;
int [] arr = new int [n];
for (int i = 0; i < n; i++){

arr [i] = rnd.Next(-100, 100);
System.Console.WriteLine(arr[i]);
}
for (int i = 0; i < n; i++){
if(arr[i] > max){
    max = arr[i];
}
else if(arr[i] < min){
    min = arr[i];
}
}
subtraction = max - min;
return subtraction;

}

System.Console.WriteLine($"Разность: {GetDifference(5)}" );
