namespace ConfrontationOfRaces;

public class Start
{
    public Characters ChooseCharacter(int numberPlayer)
    {
        switch (numberPlayer)
        {
            case 1:
                return new Barbarian();
            case 2:
                return new Warrior();
            case 3:
                return new Paladin();
            case 4:
                return new Knight();
            case 5:
                return new Spearman();
            case 6:
                return new Archer();
            case 7:
                return new Hunter();
            case 8:
                return new Catapult();
            case 9:
                return new Crossbowman();
            case 10:
                return new Centaur();
            case 11:
                return new Wizard();
            case 12:
                return new Sorcered();
            case 13:
                return new Cleric();
            case 14:
                return new Monk();
            case 15:
                return new Warlock();
            default:
                return new Barbarian();
        }
    }
}