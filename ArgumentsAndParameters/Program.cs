
Console.WriteLine("Enter a something:");//lasen kasutajal valida sõna
string userInput = Console.ReadLine();//salvestan selle

PrintAnyWord(userInput);//userInput --> argument

//PrintAnyWord();//() tähendab --> pane kood käima


static void PrintAnyWord(string anyString)//annan parameetri --> (string anyString)
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}