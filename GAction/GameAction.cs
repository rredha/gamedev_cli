using System.ComponentModel;

namespace angrybird_logic.GAction
{
    using angrybird_logic.ConsoleInterface;

    public abstract class GameAction  
    {
        ConsoleInterface _cli = new ConsoleInterface();
        public string Name { get; set; }
        public bool IsSelectable { get; set; } 

       public void PrintSelectableGameAction(string str)
        {
            if (IsSelectable)
            {
                _cli.Print(str);
            }
        }
       public void PrintSelectedGameAction(string str)
        {
            if (IsSelectable)
            {
                _cli.Print(str + " selected.");
            }
        }

        public abstract void GameActionDoes();
    }
    
}
