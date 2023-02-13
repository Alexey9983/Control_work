Console.Write("Введите число элементов массива: ");
int sizeTaskArray  = int.Parse(Console.ReadLine()!);

string[] MyArray = new string[sizeTaskArray];
Console.WriteLine();

for (int i = 0; i < sizeTaskArray; i++)
{
	Console.Write("Введите элемент массива: ");
    string result = (Console.ReadLine()!);
	MyArray[i] = result;  
}
Console.WriteLine();
Console.Write("Массив после ввода всех элементов: ");
Console.WriteLine($"[{String.Join(",", MyArray)}]");

int count = 0;
int maxValue = 3;

for (int i = 0; i < MyArray.Length; i++)
{
	if(MyArray[i].Length <= maxValue)
    {
		count++;
	}   
}
string[] ResultArray = new string[count];
int j = 0;
for (int i = 0; i < MyArray.Length; i++)
{
    if(MyArray[i].Length <= maxValue)
    {
        ResultArray[j] = MyArray[i];
        j++;
    }
}
Console.Write("Результат поставленной задачи---> ");
Console.WriteLine($"[{String.Join(",", ResultArray)}]");
Console.WriteLine();
