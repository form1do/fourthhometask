// массив из 8 элементов
int[] GetArray(){
int[] result = new int[8];

for (int i = 0; i < result.Length; i++)
{
result[i] = new Random().Next();
}

return result;
}

void PrintArray(int[] arr){
for (int i = 0; i < arr.Length; i++)
{
System.Console.WriteLine(arr[i]);
}
}

PrintArray(GetArray());