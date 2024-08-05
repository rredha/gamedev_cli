using angrybird_logic.Units;

namespace angrybird_logic.GameBehaviour;

/*
 * For now this class only supports spwaning Birds,
 * I Would like to make it spawn other things as well
 * Spawn(UnitType)
 */
public  class Spawner
{
    private  List<Unit> UnitList { get; } = new();

    public  List<Unit> SpawnAndAddToList(Unit unitType, int numberOfBirds)
    {
        switch (unitType)
        {
           case Bird:
            for (var i = 0; i < numberOfBirds; i++)
            {
                UnitList.Add(Spawn<Bird>());
            }
            break;
           case Pig:
            for (var i = 0; i < numberOfBirds; i++)
            {
                UnitList.Add(Spawn<Pig>());
            }
            break;
           case Wall:
            for (var i = 0; i < numberOfBirds; i++)
            {
                UnitList.Add(Spawn<Wall>());
            }
            break;
        } 
        
        return UnitList;
    }

    public  void UnSpawn(List<Unit> unitsList)
    {
        unitsList.RemoveAt(0);
    }
    private  T Spawn<T>() where T : new()
    {
        return new T();
    }
}