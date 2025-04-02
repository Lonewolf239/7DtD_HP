using System.Drawing;

namespace _7DtD_HP.Classes
{
    public abstract class Zombie
    {
        public enum ZombieType { Regular, Feral, Radiated }
        public ZombieType Type;
        public string Name;
        public int HealthMaxLineIndex;
        public int PhysicalDamageResistLineIndex;
        public int HealthMax;
        public int DefaultHealthMax;
        public bool HasPhysicalDamageResist;
        public int PhysicalDamageResist;
        public int DefaultPhysicalDamageResist;
        public Image Icon;

        public Zombie()
        {
            Type = ZombieType.Regular;
            HasPhysicalDamageResist = false;
            Icon = Properties.Resources.no_image;
        }

        public override string ToString()
        {
            if (Type == ZombieType.Feral) return Name + " Feral";
            if (Type == ZombieType.Radiated) return Name + " Radiated";
            return Name;
        }
    }

    public class Arlene : Zombie
    {
        public Arlene()
        {
            Name = "Arlene";
            HealthMaxLineIndex = 598;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.arlene;
        }
    }

    public class ArleneFeral : Arlene
    {
        public ArleneFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 623;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class ArleneRadiated : Arlene
    {
        public ArleneRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 641;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class Marlene : Zombie
    {
        public Marlene()
        {
            Name = "Marlene";
            HealthMaxLineIndex = 684;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.marlene;
        }
    }

    public class MarleneFeral : Marlene
    {
        public MarleneFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 704;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class MarleneRadiated : Marlene
    {
        public MarleneRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 723;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class PartyGirl : Zombie
    {
        public PartyGirl()
        {
            Name = "PartyGirl";
            HealthMaxLineIndex = 754;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.party_girl;
        }
    }

    public class PartyGirlFeral : PartyGirl
    {
        public PartyGirlFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 774;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class PartyGirlRadiated : PartyGirl
    {
        public PartyGirlRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 793;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class Nurse : Zombie
    {
        public Nurse()
        {
            Name = "Nurse";
            HealthMaxLineIndex = 836;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.nurse;
        }
    }

    public class NurseFeral : Nurse
    {
        public NurseFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 856;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class NurseRadiated : Nurse
    {
        public NurseRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 874;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class Joe : Zombie
    {
        public Joe()
        {
            Name = "Joe";
            HealthMaxLineIndex = 908;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.joe;
        }
    }

    public class JoeFeral : Joe
    {
        public JoeFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 928;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class JoeRadiated : Joe
    {
        public JoeRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 947;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class Steve : Zombie
    {
        public Steve()
        {
            Name = "Steve";
            HealthMaxLineIndex = 986;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.steve;
        }
    }

    public class SteveFeral : Steve
    {
        public SteveFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1006;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class SteveRadiated : Steve
    {
        public SteveRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1025;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class TomClark : Zombie
    {
        public TomClark()
        {
            Name = "TomClark";
            HealthMaxLineIndex = 1063;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.tom_clark;
        }
    }

    public class TomClarkFeral : TomClark
    {
        public TomClarkFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1083;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class TomClarkRadiated : TomClark
    {
        public TomClarkRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1102;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class BusinessMan : Zombie
    {
        public BusinessMan()
        {
            Name = "BusinessMan";
            HealthMaxLineIndex = 1136;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.business_man;
        }
    }

    public class BusinessManFeral : BusinessMan
    {
        public BusinessManFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1156;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class BusinessManRadiated : BusinessMan
    {
        public BusinessManRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1175;
            DefaultHealthMax = HealthMax = 1200;
        }
    }

    public class Burnt : Zombie
    {
        public Burnt()
        {
            Name = "Burnt";
            HealthMaxLineIndex = 1215;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.burnt;
        }
    }

    public class BurntFeral : Burnt
    {
        public BurntFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1236;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class BurntRadiated : Burnt
    {
        public BurntRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1253;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class Spider : Zombie
    {
        public Spider()
        {
            Name = "Spider";
            HealthMaxLineIndex = 1326;
            DefaultHealthMax = HealthMax = 150;
            Icon = Properties.Resources.spider;
        }
    }

    public class SpiderFeral : Spider
    {
        public SpiderFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1345;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class SpiderRadiated : Spider
    {
        public SpiderRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1363;
            DefaultHealthMax = HealthMax = 1000;
        }
    }

    public class Boe : Zombie
    {
        public Boe()
        {
            Name = "Boe";
            HealthMaxLineIndex = 1406;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.boe;
        }
    }

    public class BoeFeral : Boe
    {
        public BoeFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1425;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class BoeRadiated : Boe
    {
        public BoeRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1444;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class MaleHazmat : Zombie
    {
        public MaleHazmat()
        {
            Name = "MaleHazmat";
            HealthMaxLineIndex = 1513;
            DefaultHealthMax = HealthMax = 550;
            Icon = Properties.Resources.male_hazmat;
        }
    }

    public class MaleHazmatRadiated : MaleHazmat
    {
        public MaleHazmatRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1544;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Janitor : Zombie
    {
        public Janitor()
        {
            Name = "Janitor";
            HealthMaxLineIndex = 1579;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.janitor;
        }
    }

    public class JanitorFeral : Janitor
    {
        public JanitorFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1598;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class JanitorRadiated : Janitor
    {
        public JanitorRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1625;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Inmate : Zombie
    {
        public Inmate()
        {
            Name = "Inmate";
            HealthMaxLineIndex = 1658;
            DefaultHealthMax = HealthMax = 200;
        }
    }

    public class InmateFeral : Inmate
    {
        public InmateFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1678;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class InmateRadiated : Inmate
    {
        public InmateRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1705;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Moe : Zombie
    {
        public Moe()
        {
            Name = "Moe";
            HealthMaxLineIndex = 1748;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.moe;
        }
    }

    public class MoeFeral : Moe
    {
        public MoeFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1767;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class MoeRadiated : Moe
    {
        public MoeRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1786;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Lab : Zombie
    {
        public Lab()
        {
            Name = "Lab";
            HealthMaxLineIndex = 1827;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.lab;
        }
    }

    public class LabFeral : Lab
    {
        public LabFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1846;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class LabRadiated : Lab
    {
        public LabRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1862;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Darlene : Zombie
    {
        public Darlene()
        {
            Name = "Darlene";
            HealthMaxLineIndex = 1903;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.darlene;
        }
    }

    public class DarleneFeral : Darlene
    {
        public DarleneFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1922;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class DarleneRadiated : Darlene
    {
        public DarleneRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 1941;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Yo : Zombie
    {
        public Yo()
        {
            Name = "Yo";
            HealthMaxLineIndex = 1975;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.yo;
        }
    }

    public class YoFeral : Yo
    {
        public YoFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 1994;
            DefaultHealthMax = HealthMax = 550;
        }
    }

    public class YoRadiated : Yo
    {
        public YoRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2013;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class UtilityWorker : Zombie
    {
        public UtilityWorker()
        {
            Name = "UtilityWorker";
            HealthMaxLineIndex = 2055;
            DefaultHealthMax = HealthMax = 200;
            HasPhysicalDamageResist = true;
            PhysicalDamageResistLineIndex = 2056;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 20;
            Icon = Properties.Resources.utility_worker;
        }
    }

    public class UtilityWorkerFeral : UtilityWorker
    {
        public UtilityWorkerFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2075;
            DefaultHealthMax = HealthMax = 550;
            PhysicalDamageResistLineIndex = 2076;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 20;
        }
    }

    public class UtilityWorkerRadiated : UtilityWorker
    {
        public UtilityWorkerRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HasPhysicalDamageResist = false;
            HealthMaxLineIndex = 2095;
            DefaultHealthMax = HealthMax = 1100;
        }
    }

    public class Biker : Zombie
    {
        public Biker()
        {
            Name = "Biker";
            HealthMaxLineIndex = 2122;
            DefaultHealthMax = HealthMax = 550;
            HasPhysicalDamageResist = true;
            PhysicalDamageResistLineIndex = 2123;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 20;
            Icon = Properties.Resources.biker;
        }
    }

    public class BikerFeral : Biker
    {
        public BikerFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2155;
            DefaultHealthMax = HealthMax = 900;
            PhysicalDamageResistLineIndex = 2156;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 20;
        }
    }

    public class BikerRadiated : Biker
    {
        public BikerRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2174;
            DefaultHealthMax = HealthMax = 1800;
            PhysicalDamageResistLineIndex = 2175;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 20;
        }
    }

    public class Lumberjack : Zombie
    {
        public Lumberjack()
        {
            Name = "Lumberjack";
            HealthMaxLineIndex = 2219;
            DefaultHealthMax = HealthMax = 450;
            Icon = Properties.Resources.lumberjack;
        }
    }

    public class LumberjackFeral : Lumberjack
    {
        public LumberjackFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2239;
            DefaultHealthMax = HealthMax = 950;
        }
    }

    public class LumberjackRadiated : Lumberjack
    {
        public LumberjackRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2258;
            DefaultHealthMax = HealthMax = 1900;
        }
    }

    public class FemaleFat : Zombie
    {
        public FemaleFat()
        {
            Name = "FemaleFat";
            HealthMaxLineIndex = 2298;
            DefaultHealthMax = HealthMax = 450;
            Icon = Properties.Resources.female_fat;
        }
    }

    public class FemaleFatFeral : FemaleFat
    {
        public FemaleFatFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2330;
            DefaultHealthMax = HealthMax = 950;
        }
    }

    public class FemaleFatRadiated : FemaleFat
    {
        public FemaleFatRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2350;
            DefaultHealthMax = HealthMax = 1900;
        }
    }

    public class FatHawaiian : Zombie
    {
        public FatHawaiian()
        {
            Name = "FatHawaiian";
            HealthMaxLineIndex = 2397;
            DefaultHealthMax = HealthMax = 450;
            Icon = Properties.Resources.fat_hawaiian;
        }
    }

    public class FatHawaiianFeral : FatHawaiian
    {
        public FatHawaiianFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2417;
            DefaultHealthMax = HealthMax = 950;
        }
    }

    public class FatHawaiianRadiated : FatHawaiian
    {
        public FatHawaiianRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2436;
            DefaultHealthMax = HealthMax = 1900;
        }
    }

    public class Bowler : Zombie
    {
        public Bowler()
        {
            Name = "Bowler";
            HealthMaxLineIndex = 2483;
            DefaultHealthMax = HealthMax = 450;
        }
    }

    public class BowlerFeral : Bowler
    {
        public BowlerFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2503;
            DefaultHealthMax = HealthMax = 950;
        }
    }

    public class BowlerRadiated : Bowler
    {
        public BowlerRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2522;
            DefaultHealthMax = HealthMax = 1900;
        }
    }

    public class FatCop : Zombie
    {
        public FatCop()
        {
            Name = "FatCop";
            HealthMaxLineIndex = 2593;
            DefaultHealthMax = HealthMax = 450;
            Icon = Properties.Resources.fat_cop;
        }
    }

    public class FatCopFeral : FatCop
    {
        public FatCopFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2620;
            DefaultHealthMax = HealthMax = 950;
        }
    }

    public class FatCopRadiated : FatCop
    {
        public FatCopRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2652;
            DefaultHealthMax = HealthMax = 1900;
        }
    }

    public class Skateboarder : Zombie
    {
        public Skateboarder()
        {
            Name = "Skateboarder";
            HealthMaxLineIndex = 2697;
            DefaultHealthMax = HealthMax = 250;
            Icon = Properties.Resources.skateboarder;
        }
    }

    public class SkateboarderFeral : Skateboarder
    {
        public SkateboarderFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2717;
            DefaultHealthMax = HealthMax = 700;
        }
    }

    public class SkateboarderRadiated : Skateboarder
    {
        public SkateboarderRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2737;
            DefaultHealthMax = HealthMax = 1400;
        }
    }

    public class Soldier : Zombie
    {
        public Soldier()
        {
            Name = "Soldier";
            HealthMaxLineIndex = 2769;
            DefaultHealthMax = HealthMax = 250;
            HasPhysicalDamageResist = true;
            PhysicalDamageResistLineIndex = 2770;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 50;
            Icon = Properties.Resources.soldier;
        }
    }

    public class SoldierFeral : Soldier
    {
        public SoldierFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2801;
            DefaultHealthMax = HealthMax = 800;
            PhysicalDamageResistLineIndex = 2802;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 50;
        }
    }

    public class SoldierRadiated : Soldier
    {
        public SoldierRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2822;
            DefaultHealthMax = HealthMax = 1600;
            PhysicalDamageResistLineIndex = 2823;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 50;
        }
    }

    public class Wight : Zombie
    {
        public Wight()
        {
            Name = "Wight";
            HealthMaxLineIndex = 2869;
            DefaultHealthMax = HealthMax = 1200;
            Icon = Properties.Resources.wight;
        }
    }

    public class WightRadiated : Wight
    {
        public WightRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2901;
            DefaultHealthMax = HealthMax = 2400;
        }
    }

    public class Screamer : Zombie
    {
        public Screamer()
        {
            Name = "Screamer";
            HealthMaxLineIndex = 2932;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.screamer;
        }
    }

    public class ScreamerFeral : Screamer
    {
        public ScreamerFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 2963;
            DefaultHealthMax = HealthMax = 250;
        }
    }

    public class ScreamerRadiated : Screamer
    {
        public ScreamerRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 2983;
            DefaultHealthMax = HealthMax = 500;
        }
    }

    public class Mutated : Zombie
    {
        public Mutated()
        {
            Name = "Mutated";
            HealthMaxLineIndex = 3038;
            DefaultHealthMax = HealthMax = 600;
            Icon = Properties.Resources.mutated;
        }
    }

    public class MutatedFeral : Mutated
    {
        public MutatedFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 3058;
            DefaultHealthMax = HealthMax = 900;
        }
    }

    public class MutatedRadiated : Mutated
    {
        public MutatedRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 3079;
            DefaultHealthMax = HealthMax = 1800;
        }
    }

    public class Demolition : Zombie
    {
        public Demolition()
        {
            Name = "Demolition";
            HealthMaxLineIndex = 3145;
            DefaultHealthMax = HealthMax = 1200;
            HasPhysicalDamageResist = true;
            PhysicalDamageResistLineIndex = 3147;
            DefaultPhysicalDamageResist = PhysicalDamageResist = 60;
            Icon = Properties.Resources.demolition;
        }
    }

    public class SteveCrawler : Zombie
    {
        public SteveCrawler()
        {
            Name = "SteveCrawler";
            HealthMaxLineIndex = 3187;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.steve_crawler;
        }
    }

    public class SteveCrawlerFeral : SteveCrawler
    {
        public SteveCrawlerFeral() : base()
        {
            Type = ZombieType.Feral;
            HealthMaxLineIndex = 3205;
            DefaultHealthMax = HealthMax = 300;
        }
    }

    public class ZombieBear : Zombie
    {
        public ZombieBear()
        {
            Name = "ZombieBear";
            HealthMaxLineIndex = 3705;
            DefaultHealthMax = HealthMax = 4000;
            Icon = Properties.Resources.zombie_bear;
        }
    }

    public class DireWolf : Zombie
    {
        public DireWolf()
        {
            Name = "DireWolf";
            HealthMaxLineIndex = 3825;
            DefaultHealthMax = HealthMax = 3000;
            Icon = Properties.Resources.dire_wolf;
        }
    }

    public class ZombieVulture : Zombie
    {
        public ZombieVulture()
        {
            Name = "ZombieVulture";
            HealthMaxLineIndex = 4041;
            DefaultHealthMax = HealthMax = 30;
            Icon = Properties.Resources.zombie_vulture;
        }
    }

    public class ZombieVultureRadiated : ZombieVulture
    {
        public ZombieVultureRadiated() : base()
        {
            Type = ZombieType.Radiated;
            HealthMaxLineIndex = 4072;
            DefaultHealthMax = HealthMax = 120;
        }
    }

    public class ZombieDog : Zombie
    {
        public ZombieDog()
        {
            Name = "ZombieDog";
            HealthMaxLineIndex = 4138;
            DefaultHealthMax = HealthMax = 200;
            Icon = Properties.Resources.zombie_dog;
        }
    }
}