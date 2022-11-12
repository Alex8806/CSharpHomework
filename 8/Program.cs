// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("ввести число =");
int num1 = Convert.ToInt32(Console.ReadLine());

int i = 0;
if (num1<0){
    Console.Write ("Вы ввели отрицательное число");
}
else
{
if (num1==0 || num1==1){
    Console.WriteLine("Четных чисел нет");
}
else{
     Console.Write ("Четные числа : " );
while (i<num1) 
{
    i++;
    if ( i%2==0) {
       
        Console.Write (i+ " ");
        continue;
    }


}}}