namespace Game;

public class Game
{
    private char[,] map;
    private (int x, int y) MainCharacterCoordinates { get; set;}
    private char freeSpace = ' ';

    public Game(string filePath)
    {
        map = GetMapFromFile(filePath);
        MainCharacterCoordinates = GetMainCharacterStartCoordinates();
        PrintMap();
        map[MainCharacterCoordinates.x, MainCharacterCoordinates.y] = freeSpace;
        Console.CursorVisible = false;
    }
    
    public char[,] GetMapFromFile(string filePath)
    {
        using var streamReader = new StreamReader(filePath);
        int maxLineLength = 0;
        int linesCount = 0;
        var lines = new List<string>();
        while (!streamReader.EndOfStream)
        {
            var currentLine = streamReader.ReadLine();
            if (currentLine.Length > maxLineLength)
            {
                maxLineLength = currentLine.Length;
            }

            lines.Add(currentLine);
            linesCount++;
        }

        var map = new char[linesCount, maxLineLength];

        for (int i = 0; i < linesCount; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                map[i, j] = lines[i][j];
            }

            for (int j = lines[i].Length; j < maxLineLength; j++)
            {
                map[i, j] = freeSpace;
            }
        }

        return map;
    }

    public void PrintMap()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }

    private (int, int) GetMainCharacterStartCoordinates()
    {
        var isMainCharacterDetectedOnMap = false;
        (int, int) mainCharacterStartCoordinates = (0, 0);
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == '@')
                {
                    if (!isMainCharacterDetectedOnMap)
                    {
                        isMainCharacterDetectedOnMap = true;
                        mainCharacterStartCoordinates = (i, j);
                    }
                    else
                    {
                        throw new InvalidDataException("There are more than one main character on the map.");
                    }
                }
            }
        }

        if (!isMainCharacterDetectedOnMap)
        {
            throw new InvalidDataException("Main character is not found in the map.");
        }
        
        return mainCharacterStartCoordinates;
    }

    private enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    private bool CanMoveInThisDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Left:
                return MainCharacterCoordinates.y > 0 &&
                       map[MainCharacterCoordinates.x, MainCharacterCoordinates.y - 1] == freeSpace;
            case Direction.Right:
                return MainCharacterCoordinates.y < map.GetLength(1) - 1 &&
                       map[MainCharacterCoordinates.x, MainCharacterCoordinates.y + 1] == freeSpace;
            case Direction.Up:
                return MainCharacterCoordinates.x > 0 &&
                       map[MainCharacterCoordinates.x - 1, MainCharacterCoordinates.y] == freeSpace;
            default: // Direction.Down
                return MainCharacterCoordinates.x < map.GetLength(0) - 1 &&
                       map[MainCharacterCoordinates.x + 1, MainCharacterCoordinates.y] == freeSpace;
        }
    }

    private void MoveMainCharacter(Direction direction)
    {
        if (CanMoveInThisDirection(direction))
        {
            Console.SetCursorPosition(MainCharacterCoordinates.y, MainCharacterCoordinates.x);
            Console.WriteLine(freeSpace);
            
            switch (direction)
            {
                case Direction.Left:
                    MainCharacterCoordinates = (MainCharacterCoordinates.x, MainCharacterCoordinates.y - 1);
                    break;
                case Direction.Right:
                    MainCharacterCoordinates = (MainCharacterCoordinates.x, MainCharacterCoordinates.y + 1);
                    break;
                case Direction.Up:
                    MainCharacterCoordinates = (MainCharacterCoordinates.x - 1, MainCharacterCoordinates.y);
                    break;
                case Direction.Down:
                    MainCharacterCoordinates = (MainCharacterCoordinates.x + 1, MainCharacterCoordinates.y);
                    break;
            }
            
            Console.SetCursorPosition(MainCharacterCoordinates.y, MainCharacterCoordinates.x);
            Console.Write('@');
        }
    }

    public void GoLeft(object? sender, EventArgs args)
    {
        MoveMainCharacter(Direction.Left);
    }
    public void GoRight(object? sender, EventArgs args)
    {
        MoveMainCharacter(Direction.Right);
    }
    public void GoUp(object? sender, EventArgs args)
    {
        MoveMainCharacter(Direction.Up);
    }
    public void GoDown(object? sender, EventArgs args)
    {
        MoveMainCharacter(Direction.Down);
    }
}