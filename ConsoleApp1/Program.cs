using Lang;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose the month number:");
string select = Console.ReadLine();
switch (select){
    case "1" :
        Console.WriteLine($"В Январе {variables.a} день");
        break;
    case "2":
        Console.WriteLine($"В Феврале {variables.c} дней");
        break;
    case "3":
        Console.WriteLine($"В Марте {variables.a} день");
        break;
    case "4":
        Console.WriteLine($"В Апреле {variables.b} дней");
        break;
    case "5":
        Console.WriteLine($"В Мае {variables.a} день");
        break;
    case "6":
        Console.WriteLine($"В Июне {variables.b} дней");
        break;
    case "7":
        Console.WriteLine($"В Июле {variables.a} день");
        break;
    case "8":
        Console.WriteLine($"В Августе {variables.b} дней");
        break;
    case "9":
        Console.WriteLine($"В Сентябре {variables.a} день");
        break;
    case "10":
        Console.WriteLine($"В Октябре {variables.b} дней");
        break;
    case "11":
        Console.WriteLine($"В Ноябре {variables.a} день");
        break;
    case "12":
        Console.WriteLine($"В Декабре {variables.b} дней");
        break;
}
string [] list1 = new string[] {"1", "2", "12"};
string[] list2 = new string[] { "3", "4", "5" };
string[] list3 = new string[] { "6", "7", "8" };
string[] list4 = new string[] { "9", "10", "11" };
if (list1.Any(select.Equals))
{
    Console.WriteLine("Зима");
}
if (list2.Any(select.Equals))
{
    Console.WriteLine("Весна");
}
else if (list3.Any(select.Equals))
{
    Console.WriteLine("Лето");  
}
if (list4.Any(select.Equals))
{
    Console.WriteLine("Осень");
}