using View;

namespace angrybird_logic.Units;
using View;

public class Prisonner
{
    public ConsoleView? Cli { get; set; }
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