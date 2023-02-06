// Показать числа Фибоначчи
//f(1)=1;
//f(2)=1;
//f(n)=f(n-1) + f(n-2);

int fibonacci(int n)
{
    if(n==1||n==2) return 1;
    else return fibonacci(n-1) + fibonacci(n-2);
}
Console.WriteLine("enter Fibonacci length");
int length = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i =1; i<length+1; i++ )
{
    Console.WriteLine(fibonacci(i));
}

