// посчитать сумму всех знаков в числе
Console.WriteLine("ВВедите число");
int n = Convert.ToInt32(Console.ReadLine());
int SumDigits (int number){
int sum = 0;
while( number>0){
   
    sum = sum+number%10;
    number=number/10;
}
return sum;
}
System.Console.WriteLine(SumDigits(n));