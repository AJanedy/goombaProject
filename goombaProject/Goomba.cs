//using System;


public class Goomba : IEnemy
{
    public Array CharacterSprite1;
    public Array CharacterSprite2;
    public int MoveSpeed;
    public bool MovingForward;
    public int CurrentLocation;
    public int StepCounter;
    public string EmptyString;

    public Goomba(Array characterSprite1, Array characterSprite2, int moveSpeed, 
                  bool movingForward, int currentLocation, int stepCounter,
                  string emptyString)
    {
        CharacterSprite1 = characterSprite1;
        CharacterSprite2 = characterSprite2;
        MoveSpeed = moveSpeed;
        MovingForward = movingForward;
        CurrentLocation = currentLocation;
        StepCounter = stepCounter;
        EmptyString = emptyString;
    }
    static string CreateEmptyString(int numberOfSpaces)
    {
        string emptyString = "";
        for (int i = 0; i < numberOfSpaces; i++)
        {
            emptyString += " ";
        }

        return emptyString;
    }
    public void moveSprite()
    {
        if (CurrentLocation >= 100)
        {
            MovingForward = false;
        }
        if (CurrentLocation <= 0)
        {
            MovingForward = true;
        }
        if (MovingForward)
        {
            CurrentLocation += 1;
        }
        if (!MovingForward)
        {
            CurrentLocation -= 1;
        }
        StepCounter++;
    }
    public void drawSprite()
    {
        EmptyString = CreateEmptyString(CurrentLocation);

        if (StepCounter % 2 == 0)
        {
            foreach (string characters in CharacterSprite1)
            {
                Console.WriteLine(EmptyString + characters);
            }
        }
        else
        {
            foreach (string characters in CharacterSprite2)
            {
                Console.WriteLine(EmptyString + characters);
            }
        }
        
    }
}

