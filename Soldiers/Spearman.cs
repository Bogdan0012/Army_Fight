namespace Soldiers{
    using Weapon;
    public class Spearman : Soldier{
        public Spearman(string name) : base (name, 100, new Spear(), new Shields.MiddleShield()){}

        public override void Attack(Soldier enemy){
            this.Weapon.Hit(this, enemy);
        }
        public override void Defend(Soldier enemy){
            this.SoldierShield?.Defend(this, enemy.Weapon.Damage);
            System.Console.WriteLine($"Spearman defended some damage");
        }
        public override string ToString(){
            return $"{this.Name} has {this.HP} hp and send {this.Weapon.Damage} dm!";
        }
    }
}