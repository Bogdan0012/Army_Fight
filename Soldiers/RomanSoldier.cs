namespace Soldiers{
    using Weapon;
    public class RomanSoldier : Soldier{
        public RomanSoldier(string name) : base (name, 100, new Bastard(),new Shields.HeavyShield()){}

        public override void Attack(Soldier enemy){
          this.Weapon.Hit(this, enemy);
          this.Weapon.Hit(this, enemy);
        }
        public override void Defend(Soldier enemy){
            this.SoldierShield?.Defend(this, enemy.Weapon.Damage);
            System.Console.WriteLine($"Roman soldier defended some damage");
        }
        public override string ToString(){
            return $"{this.Name} has {this.HP} hp and send {this.Weapon.Damage} dm!";
        }
    }
}