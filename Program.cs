restart:
Console.WriteLine("1. Üçgen");
Console.WriteLine("2. Dik Üçgen");
Console.WriteLine("Seçiminiz: ");
int secim = Convert.ToInt32(Console.ReadLine());
int say;
if(secim <= 2)
{
    switch (secim)
    {
        case 1:
            Console.WriteLine("Boyutu giriniz: ");
            say = Convert.ToInt32(Console.ReadLine());
            ucgen(say);
            break;
         case 2:
            Console.WriteLine("Boyutu giriniz: ");
            say = Convert.ToInt32(Console.ReadLine());
            dikUcgen(say);
            break;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Yanlış seçim");
    goto restart;
}
Console.WriteLine("Tekrar denemek ister misinz (y/n)");
string tekrar = Console.ReadLine();
if(tekrar.ToLower() == "y")
{
    goto restart;
}
else if(tekrar.ToLower() == "n")
{
    Console.WriteLine("Görüşmek üzere!");
}
else
{
    Console.WriteLine("Seçiminiz yanlış!");
}

void ucgen(int sayi)
{
    for (int i = 0; i < say; i++)
    {
        for (int j = i; j < say; j++)
        {
            Console.Write(" ");

        }
        for (int x = 0; x < i; x++)
        {
            Console.Write("*");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void dikUcgen(int sayi)
{
    for (int i = 0; i < say; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}