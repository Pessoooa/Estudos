menu();

static void menu()
{
    Console.Clear();
    Console.WriteLine("==========================================");
    Console.WriteLine("               CALCULADORA");
    Console.WriteLine("==========================================");
    Console.WriteLine("   Qual operação você deseja realizar?");
    Console.WriteLine("   1 - SOMA");
    Console.WriteLine("   2 - SUBTRAÇÃO");
    Console.WriteLine("   3 - DIVISÃO");
    Console.WriteLine("   4 - MULTIPLICAÇÃO");
    Console.WriteLine("   5 - SAIR");
    Console.WriteLine("");
    short res = short.Parse(Console.ReadLine());
    switch (res)
    {
        case 1: soma(); break;
        case 2: subtracao(); break;
        case 3: divisao(); break;
        case 4: multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: menu(); break;
    }
}

static void soma()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1 + v2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();
    menu();
}

static void subtracao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
    menu();
}

static void divisao()
{
    Console.Clear();
    Console.WriteLine("Digite o  primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o  segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.ReadKey();
    menu();
}

static void multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey();
    menu();
}