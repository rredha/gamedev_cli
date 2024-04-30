using System.ComponentModel;

namespace angrybird_logic.GAction
{
    using angrybird_logic.ConsoleInterface;

    public class GAction : ISelectableItem
    {
        ConsoleInterface _cli = new ConsoleInterface();

        private string _name;
        private bool _isSelectableItem;

        public GAction(string name, bool isSelectableItem)
        {
            this._name = name;
            this._isSelectableItem = isSelectableItem;
        }

        public void PrintSelectableItem()
        {
            if (_isSelectableItem)
            {
                _cli.Print(_name);
            }
        }

        public bool IsSelectableItem()
        {
            return true;
        }

        public void GActionDoes()
        {
           _cli.Print(_name + " is doing something"); 
        }
}
    
}
