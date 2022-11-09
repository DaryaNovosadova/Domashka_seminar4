Console.Write("Введите натурально число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число В: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int fact = 1;
int count = 0;
int result = 0;

while(count < B)
{
    result = A * fact;
    fact = A * fact;
    count++;
}
Console.Write(result);