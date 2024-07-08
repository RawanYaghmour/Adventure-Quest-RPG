using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public abstract class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Use(Player player);

    }

    public class Potion : Items
    {
        public int Medicine { get; set; }

        public Potion(string name, int medicine)
        {
            Name = name;
            Description = "A magical potion that heals the player when consumed.\n\tHealth: +50";
            Medicine = medicine;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }

    }
    public class DefensiveStructures : Items
    {
        public int defensive_Structures { get; set; }

        public DefensiveStructures(string name, int defensive_structures)
        {
            Name = name;
            Description = "Structures built to defend against attacks and withstand damage.\n\tHealth: +50";
            defensive_Structures = defensive_structures;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class ThunderSpears : Items
    {
        public int thunder_Spears { get; set; }

        public ThunderSpears(string name, int thunder_spears)
        {
            Name = name;
            Description = "Powerful spears capable of delivering electric shocks.\n\tAttack Power: +30";
            thunder_Spears = thunder_spears;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class PersonalArmor : Items
    {
        public int Armor { get; set; }

        public PersonalArmor(string name, int armor)
        {
            Name = name;
            Description = "Armor designed to protect the wearer's health.\n\tDefense: +30";
            Armor = armor;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class UltrahardSteelBlades : Items
    {
        public int Blades { get; set; }

        public UltrahardSteelBlades(string name, int blades)
        {
            Name = name;
            Description = "Extremely sharp blades made of ultrahard steel.\n\tAttack Power: +50";
            Blades = blades;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
    public class ODM_Gear : Items
    {
        public int Repo { get; set; }

        public ODM_Gear(string name, int repo)
        {
            Name = name;
            Description = "Advanced maneuvering equipment for defense.\n\tDefense: +50";
            Repo = repo;
        }

        public override void Use(Player player)
        {
            player.EquipItem(this);
        }
    }
}
