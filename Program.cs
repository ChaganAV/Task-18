// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите четверть: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
    Console.WriteLine("Возможные варианты: X>0, У>0 ");
else if (num == 2)
    Console.WriteLine("Возможные варианты: X<0, У>0 ");
else if (num == 3)
    Console.WriteLine("Возможные варианты: X<0, У<0 ");
else if (num == 4)
    Console.WriteLine("Возможные варианты: X>0, У<0 ");
else
    Console.WriteLine("Такого варианта нет! ");


