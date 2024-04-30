namespace angrybird_logic.Units;
using static ConsoleInterface.ConsoleInterface;

public class Prisonner
{
    public ConsoleInterface.ConsoleInterface? Cli { get; set; }
    public bool IsFree;

    public void WhatAreYouDoing()
    {
        if (IsFree)
        {
           Cli.Print("Yaaay Free at last !!!"); 
        }
        else
        {
            Cli.Print("Please save me !");
        }
        
    }

}