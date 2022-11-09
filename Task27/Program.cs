Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int sum = 0;
int rem = 0;

while(n > 0)
{
    rem = n % 10;
    sum = sum + rem;
    n = n/10;
}
Console.Write(sum);