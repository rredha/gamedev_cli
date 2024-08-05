using View;

namespace angrybird_logic.GameBehaviour
{
    public abstract class GameAction  
    {
        public ConsoleView _cli { get; set; }
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
