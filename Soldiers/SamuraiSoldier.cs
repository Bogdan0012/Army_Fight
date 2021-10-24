namespace Soldiers{
    using Weapon;
    public class SamuraiSoldier : Soldier{
        protected System.Random r;
        public SamuraiSoldier(string name) : base (name, 70, new Katana(), new Armor.LightArmor()){ this.r = new System.Random(); }

        public override void Attack(Soldier enemy){
            this.Weapon.Hit(this, enemy);
        }
        public override void Defend(Soldier enemy){
            this.Armor?.Defend(this, enemy.Weapon.Damage);
            System.Console.WriteLine($"Samurai defended some damage");
        }
        public override string ToString(){
            return $"{this.Name} has {this.HP} hp and send {this.Weapon.Damage} dm!";
        }
    }
}