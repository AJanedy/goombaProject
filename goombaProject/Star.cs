public class Star : IEnemy
{
    public bool MovingForward = true;
    public int StepCounter = 0;
    public Array StarSprite1 = new string[] { @"           ",
                                              @"  ___/\___ ",
                                              @"  \  ||  / ",
                                              @"  /__  __\ ",
                                              @"     \/    "};
    public Array StarSprite2 = new string[] { @"            ",
                                              @"   ___/\___ ",
                                              @"   \  ||  / ",
                                              @"   /__  __\ ",
                                              @"      \/    "};
    public void moveSprite()
    {
        if (StepCounter % 4 == 0 && MovingForward) 
        {
            MovingForward = false;
        }
        else if (StepCounter % 4 == 0 && !MovingForward)
        {
            MovingForward = true;
        }
        StepCounter++;
    }
    public void drawSprite()
    {
        if (MovingForward == true)
        {
            foreach (string characters in StarSprite1)
            {
                Console.WriteLine(characters);
            }
        }
        else
        {
            foreach (string characters in StarSprite2)
            {
                Console.WriteLine(characters);
            }
        }
    }

}