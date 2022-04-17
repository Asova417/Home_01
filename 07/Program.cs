Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a>100)
{
    a=a-100;
}
while (a>10)
{
    a=a-10;
}
if (a<10)
{
    Console.WriteLine(a);
}