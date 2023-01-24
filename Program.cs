// #1
/*
Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Array: ");
ShowArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"Total {numbers.Length} numbers, {count} of them even");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int a = 0; a < numbers.Length; a++)
    {
        numbers[a] = new Random().Next(100,1000);
    }
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
    
}
*/
// #2
/*
Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.Write("Array: ");
ShowArray(array);

int FillArrayRandomNumbers(int[] array)
{
int sum = 0;
bool a = true;

    for(int i = 0; i < array.Length; i+=2)
        {
            array[i] = new Random().Next(1,100);
            if (a == true)
            {
                sum = sum + array[i];
            }
        }
        a = !a;
        Console.WriteLine($"Total {array.Length} numbers, sum of elements in odd positions = {sum}");
        return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
    
}
*/
// #3
/*
Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
Console.Write("Array: ");
ShowArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Total {array.Length} numbers. Max = {max}, min = {min}");
Console.WriteLine($"Difference between values = {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
    
}
*/
