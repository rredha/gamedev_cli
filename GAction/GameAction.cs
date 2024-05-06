using System.ComponentModel;

namespace angrybird_logic.GAction
{
    using angrybird_logic.ConsoleInterface;

    public class GameAction  
    {
        ConsoleInterface _cli = new ConsoleInterface();

        public string Name { get; set; }
        public bool IsSelectable { get; set; } 

        public GameAction(string name)
        {
            this.Name = name;
        }

       public void PrintSelectableGameAction()
        {
            if (IsSelectable)
            {
                _cli.Print(Name);
            }
        }

    }
    
}
