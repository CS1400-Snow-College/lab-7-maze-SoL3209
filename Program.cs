Console.Clear();
Console.WriteLine("Welcome to your DOOM! Try, foolish mortal, to get to the ASTERISK, for it is your ONLY WAY OUT!!! (press enter to continue)");
string [] map = File.ReadAllLines("map.txt");
if (Console.ReadKey(true).Key == ConsoleKey.Enter)
{
    Console.Clear();
    foreach (string row in map)
    Console.WriteLine(row);
}
ConsoleKey keyPress;
int x = 0;
int y = 0;
Console.SetCursorPosition(x, y);

do
{
    keyPress = Console.ReadKey(false).Key;
    if (keyPress==ConsoleKey.LeftArrow && map[Console.CursorTop][Console.CursorLeft-1] != '#')
        x--;
    else if (keyPress==ConsoleKey.RightArrow && map[Console.CursorTop][Console.CursorLeft+1] != '#')
       x++;
    else if (keyPress==ConsoleKey.UpArrow && map[Console.CursorTop-1][Console.CursorLeft] != '#')
        y--;
    else if (keyPress==ConsoleKey.DownArrow && map[Console.CursorTop+1][Console.CursorLeft] != '#')
        y++;
    else if (keyPress==ConsoleKey.A && map[Console.CursorTop = 4][Console.CursorLeft = 23] != '#') //Illusory wall, loser
        map = File.ReadAllLines("map2.txt");
    Console.Clear();
    foreach (string row in map)
    Console.WriteLine(row);

    TryMove(x, y);
    if (x < 0)
        x = 0;
    else if (y < 0)
        y = 0;

    if (map[Console.CursorTop][Console.CursorLeft]=='*')
    {
        Console.Clear();
        Console.WriteLine($"You got through?!!??!? Press Enter to end.");
        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        break;
    } 
}
while (keyPress != ConsoleKey.Escape);
Console.Clear();

void TryMove (int x, int y)
{
    if (x >= 0 && x < Console.BufferHeight && y >= 0 && y < Console.BufferHeight)
        Console.SetCursorPosition(x, y);
}