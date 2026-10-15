int sum = 0;
int count = 0;

while (true)
{
    Console.WriteLine("Enter the number (0 to exit ) ");
    int number =int.Parse(Console.ReadLine());
    if (number == 0)
    {
        break;
    }
    sum += number;
    count++;

}
if (count > 0)
{
   double average=(double)sum/count;
    Console.WriteLine($"Total number = {sum}");
    Console.WriteLine($"Average = {average}");
    Console.WriteLine($"Count = {count}");
}
else
{
    Console.WriteLine("No number enter");
}

