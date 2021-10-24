namespace Soldiers{
    using Weapon;
    public abstract class Soldier{
        public string Name {get; set;}
        public int HP {get; set;}
        public WeaponAbstruct Weapon {get; set;}
        public Shields.Shield SoldierShield {get; set;}
        public Armor.LightArmor Armor {get; set;}
        
        private Soldier(){}
        protected Soldier(string name, int hp, WeaponAbstruct weapon) {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
        }
        protected Soldier(string name, int hp, WeaponAbstruct weapon, Armor.LightArmor armor) {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
            this.Armor = armor;
        }

        public bool IsAlive(){
            return HP > 0;
        }

        protected Soldier(string name, int hp, WeaponAbstruct weapon, Shields.Shield SoldierShield ) {
            this.Weapon = weapon;
            this.Name = name;
            this.HP = hp;
            this.SoldierShield = SoldierShield;
        }
        public abstract void Attack(Soldier enemy);
        public abstract void Defend(Soldier enemy);

        public override string ToString()
        {
            return $"{this.Name} has {this.HP} hp and send {this.Weapon.Damage} dm!";
        }

    }
}