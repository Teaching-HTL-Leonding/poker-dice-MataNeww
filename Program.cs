#region Variables
int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0;
bool Fixed1 = false, Fixed2 = false, Fixed3 = false, Fixed4 = false, Fixed5 = false; 
char input;
int[] sort = new int[5]; 
#endregion

RollDice();
Console.Write("Dice roll # 1(out of 3): ");
PrintDice();
FixDice();

RollDice();
Console.Write("Dice roll # 2(out of 3): ");
PrintDice();
FixDice();

RollDice();
Console.Write("Dice roll # 3(out of 3): ");
PrintDice();
SortDice();
Console.Write("Sorted: ");
PrintDice();

void RollDice()
{
    if (!Fixed1) { dice1 = Random.Shared.Next(1, 7); sort[0] = dice1; }
    if (!Fixed2) { dice2 = Random.Shared.Next(1, 7); sort[1] = dice2; }
    if (!Fixed3) { dice3 = Random.Shared.Next(1, 7); sort[2] = dice3;}
    if (!Fixed4) { dice4 = Random.Shared.Next(1, 7); sort[3] = dice4;}
    if (!Fixed5) { dice5 = Random.Shared.Next(1, 7); sort[4] = dice5;}
}

void PrintDice()
{
    for (int i = 0; i < sort.Length; i++)
    {
        Console.Write($"{sort[i]}, ");
    }
    Console.WriteLine();
}

void FixDice()
{

    Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dice)  ");
    do
    {
        input = char.Parse(Console.ReadLine()!);
        switch (input)
        {
            case '1': Fixed1 = !Fixed1; break;
            case '2': Fixed2 = !Fixed2; break;
            case '3': Fixed3 = !Fixed3; break;
            case '4': Fixed4 = !Fixed4; break;
            case '5': Fixed5 = !Fixed5; break;
            case 'r': break;
            default: Console.WriteLine("WAT?"); break;
        }
        Console.Write("Fixed: ");
        if (Fixed1) { Console.Write("1 "); }
        if (Fixed2) { Console.Write("2 "); }
        if (Fixed3) { Console.Write("3 "); }
        if (Fixed4) { Console.Write("4 "); }
        if (Fixed5) { Console.Write("5 "); }

        Console.WriteLine();
    } while (input != 'r');
}

void SortDice()
{
    for (int i = 0; i < sort.Length; i++)
    {
        for (int j = i + 1; j < sort.Length; j++)
        {
            if (sort[i] > sort[j])
            {
                int temp = sort[i];
                sort[i] = sort[j];
                sort[j] = temp;
            }
        }
    }
}
