using System.Text.Json.Serialization;

namespace ConfrontationOfRaces;

public class Start
{
    public void defineClassesAndStartGame()
    {
        Barbarian barbarian = new Barbarian();
            Warrior warrior = new Warrior();
            Paladin paladin = new Paladin();
            Knight knight = new Knight();
            Spearman spearman = new Spearman();
            Archer archer = new Archer();
            Hunter hunter = new Hunter();
            Catapult catapult = new Catapult();
            Crossbowman crossbowman = new Crossbowman();
            Centaur centaur = new Centaur();
            Wizard wizard = new Wizard();
            Sorcered sorcered = new Sorcered();
            Cleric cleric = new Cleric();
            Monk monk = new Monk();
            Warlock warlock = new Warlock();

            Console.WriteLine(
                "Однажды произошла великая война между расами. Многие погибли, погибают и будут погибать... " +
                "Вражда между расами нарастает." +
                "Чтобы положить этому конец нужно, чтобы сильнейшая раса одержала победу в этой битве." +
                "\nВыберите свою расу (Для выбора введите цифру соответствующего номера):");
            Console.Write("1. ");
            barbarian.PrintAboutCharacter();
            Console.Write("2. ");
            warrior.PrintAboutCharacter();
            Console.Write("3. ");
            paladin.PrintAboutCharacter();
            Console.Write("4. ");
            knight.PrintAboutCharacter();
            Console.Write("5. ");
            spearman.PrintAboutCharacter();
            Console.Write("6. ");
            archer.PrintAboutCharacter();
            Console.Write("7. ");
            hunter.PrintAboutCharacter();
            Console.Write("8. ");
            catapult.PrintAboutCharacter();
            Console.Write("9. ");
            crossbowman.PrintAboutCharacter();
            Console.Write("10. ");
            centaur.PrintAboutCharacter();
            Console.Write("11. ");
            wizard.PrintAboutCharacter();
            Console.Write("12. ");
            sorcered.PrintAboutCharacter();
            Console.Write("13. ");
            cleric.PrintAboutCharacter();
            Console.Write("14. ");
            monk.PrintAboutCharacter();
            Console.Write("15. ");
            warlock.PrintAboutCharacter();
    }
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