using System.ComponentModel;

namespace angrybird_logic.GAction
{
    using angrybird_logic.ConsoleInterface;

    public class GameAction : ISelectableGameAction
    {
        ConsoleInterface _cli = new ConsoleInterface();

        private string _name;
        private bool _isSelectableItem;

        public GameAction(string name, bool isSelectableItem)
        {
            this._name = name;
            this._isSelectableItem = isSelectableItem;
        }

        public void PrintSelectableGameAction()
        {
            if (_isSelectableItem)
            {
                _cli.Print(_name);
            }
        }

        public bool IsSelectableGameAction()
        {
            return true;
        }

        public void GameActionDoes()
        {
           _cli.Print(_name + " is doing something"); 
        }
}
    
}
