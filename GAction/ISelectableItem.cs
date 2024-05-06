namespace angrybird_logic.GAction;

public interface ISelectableItem
{
    bool IsSelectable(bool value);
    void SetSelectable(bool value);
}