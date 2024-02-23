Console.WriteLine("Enter the operation (+/-/*//):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());



switch(userOperator)
{//{ tänu sellele kustututatakse vahemälust kõik mis {} sees on
    case '+':
        Addition(firstNum, secondNum);
        break;

    case '-':
        Subtraction(firstNum, secondNum);
        break;

    case '*':
        Multiplication(firstNum, secondNum);
        break;

    case '/':
        Division(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void Addition(int a, int b) // () vahel väärtusi võib olla mitu aga samat tüüpi. Erinevates funktsioonides võib kasutada erinevaid tüüpe aga ühes funktsioonis on üks kindel tüüp
{
    Console.WriteLine($"{a} + {b} = {a+b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a-b}");
}

static void Multiplication(int a, int b)
{
    Console.WriteLine($"{a} * {b} = {a*b}");
}

static void Division(int a, int b)
{
    Console.WriteLine($"{a} / {b} = {a/b}");
}