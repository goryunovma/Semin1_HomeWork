// System.Console.Write("Input Number=  ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"You input -> {num}");

// Console.Write("Input Number=  ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {num * num}");

// Console.Write("Input Number=  ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 100 && num <=999)
// {
//     Console.WriteLine($"{num} -> {num % 10}");
// }
// else
// {
//     Console.Write("You input not three-digit number");
// }

// Console.Write("Input N=  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = -n;
// while(n >= current)
// {
//     Console.Write(current + " ");
//     current ++;
// }

// Console.Write("Input a=  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b=  ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(a== b * b)
// {
//     Console.WriteLine($"{a} {b} True");
// }
// else
// {
//     Console.WriteLine($"{a} {b} Error");
// }

// Console.Write("Input a=  ");
// // int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a=  ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1)
{
    Console.WriteLine("Понедельник");
}
else if(n == 2)
{
    Console.WriteLine("Вторник");
}
else if(n == 3)
{
    Console.WriteLine("Среда");
}
else if(n == 4)
{
    Console.WriteLine("Четверг");
}
else if(n == 5)
{
    Console.WriteLine("Пятница");
}
else if(n == 6)
{
    Console.WriteLine("Суббота");
}
else if(n == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Error");
}

