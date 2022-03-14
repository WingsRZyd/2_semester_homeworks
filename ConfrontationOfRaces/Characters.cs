using System;

namespace ConfrontationOfRaces
{
    public abstract class Characters
    {
        public string Name;
        public string Type;
        public int Health;
        public int Damage;
        public int Armour;
        public int DodgeChance;
        public int Mana;
        public Characters(string name, int health, int damage, string type, int armour, int dodgechance, int mana)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Type = type;
            Armour = armour;
            DodgeChance = dodgechance;
            Mana = mana;
        }

        public abstract void Hit(Characters enemy);

        public abstract void Ability(Characters enemy);
        
        public void GetDamage(int damage)
        {
            Health -= damage;
        }
            
        public void GetDamageHeavyArtillery(int damage)
        {
            if (Armour > damage)
                return;
            else         //barbarian.GetDamage(50)
                Health -= (damage - Armour);
        }
        
        public void GetDamageDistantArtillery(int damage)
        {
            Random random = new Random();
            int chance = random.Next(0, 100);
            if (chance < DodgeChance)
            {
                return;
            }
            else
            {
                Health -= damage;
            }
        }

        public void CheckAndGetDamage(Characters enemy, int damage)
        {
            if (enemy.Type == "Heavy")
            {
                enemy.GetDamageHeavyArtillery(damage);
            }
            else if (enemy.Type == "Distant")
            {
                enemy.GetDamageDistantArtillery(damage);
            }
            else
            {
                enemy.GetDamage(damage);
            }
        }
        
        public void GetHealth(int health)
        {
            Health += health;
        }
        
    }

    public abstract class HeavyArtillery : Characters    //Class of Heavy Artillery
    {                                           //Unique feature: armour
        public HeavyArtillery(string name, int health, int damage, string type, int armour, int dodgechance, int mana) : base(name, health, damage, type, armour, dodgechance, mana)
        {
        }
        
    }

    public abstract class DistantArtillery : Characters  //Class of Distant Artillery
    {                                           //Unique feature: Dodge Chance
        public DistantArtillery(string name, int health, int damage, string type, int armour, int dodgechance, int mana) : base(name, health, damage, type, armour, dodgechance, mana)
        {
        }
    }

    public abstract class Mage : Characters  //Class of Mages
    {                               //Unique features: Mana, Mana Cost
        public int Mana;
        public int ManaCost;
        public Mage(string name, int health, int damage, string type, int armour, int dodgechance, int mana, int manaCost) : base(name, health, damage, type, armour, dodgechance, mana)
        {
            Mana = mana;
            ManaCost = manaCost;
        }
        
        public void manaWaste(int mana)
        {
            Mana -= mana;
        }
    }

