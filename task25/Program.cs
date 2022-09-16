// Возведение а в степень b
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int product = 1;
   for (int i=0; i<b; i++){
    product = product * a;
   }
System.Console.WriteLine($" а^b = {product}");