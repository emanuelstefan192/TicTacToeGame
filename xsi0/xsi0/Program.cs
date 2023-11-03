using xsi0;


char[,] table = new char[3, 3];

actiuni.resetboard(table);
while (actiuni.freespaces(table)>0 && actiuni.checkwinner(table) == ' ')
{
    {
        actiuni.showboard(table);
        actiuni.PlayerXMove(table);
        if (actiuni.checkwinner(table) == ' ')
        {
            actiuni.PlayerOMove(table);
        }
    }
}
actiuni.showboard(table);
if (actiuni.checkwinner(table) == 'X')
{
    Console.WriteLine("YOU WON!");
}   else
    {
        if (actiuni.checkwinner(table) == 'O')
        {
            Console.WriteLine("YOU LOST!");
        } else
        {
        Console.WriteLine("DRAW!");
        }
    }