//-------------Воины-------------
    public class Barbarian : HeavyArtillery
    {
        public Barbarian() : base("Barbarian", 130, 30, "Heavy", 5, 0, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }

        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }

        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Armour} брони.");
        }
    }
    
    public class Warrior : HeavyArtillery
    {
        public Warrior() : base("Warrior", 110, 45, "Heavy", 10, 0, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Armour} брони.");
        }
    }
    
    public class Paladin : HeavyArtillery
    {
        public Paladin() : base("Paladin", 120, 50, "Heavy", 10, 0, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Armour} брони.");
        }
    }
    
    public class Knight : HeavyArtillery
    {
        public Knight() : base("Knight", 150, 60, "Heavy", 10, 0, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Armour} брони.");
        }
    }
    
    public class Spearman : HeavyArtillery
    {
        public Spearman() : base("Spearman", 90, 40, "Heavy", 5, 0, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Armour} брони.");
        }
    }
    //-------------Дальний бой-------------
    public class Archer : DistantArtillery
    {
        public Archer() : base("Archer", 70, 40, "Distant", 0, 60, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и c {DodgeChance}% уклонения от атаки.");
        }
    } 
    
    public class Hunter : DistantArtillery
    {
        public Hunter() : base("Hunter", 90, 50, "Distant", 0, 40, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и c {DodgeChance}% уклонения от атаки.");
        }
    }
    
    public class Catapult : DistantArtillery
    {
        public Catapult() : base("Catapult", 120, 70, "Distant", 0, 10, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и c {DodgeChance}% уклонения от атаки.");
        }
    }
    
    public class Crossbowman : DistantArtillery
    {
        public Crossbowman() : base("Crossbowman", 90, 60, "Distant", 0, 30, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и c {DodgeChance}% уклонения от атаки.");
        }
    }
    
    public class Centaur : DistantArtillery
    {
        public Centaur() : base("Centaur", 110, 30, "Distant", 0, 70, 0)
        {}
        
        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }
        public override void Ability(Characters enemy)
        {
            Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
            CheckAndGetDamage(enemy, Damage);
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и c {DodgeChance}% уклонения от атаки.");
        }
    }
    
    //-------------Маги-------------
    
    public class Wizard : Mage
    {
        public Wizard() : base("Wizard", 80, 50, "Mage", 0, 0, 40, 15)
        {}

        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }

        public override void Ability(Characters enemy)
        {
            if (Mana < ManaCost)
            {
                Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
                CheckAndGetDamage(enemy, Damage);
            }
            else
            {
                manaWaste(ManaCost);
                enemy.CheckAndGetDamage(enemy, (int) (Damage * 1.5));
            }
        }
        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Mana} маны.");
            Console.WriteLine($"Способность {Name}: {Name} выпускает сгусток энергии, наносящий урона в 1,5 раза больше урона от атаки. Стоимость маны: {ManaCost}");
        }
    }

    public class Sorcered : Mage
    {
        public Sorcered() : base("Sorcered", 90, 40, "Mage", 0, 0, 50, 25)
        {}

        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }

        public override void Ability(Characters enemy)
        {
            if (Mana < ManaCost)
            {
                Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
                CheckAndGetDamage(enemy, Damage);
            }
            else
            {
                manaWaste(ManaCost);
                CheckAndGetDamage(enemy, (int) (enemy.Health * 0.3));
            }
        }

        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Mana} маны.");
            Console.WriteLine($"Способность {Name}: {Name} выжигает героя, нанося ему 30% от его текущего здоровья. Стоимость маны: {ManaCost}");
        }
    }

    public class Cleric : Mage
    {
        public Cleric() : base("Cleric", 75, 30, "Mage", 0, 0, 50, 15)
        {}

        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }

        public override void Ability(Characters enemy)
        {
            if (Mana < ManaCost)
            {
                Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
                CheckAndGetDamage(enemy, Damage);
            }
            else
            {
                manaWaste(ManaCost);
                Random random = new Random();
                int criticalChance = random.Next(0, 10);
                if (criticalChance > 4)
                {
                    CheckAndGetDamage(enemy, (3 * Damage));
                }
                else
                {
                    CheckAndGetDamage(enemy, Damage);
                }
            }
        }

        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Mana} маны.");
            Console.WriteLine($"Способность {Name}: {Name} с вероятностью 50% наносит критический урон в размере 300% от урона от атаки; в случае неудачи наносит базовый урон - {Damage}. Стоимость маны: {ManaCost}");
        }
    }
    
    public class Monk : Mage
    {
        public Monk() : base("Monk", 110, 35, "Mage", 0, 0,60, 15)
        {}

        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }

        public override void Ability(Characters enemy)
        {
            if (Mana < ManaCost)
            {
                Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
                CheckAndGetDamage(enemy, Damage);
            }
            else
            {
                manaWaste(ManaCost);
                CheckAndGetDamage(enemy, 2 * Damage);
            }
        }

        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Mana} маны.");
            Console.WriteLine($"Способность {Name}: {Name} мимолетно ускорет свои движения, что позволяет ему нанести двойной удар. Стоимость маны: {ManaCost}");
        }
    }

    public class Warlock : Mage
    {
        public Warlock() : base("Warlock", 130, 40, "Mage", 0, 0,60, 30)
        {}

        public override void Hit(Characters enemy)
        {
            CheckAndGetDamage(enemy, Damage);
        }

        public override void Ability(Characters enemy)
        {
            if (Mana < ManaCost)
            {
                Console.WriteLine("Вы не можете использовать способность - у вас закончилась мана. К врагу применена обычная атака");
                CheckAndGetDamage(enemy, Damage);
            }
            else
            {
                manaWaste(ManaCost);
                CheckAndGetDamage(enemy, 60 + Damage);
            }
        }

        public void PrintAboutCharacter()
        {
            Console.WriteLine($"{Name} имеет {Health} здоровья, {Damage} урона и {Mana} маны.");
            Console.WriteLine($"Способность {Name}: {Name} вызывает подручного демона, который делает дополнительную атаку с уроном 60. Стоимость маны: {ManaCost}");
        }
    }




























}

