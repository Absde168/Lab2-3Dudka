int score = 0;

Console.WriteLine("Система  программного  обеспечения,  что  управляет  работой  всех структурных узлов компьютера");
Console.WriteLine("1 автоматизированная");
Console.WriteLine("2 операционная");
Console.WriteLine("3 интеллектуальная");
Console.Write("Называется: ");
int first = Convert.ToInt32(Console.ReadLine());

switch (first)
{
    case 1: { } break;
    case 2: { score += 2; } break;
    case 3: { } break;
}

Console.WriteLine("Совокупность данных, что размещены на диске и имеют общее имя и назначение –  это");
Console.WriteLine("1 файл");
Console.WriteLine("2  процессор");
Console.WriteLine("3  сектор");
Console.Write("Называется: ");
int second = Convert.ToInt32(Console.ReadLine());

switch (second)
{
    case 1: { score += 2; } break;
    case 2: { } break;
    case 3: { } break;
}

Console.WriteLine("Для  изображения  в  блок-схеме  алгоритма  условия  разветвления используются  графические  элементы");
Console.WriteLine("1 квадрат");
Console.WriteLine("2  круг");
Console.WriteLine("3 ромб");
Console.Write("Называется: ");
int third = Convert.ToInt32(Console.ReadLine());

switch (third)
{
    case 1: { } break;
    case 2: { } break;
    case 3:
    {
        score += 1;
    }
        break;
}

Console.WriteLine($"Ваш балл: {score}");