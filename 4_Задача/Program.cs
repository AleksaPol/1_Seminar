Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int num = 2;
Console.Write($"Все четные числа от 1 до {a}: ");
while(num <= a)
{
    Console.Write(num + ", ");
    num = num + 2;
}
Console.WriteLine();