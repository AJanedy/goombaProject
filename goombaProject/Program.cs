class Program
{
    static Goomba makeGoomba()
    {
        int moveSpeed = 5;
        int currentLocation = 0;
        bool movingForward = true;
        int stepCounter = 0;
        string emptyString = "";
        Array asciiSprite1 = new string[] { @"     ________  ",
                                            @"    /        \ ",
                                            @"   /  \    /  \ ",
                                            @"  /   |    |   \ ",
                                            @" /  -^------^-  \ ",
                                            @"|________________| ",
                                            @" ____ /    \ ",
                                            @"/____\      |____ ",
                                            @"       ==== /____\ ",
                                            @"                     " };

        Array asciiSprite2 = new string[] { @"     ________  ",
                                            @"    /        \ ",
                                            @"   /  \    /  \ ",
                                            @"  /   |    |   \ ",
                                            @" /  -^------^-  \ ",
                                            @"|________________| ",
                                            @"      /    \ ____ ",
                                            @" ____|      /____\ ",
                                            @"/____\ ====         ",
                                            @"                     " };
        Goomba newGoomba = new Goomba(asciiSprite1, asciiSprite2, moveSpeed,
                                      movingForward, currentLocation, stepCounter,
                                      emptyString);
        return newGoomba;
    }

    static void Main()
    {
        Goomba newGoomba = makeGoomba();
        Star newStar = new Star();
        ASCIIAnimation animation = new ASCIIAnimation();

        while (true)
        {
            Console.Clear();
            animation.animate(newStar);
            animation.animate(newGoomba);
            Thread.Sleep(1000 / newGoomba.MoveSpeed);
        }
    }
}