int a;
Console.WriteLine("kviris dgis gasagebad, sheiyvanet cifri 1 dan 7 mde:");
a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 7:
        Console.WriteLine("kvira");
        break;
    case 1:
        Console.WriteLine("orshabati");
        break;
    case 2:
        Console.WriteLine("samshabati");
        break;
    case 3:
        Console.WriteLine("otxshabati");
        break;
    case 4:
        Console.WriteLine("xutshabati");
        break;
    case 5:
        Console.WriteLine("paraskevi");
        break;
    case 6:
        Console.WriteLine("shabati");
        break;
    default:
        Console.WriteLine("araswori cifri");
        break;
}





int number;
int s = 0;

Console.WriteLine("Enter positive numbers to add to the sum. Enter a negative number for sum up operation.");

while (true)
{
    Console.Write("Enter a number: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number < 0)

        break;

    s += number;

    //if (number < 0)

    //    break;

}

Console.WriteLine($"The sum of the positive numbers entered is: {s}");





int i;
int j;

Console.WriteLine("enter number from 1 to 10");
j = Convert.ToInt32(Console.ReadLine());
for (i = 0; i < 10; i++)
    Console.WriteLine(i * j);